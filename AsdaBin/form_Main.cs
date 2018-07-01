using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AsdaBin
{
  public partial class form_Main : Form
  {
    public form_Main()
    {
      InitializeComponent();
    }

    private void form_Main_Load(object sender, EventArgs e)
    {
      Dictionary<string, int> versions = new Dictionary<string, int>();
      int[] versionValues = Enum.GetValues(typeof(CryptHelper.Version)).Cast<int>().ToArray();
      string[] versionNames = Enum.GetNames(typeof(CryptHelper.Version));

      for (int i = 0; i < versionNames.Length; i++)
      {
        versions.Add(versionNames[i], versionValues[i]);
      }

      cmbx_Version_From.DataSource = new BindingSource(versions, null);
      cmbx_Version_To.DataSource = new BindingSource(versions, null);
      cmbx_Version_From.DisplayMember = cmbx_Version_To.DisplayMember = "Key";
      cmbx_Version_From.ValueMember = cmbx_Version_To.ValueMember = "Value";
    }

    private void form_Main_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    private void form_Main_DragDrop(object sender, DragEventArgs e)
    {
      string[] droppedData = (string[])e.Data.GetData(DataFormats.FileDrop);
      txt_path.Text = droppedData[0];

      if (Directory.Exists(txt_path.Text))
      {
        rdbtn_Directory.Checked = true;
      }
      else
      {
        rdbtn_File.Checked = true;
      }
    }

    private void btn_Browse_Click(object sender, EventArgs e)
    {
      if (rdbtn_File.Checked)
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Multiselect = false;
        openFileDialog.Filter = "Bin File|*.bin";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          txt_path.Text = openFileDialog.FileName;
        }
      }
      else
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
          txt_path.Text = folderBrowserDialog.SelectedPath;
        }
      }
    }

    private void btn_Detect_Version_Click(object sender, EventArgs e)
    {
      if (!rdbtn_File.Checked)
      {
        MessageBox.Show("Version detection works for single file only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else if (txt_path.Text.Equals(""))
      {
        MessageBox.Show("You must specify a file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else if (!txt_path.Text.ToLower().EndsWith(".bin"))
      {
        MessageBox.Show("The file must be .bin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        int version = CryptHelper.detectVersion(File.ReadAllBytes(txt_path.Text));

        if (version == -1)
        {
          lbl_Detected_Version.Text = "Unkown Version";
        }
        else
        {
          cmbx_Version_From.SelectedIndex = version;
          lbl_Detected_Version.Text = cmbx_Version_From.Text;
        }
      }
    }

    private void rdbtn_File_CheckedChanged(object sender, EventArgs e)
    {
      txt_path.Text = "";
    }

    delegate byte[] binFileOperation(string fileName);

    private void btn_Decrypt_Click(object sender, EventArgs e)
    {
      process((file) => { return CryptHelper.decryptBin(file, (CryptHelper.Version)cmbx_Version_From.SelectedIndex); });
    }

    private void btn_Encrypt_Click(object sender, EventArgs e)
    {
      process((file) => { return CryptHelper.encryptBin(file, (CryptHelper.Version)cmbx_Version_To.SelectedIndex); });
    }

    private void btn_Convert_Click(object sender, EventArgs e)
    {
      process((file) => { return CryptHelper.convertBin(file, (CryptHelper.Version)cmbx_Version_From.SelectedIndex, (CryptHelper.Version)cmbx_Version_To.SelectedIndex); });
    }

    void process(binFileOperation op)
    {
      if (txt_path.Text.Equals(""))
      {
        MessageBox.Show("You must specify a file or a path first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else if (rdbtn_File.Checked)
      {
        if (!txt_path.Text.ToLower().EndsWith(".bin"))
        {
          MessageBox.Show("The file must be .bin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
          SaveFileDialog saveFileDialog = new SaveFileDialog();
          saveFileDialog.Filter = "Bin File|*.bin";
          saveFileDialog.FileName = Path.GetFileName(txt_path.Text);
          saveFileDialog.InitialDirectory = Path.GetDirectoryName(txt_path.Text);

          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            File.WriteAllBytes(saveFileDialog.FileName, op(txt_path.Text));
          }
          else
          {
            MessageBox.Show("You did not select path to save the file!", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }
      }
      else
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.SelectedPath = txt_path.Text;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
          foreach (string file in Directory.GetFiles(txt_path.Text, "*.bin"))
          {
            File.WriteAllBytes(folderBrowserDialog.SelectedPath + "\\" + Path.GetFileName(file), op(file));
          }
        }
        else
        {
          MessageBox.Show("You did not select path to save the files!", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }
  }
}