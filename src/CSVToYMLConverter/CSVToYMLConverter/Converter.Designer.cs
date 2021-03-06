namespace CSVToYMLConverter
{
    partial class Converter
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.openYMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderJSSTargetBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtCSVFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCSVFile = new System.Windows.Forms.Button();
            this.btnYMLFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYMLFile = new System.Windows.Forms.TextBox();
            this.btnTargetJSSFolderPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTargetJSSFolderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanguageCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlCSVFieldNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(345, 486);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(102, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(52, 248);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(696, 106);
            this.txtMessage.TabIndex = 2;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(52, 403);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(696, 56);
            this.txtError.TabIndex = 3;
            // 
            // openYMLFileDialog
            // 
            this.openYMLFileDialog.FileName = "en.yml";
            this.openYMLFileDialog.Filter = "YML files|*.yml";
            // 
            // openCSVFileDialog
            // 
            this.openCSVFileDialog.FileName = "content.csv";
            this.openCSVFileDialog.Filter = "CSV files|*.csv";
            // 
            // txtCSVFile
            // 
            this.txtCSVFile.Location = new System.Drawing.Point(239, 43);
            this.txtCSVFile.Name = "txtCSVFile";
            this.txtCSVFile.ReadOnly = true;
            this.txtCSVFile.Size = new System.Drawing.Size(408, 20);
            this.txtCSVFile.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Browse CSV file:";
            // 
            // btnCSVFile
            // 
            this.btnCSVFile.Location = new System.Drawing.Point(645, 41);
            this.btnCSVFile.Name = "btnCSVFile";
            this.btnCSVFile.Size = new System.Drawing.Size(26, 23);
            this.btnCSVFile.TabIndex = 10;
            this.btnCSVFile.Text = "...";
            this.btnCSVFile.UseVisualStyleBackColor = true;
            this.btnCSVFile.Click += new System.EventHandler(this.btnCSVFile_Click);
            // 
            // btnYMLFile
            // 
            this.btnYMLFile.Location = new System.Drawing.Point(645, 77);
            this.btnYMLFile.Name = "btnYMLFile";
            this.btnYMLFile.Size = new System.Drawing.Size(26, 23);
            this.btnYMLFile.TabIndex = 13;
            this.btnYMLFile.Text = "...";
            this.btnYMLFile.UseVisualStyleBackColor = true;
            this.btnYMLFile.Click += new System.EventHandler(this.btnYMLFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Browse YML file:";
            // 
            // txtYMLFile
            // 
            this.txtYMLFile.Location = new System.Drawing.Point(239, 79);
            this.txtYMLFile.Name = "txtYMLFile";
            this.txtYMLFile.ReadOnly = true;
            this.txtYMLFile.Size = new System.Drawing.Size(408, 20);
            this.txtYMLFile.TabIndex = 11;
            // 
            // btnTargetJSSFolderPath
            // 
            this.btnTargetJSSFolderPath.Location = new System.Drawing.Point(645, 113);
            this.btnTargetJSSFolderPath.Name = "btnTargetJSSFolderPath";
            this.btnTargetJSSFolderPath.Size = new System.Drawing.Size(26, 23);
            this.btnTargetJSSFolderPath.TabIndex = 16;
            this.btnTargetJSSFolderPath.Text = "...";
            this.btnTargetJSSFolderPath.UseVisualStyleBackColor = true;
            this.btnTargetJSSFolderPath.Click += new System.EventHandler(this.btnTargetJSSFolderPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Target JSS Folder Path:";
            // 
            // txtTargetJSSFolderPath
            // 
            this.txtTargetJSSFolderPath.Location = new System.Drawing.Point(239, 115);
            this.txtTargetJSSFolderPath.Name = "txtTargetJSSFolderPath";
            this.txtTargetJSSFolderPath.ReadOnly = true;
            this.txtTargetJSSFolderPath.Size = new System.Drawing.Size(408, 20);
            this.txtTargetJSSFolderPath.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Updation Progress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Errors:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Enter language code (en, da-DK, hi-IN etc) :";
            // 
            // txtLanguageCode
            // 
            this.txtLanguageCode.Location = new System.Drawing.Point(239, 151);
            this.txtLanguageCode.Name = "txtLanguageCode";
            this.txtLanguageCode.Size = new System.Drawing.Size(88, 20);
            this.txtLanguageCode.TabIndex = 23;
            this.txtLanguageCode.Text = "en";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Select field for Item Name :";
            // 
            // ddlCSVFieldNames
            // 
            this.ddlCSVFieldNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCSVFieldNames.FormattingEnabled = true;
            this.ddlCSVFieldNames.Location = new System.Drawing.Point(239, 186);
            this.ddlCSVFieldNames.Name = "ddlCSVFieldNames";
            this.ddlCSVFieldNames.Size = new System.Drawing.Size(194, 21);
            this.ddlCSVFieldNames.TabIndex = 28;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.ddlCSVFieldNames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLanguageCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTargetJSSFolderPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTargetJSSFolderPath);
            this.Controls.Add(this.btnYMLFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYMLFile);
            this.Controls.Add(this.btnCSVFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCSVFile);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV To YML Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.OpenFileDialog openYMLFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderJSSTargetBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.TextBox txtCSVFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCSVFile;
        private System.Windows.Forms.Button btnYMLFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYMLFile;
        private System.Windows.Forms.Button btnTargetJSSFolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTargetJSSFolderPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLanguageCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlCSVFieldNames;
    }
}

