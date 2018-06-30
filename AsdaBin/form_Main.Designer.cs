namespace AsdaBin
{
    partial class form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Detected_Version = new System.Windows.Forms.Label();
            this.cmbx_Version_From = new System.Windows.Forms.ComboBox();
            this.lbl_Version_From = new System.Windows.Forms.Label();
            this.lbl_Version_To = new System.Windows.Forms.Label();
            this.cmbx_Version_To = new System.Windows.Forms.ComboBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.rdbtn_File = new System.Windows.Forms.RadioButton();
            this.rdbtn_Directory = new System.Windows.Forms.RadioButton();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Detect_Version = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(12, 16);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(45, 13);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "Vesion: ";
            // 
            // lbl_Detected_Version
            // 
            this.lbl_Detected_Version.AutoSize = true;
            this.lbl_Detected_Version.Location = new System.Drawing.Point(51, 16);
            this.lbl_Detected_Version.Name = "lbl_Detected_Version";
            this.lbl_Detected_Version.Size = new System.Drawing.Size(0, 13);
            this.lbl_Detected_Version.TabIndex = 0;
            // 
            // cmbx_Version_From
            // 
            this.cmbx_Version_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Version_From.FormattingEnabled = true;
            this.cmbx_Version_From.Location = new System.Drawing.Point(217, 13);
            this.cmbx_Version_From.Name = "cmbx_Version_From";
            this.cmbx_Version_From.Size = new System.Drawing.Size(139, 21);
            this.cmbx_Version_From.TabIndex = 1;
            // 
            // lbl_Version_From
            // 
            this.lbl_Version_From.AutoSize = true;
            this.lbl_Version_From.Location = new System.Drawing.Point(181, 16);
            this.lbl_Version_From.Name = "lbl_Version_From";
            this.lbl_Version_From.Size = new System.Drawing.Size(35, 13);
            this.lbl_Version_From.TabIndex = 0;
            this.lbl_Version_From.Text = "From:";
            // 
            // lbl_Version_To
            // 
            this.lbl_Version_To.AutoSize = true;
            this.lbl_Version_To.Location = new System.Drawing.Point(362, 16);
            this.lbl_Version_To.Name = "lbl_Version_To";
            this.lbl_Version_To.Size = new System.Drawing.Size(23, 13);
            this.lbl_Version_To.TabIndex = 0;
            this.lbl_Version_To.Text = "To:";
            // 
            // cmbx_Version_To
            // 
            this.cmbx_Version_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Version_To.FormattingEnabled = true;
            this.cmbx_Version_To.Location = new System.Drawing.Point(388, 13);
            this.cmbx_Version_To.Name = "cmbx_Version_To";
            this.cmbx_Version_To.Size = new System.Drawing.Size(139, 21);
            this.cmbx_Version_To.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(473, 40);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(54, 23);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_path
            // 
            this.txt_path.Enabled = false;
            this.txt_path.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(12, 41);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(455, 23);
            this.txt_path.TabIndex = 3;
            // 
            // rdbtn_File
            // 
            this.rdbtn_File.AutoSize = true;
            this.rdbtn_File.Checked = true;
            this.rdbtn_File.Location = new System.Drawing.Point(12, 73);
            this.rdbtn_File.Name = "rdbtn_File";
            this.rdbtn_File.Size = new System.Drawing.Size(41, 17);
            this.rdbtn_File.TabIndex = 4;
            this.rdbtn_File.TabStop = true;
            this.rdbtn_File.Text = "File";
            this.rdbtn_File.UseVisualStyleBackColor = true;
            this.rdbtn_File.CheckedChanged += new System.EventHandler(this.rdbtn_File_CheckedChanged);
            // 
            // rdbtn_Directory
            // 
            this.rdbtn_Directory.AutoSize = true;
            this.rdbtn_Directory.Location = new System.Drawing.Point(59, 73);
            this.rdbtn_Directory.Name = "rdbtn_Directory";
            this.rdbtn_Directory.Size = new System.Drawing.Size(69, 17);
            this.rdbtn_Directory.TabIndex = 5;
            this.rdbtn_Directory.Text = "Directory";
            this.rdbtn_Directory.UseVisualStyleBackColor = true;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(473, 70);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(54, 23);
            this.btn_Convert.TabIndex = 9;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(413, 70);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(54, 23);
            this.btn_Encrypt.TabIndex = 8;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(353, 70);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(54, 23);
            this.btn_Decrypt.TabIndex = 7;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Detect_Version
            // 
            this.btn_Detect_Version.Location = new System.Drawing.Point(261, 70);
            this.btn_Detect_Version.Name = "btn_Detect_Version";
            this.btn_Detect_Version.Size = new System.Drawing.Size(86, 23);
            this.btn_Detect_Version.TabIndex = 6;
            this.btn_Detect_Version.Text = "Detect Version";
            this.btn_Detect_Version.UseVisualStyleBackColor = true;
            this.btn_Detect_Version.Click += new System.EventHandler(this.btn_Detect_Version_Click);
            // 
            // form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 101);
            this.Controls.Add(this.rdbtn_Directory);
            this.Controls.Add(this.rdbtn_File);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_Detect_Version);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.cmbx_Version_To);
            this.Controls.Add(this.cmbx_Version_From);
            this.Controls.Add(this.lbl_Version_To);
            this.Controls.Add(this.lbl_Detected_Version);
            this.Controls.Add(this.lbl_Version_From);
            this.Controls.Add(this.lbl_Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsdaBin";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.form_Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.form_Main_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Detected_Version;
        private System.Windows.Forms.ComboBox cmbx_Version_From;
        private System.Windows.Forms.Label lbl_Version_From;
        private System.Windows.Forms.Label lbl_Version_To;
        private System.Windows.Forms.ComboBox cmbx_Version_To;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.RadioButton rdbtn_File;
        private System.Windows.Forms.RadioButton rdbtn_Directory;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Detect_Version;
    }
}

