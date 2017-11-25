namespace FaceAPI_yzu
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.detectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idenityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectToolStripMenuItem,
            this.verifyToolStripMenuItem,
            this.idenityToolStripMenuItem,
            this.personalGroupToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.camToolStripMenuItem,
            this.emotionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(593, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // detectToolStripMenuItem
            // 
            this.detectToolStripMenuItem.Name = "detectToolStripMenuItem";
            this.detectToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.detectToolStripMenuItem.Text = "Detect";
            this.detectToolStripMenuItem.Click += new System.EventHandler(this.detectToolStripMenuItem_Click);
            // 
            // verifyToolStripMenuItem
            // 
            this.verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            this.verifyToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.verifyToolStripMenuItem.Text = "Verify";
            this.verifyToolStripMenuItem.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            // idenityToolStripMenuItem
            // 
            this.idenityToolStripMenuItem.Name = "idenityToolStripMenuItem";
            this.idenityToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.idenityToolStripMenuItem.Text = "Identify";
            this.idenityToolStripMenuItem.Click += new System.EventHandler(this.idenityToolStripMenuItem_Click);
            // 
            // personalGroupToolStripMenuItem
            // 
            this.personalGroupToolStripMenuItem.Name = "personalGroupToolStripMenuItem";
            this.personalGroupToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.personalGroupToolStripMenuItem.Text = "Personal Group";
            this.personalGroupToolStripMenuItem.Click += new System.EventHandler(this.personalGroupToolStripMenuItem_Click);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
            // 
            // camToolStripMenuItem
            // 
            this.camToolStripMenuItem.Name = "camToolStripMenuItem";
            this.camToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.camToolStripMenuItem.Text = "Cam";
            this.camToolStripMenuItem.Click += new System.EventHandler(this.camToolStripMenuItem_Click);
            // 
            // emotionToolStripMenuItem
            // 
            this.emotionToolStripMenuItem.Name = "emotionToolStripMenuItem";
            this.emotionToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.emotionToolStripMenuItem.Text = "Emotion";
            this.emotionToolStripMenuItem.Click += new System.EventHandler(this.emotionToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 503);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem detectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idenityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emotionToolStripMenuItem;
    }
}



