namespace FaceAPI_yzu.Forms
{
    partial class frmVerify
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnOpenPic2 = new System.Windows.Forms.Button();
            this.btnOpenPic1 = new System.Windows.Forms.Button();
            this.txtPic2 = new System.Windows.Forms.TextBox();
            this.txtPic1 = new System.Windows.Forms.TextBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtFace2Guid = new System.Windows.Forms.TextBox();
            this.txtFace1Guid = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(26, 667);
            this.btnSend.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(1304, 46);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send Verify";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnOpenPic2
            // 
            this.btnOpenPic2.Location = new System.Drawing.Point(1168, 559);
            this.btnOpenPic2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOpenPic2.Name = "btnOpenPic2";
            this.btnOpenPic2.Size = new System.Drawing.Size(163, 46);
            this.btnOpenPic2.TabIndex = 22;
            this.btnOpenPic2.Text = "Open";
            this.btnOpenPic2.UseVisualStyleBackColor = true;
            this.btnOpenPic2.Click += new System.EventHandler(this.btnOpenPic2_Click);
            // 
            // btnOpenPic1
            // 
            this.btnOpenPic1.Location = new System.Drawing.Point(509, 559);
            this.btnOpenPic1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOpenPic1.Name = "btnOpenPic1";
            this.btnOpenPic1.Size = new System.Drawing.Size(163, 46);
            this.btnOpenPic1.TabIndex = 23;
            this.btnOpenPic1.Text = "Open";
            this.btnOpenPic1.UseVisualStyleBackColor = true;
            this.btnOpenPic1.Click += new System.EventHandler(this.btnOpenPic1_Click);
            // 
            // txtPic2
            // 
            this.txtPic2.Location = new System.Drawing.Point(685, 559);
            this.txtPic2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPic2.Name = "txtPic2";
            this.txtPic2.Size = new System.Drawing.Size(466, 36);
            this.txtPic2.TabIndex = 20;
            // 
            // txtPic1
            // 
            this.txtPic1.Location = new System.Drawing.Point(26, 559);
            this.txtPic1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPic1.Name = "txtPic1";
            this.txtPic1.Size = new System.Drawing.Size(466, 36);
            this.txtPic1.TabIndex = 18;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(685, 29);
            this.pic2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(646, 518);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 17;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(26, 29);
            this.pic1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(646, 518);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 16;
            this.pic1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(26, 725);
            this.txtResult.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(1300, 520);
            this.txtResult.TabIndex = 25;
            // 
            // txtFace2Guid
            // 
            this.txtFace2Guid.Enabled = false;
            this.txtFace2Guid.Location = new System.Drawing.Point(685, 611);
            this.txtFace2Guid.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtFace2Guid.Name = "txtFace2Guid";
            this.txtFace2Guid.Size = new System.Drawing.Size(641, 36);
            this.txtFace2Guid.TabIndex = 21;
            // 
            // txtFace1Guid
            // 
            this.txtFace1Guid.Enabled = false;
            this.txtFace1Guid.Location = new System.Drawing.Point(26, 611);
            this.txtFace1Guid.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtFace1Guid.Name = "txtFace1Guid";
            this.txtFace1Guid.Size = new System.Drawing.Size(641, 36);
            this.txtFace1Guid.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 1274);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnOpenPic2);
            this.Controls.Add(this.btnOpenPic1);
            this.Controls.Add(this.txtPic2);
            this.Controls.Add(this.txtPic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFace2Guid);
            this.Controls.Add(this.txtFace1Guid);
            this.Name = "frmVerify";
            this.Text = "frmVerify";
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnOpenPic2;
        private System.Windows.Forms.Button btnOpenPic1;
        private System.Windows.Forms.TextBox txtPic2;
        private System.Windows.Forms.TextBox txtPic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtFace2Guid;
        private System.Windows.Forms.TextBox txtFace1Guid;
        private System.Windows.Forms.Timer timer1;
    }
}