namespace FaceAPI_yzu.Forms
{
    partial class frmDetect
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
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.plTag = new System.Windows.Forms.Panel();
            this.btnCallAPI = new System.Windows.Forms.Button();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPicture.Location = new System.Drawing.Point(8, 494);
            this.btnOpenPicture.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(540, 68);
            this.btnOpenPicture.TabIndex = 7;
            this.btnOpenPicture.Text = "Open Picture";
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // plTag
            // 
            this.plTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plTag.Location = new System.Drawing.Point(8, 8);
            this.plTag.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(535, 478);
            this.plTag.TabIndex = 12;
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCallAPI.Location = new System.Drawing.Point(396, 614);
            this.btnCallAPI.Margin = new System.Windows.Forms.Padding(2);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(778, 50);
            this.btnCallAPI.TabIndex = 11;
            this.btnCallAPI.Text = "Call API";
            this.btnCallAPI.UseVisualStyleBackColor = true;
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenUrl.Location = new System.Drawing.Point(8, 614);
            this.btnOpenUrl.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(384, 50);
            this.btnOpenUrl.TabIndex = 10;
            this.btnOpenUrl.Text = "Open Url";
            this.btnOpenUrl.UseVisualStyleBackColor = true;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(8, 566);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1165, 36);
            this.txtUrl.TabIndex = 9;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(552, 8);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(624, 554);
            this.txtResult.TabIndex = 8;
            // 
            // frmDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 672);
            this.Controls.Add(this.btnOpenPicture);
            this.Controls.Add(this.plTag);
            this.Controls.Add(this.btnCallAPI);
            this.Controls.Add(this.btnOpenUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtResult);
            this.Name = "frmDetect";
            this.Text = "frmDetect";
            this.Load += new System.EventHandler(this.frmDetect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel plTag;
        private System.Windows.Forms.Button btnCallAPI;
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtResult;
    }
}