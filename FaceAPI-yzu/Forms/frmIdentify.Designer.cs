namespace FaceAPI_yzu.Forms
{
    partial class frmIdentify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentify));
            this.cbxPersonGroup = new System.Windows.Forms.ComboBox();
            this.lblPersonGroup = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.plTag = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbxPersonGroup
            // 
            this.cbxPersonGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonGroup.FormattingEnabled = true;
            this.cbxPersonGroup.Location = new System.Drawing.Point(136, 15);
            this.cbxPersonGroup.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbxPersonGroup.Name = "cbxPersonGroup";
            this.cbxPersonGroup.Size = new System.Drawing.Size(121, 32);
            this.cbxPersonGroup.TabIndex = 25;
            this.cbxPersonGroup.SelectedIndexChanged += new System.EventHandler(this.cbxPersonGroup_SelectedIndexChanged);
            // 
            // lblPersonGroup
            // 
            this.lblPersonGroup.AutoSize = true;
            this.lblPersonGroup.Location = new System.Drawing.Point(17, 19);
            this.lblPersonGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonGroup.Name = "lblPersonGroup";
            this.lblPersonGroup.Size = new System.Drawing.Size(106, 24);
            this.lblPersonGroup.TabIndex = 24;
            this.lblPersonGroup.Text = "比對群組";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(1352, 63);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 38);
            this.btnUpload.TabIndex = 23;
            this.btnUpload.Text = "上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(1280, 63);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(65, 38);
            this.btnOpenFile.TabIndex = 22;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(136, 63);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(1135, 36);
            this.txtFileName.TabIndex = 21;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(17, 65);
            this.lblPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(106, 24);
            this.lblPicture.TabIndex = 20;
            this.lblPicture.Text = "選擇照片";
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(782, 123);
            this.txtResult.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(658, 644);
            this.txtResult.TabIndex = 27;
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerson.Location = new System.Drawing.Point(21, 723);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(749, 36);
            this.txtPerson.TabIndex = 26;
            // 
            // plTag
            // 
            this.plTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plTag.BackColor = System.Drawing.Color.Transparent;
            this.plTag.Location = new System.Drawing.Point(19, 123);
            this.plTag.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(754, 592);
            this.plTag.TabIndex = 28;
            // 
            // frmIdentify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 782);
            this.Controls.Add(this.cbxPersonGroup);
            this.Controls.Add(this.lblPersonGroup);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.plTag);
            this.Name = "frmIdentify";
            this.Text = "frmIdentify";
            this.Load += new System.EventHandler(this.frmIdentify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPersonGroup;
        private System.Windows.Forms.Label lblPersonGroup;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Panel plTag;
    }
}