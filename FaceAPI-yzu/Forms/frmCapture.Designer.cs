namespace FaceAPI_yzu.Forms
{
    partial class frmCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapture));
            this.btnCam = new System.Windows.Forms.Button();
            this.cbxPersonGroup = new System.Windows.Forms.ComboBox();
            this.lblPersonGroup = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.plTag = new System.Windows.Forms.Panel();
            this.txtPerson = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCam
            // 
            this.btnCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCam.Location = new System.Drawing.Point(1022, 10);
            this.btnCam.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(95, 38);
            this.btnCam.TabIndex = 17;
            this.btnCam.Text = "照像";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // cbxPersonGroup
            // 
            this.cbxPersonGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonGroup.FormattingEnabled = true;
            this.cbxPersonGroup.Location = new System.Drawing.Point(123, 14);
            this.cbxPersonGroup.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbxPersonGroup.Name = "cbxPersonGroup";
            this.cbxPersonGroup.Size = new System.Drawing.Size(121, 32);
            this.cbxPersonGroup.TabIndex = 16;
            this.cbxPersonGroup.SelectedIndexChanged += new System.EventHandler(this.cbxPersonGroup_SelectedIndexChanged);
            // 
            // lblPersonGroup
            // 
            this.lblPersonGroup.AutoSize = true;
            this.lblPersonGroup.Location = new System.Drawing.Point(13, 22);
            this.lblPersonGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonGroup.Name = "lblPersonGroup";
            this.lblPersonGroup.Size = new System.Drawing.Size(106, 24);
            this.lblPersonGroup.TabIndex = 15;
            this.lblPersonGroup.Text = "比對群組";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(1022, 58);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 38);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(950, 58);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(65, 38);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(123, 58);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(823, 36);
            this.txtFileName.TabIndex = 12;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(13, 61);
            this.lblPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(106, 24);
            this.lblPicture.TabIndex = 10;
            this.lblPicture.Text = "選擇照片";
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.Location = new System.Drawing.Point(16, 744);
            this.picImage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(1116, 566);
            this.picImage.TabIndex = 11;
            this.picImage.TabStop = false;
            // 
            // plTag
            // 
            this.plTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plTag.Location = new System.Drawing.Point(16, 112);
            this.plTag.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(1116, 566);
            this.plTag.TabIndex = 19;
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerson.Location = new System.Drawing.Point(12, 688);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(1116, 36);
            this.txtPerson.TabIndex = 18;
            // 
            // frmCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 738);
            this.Controls.Add(this.btnCam);
            this.Controls.Add(this.cbxPersonGroup);
            this.Controls.Add(this.lblPersonGroup);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.plTag);
            this.Controls.Add(this.txtPerson);
            this.Name = "frmCapture";
            this.Text = "frmCapture";
            this.Load += new System.EventHandler(this.frmCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.ComboBox cbxPersonGroup;
        private System.Windows.Forms.Label lblPersonGroup;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel plTag;
        private System.Windows.Forms.TextBox txtPerson;
    }
}