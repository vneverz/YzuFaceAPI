﻿namespace FaceAPI_yzu.Forms
{
    partial class frmCam
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
            this.tiCapture = new System.Windows.Forms.Timer(this.components);
            this.plPersonName = new System.Windows.Forms.Panel();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lbxPerson = new System.Windows.Forms.ListBox();
            this.cbxPersonGroup = new System.Windows.Forms.ComboBox();
            this.picRender = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tiPersonLabel = new System.Windows.Forms.Timer(this.components);
            this.plCam = new System.Windows.Forms.Panel();
            this.plPersonName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRender)).BeginInit();
            this.SuspendLayout();
            // 
            // tiCapture
            // 
            this.tiCapture.Interval = 5000;
            this.tiCapture.Tick += new System.EventHandler(this.tiCapture_Tick);
            // 
            // plPersonName
            // 
            this.plPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plPersonName.Controls.Add(this.lblPersonName);
            this.plPersonName.Location = new System.Drawing.Point(9, 370);
            this.plPersonName.Name = "plPersonName";
            this.plPersonName.Size = new System.Drawing.Size(495, 54);
            this.plPersonName.TabIndex = 15;
            this.plPersonName.Visible = false;
            // 
            // lblPersonName
            // 
            this.lblPersonName.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPersonName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPersonName.Location = new System.Drawing.Point(3, 6);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(489, 45);
            this.lblPersonName.TabIndex = 0;
            this.lblPersonName.Text = "[lblPersonName]";
            this.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxPerson
            // 
            this.lbxPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPerson.FormattingEnabled = true;
            this.lbxPerson.ItemHeight = 12;
            this.lbxPerson.Location = new System.Drawing.Point(529, 168);
            this.lbxPerson.Name = "lbxPerson";
            this.lbxPerson.Size = new System.Drawing.Size(88, 256);
            this.lbxPerson.TabIndex = 14;
            // 
            // cbxPersonGroup
            // 
            this.cbxPersonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPersonGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonGroup.FormattingEnabled = true;
            this.cbxPersonGroup.Location = new System.Drawing.Point(527, 142);
            this.cbxPersonGroup.Name = "cbxPersonGroup";
            this.cbxPersonGroup.Size = new System.Drawing.Size(88, 20);
            this.cbxPersonGroup.TabIndex = 13;
            this.cbxPersonGroup.SelectedIndexChanged += new System.EventHandler(this.cbxPersonGroup_SelectedIndexChanged);
            // 
            // picRender
            // 
            this.picRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRender.Location = new System.Drawing.Point(527, 66);
            this.picRender.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.picRender.Name = "picRender";
            this.picRender.Size = new System.Drawing.Size(90, 66);
            this.picRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRender.TabIndex = 12;
            this.picRender.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Location = new System.Drawing.Point(527, 10);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(90, 31);
            this.btnCapture.TabIndex = 11;
            this.btnCapture.Text = "capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(685, 44);
            this.btnStop.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 19);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(527, 44);
            this.btnStart.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 19);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tiPersonLabel
            // 
            this.tiPersonLabel.Interval = 3000;
            this.tiPersonLabel.Tick += new System.EventHandler(this.tiPersonLabel_Tick);
            // 
            // plCam
            // 
            this.plCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plCam.Location = new System.Drawing.Point(8, 10);
            this.plCam.Name = "plCam";
            this.plCam.Size = new System.Drawing.Size(496, 352);
            this.plCam.TabIndex = 16;
            // 
            // frmCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 434);
            this.Controls.Add(this.plPersonName);
            this.Controls.Add(this.lbxPerson);
            this.Controls.Add(this.cbxPersonGroup);
            this.Controls.Add(this.picRender);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.plCam);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmCam";
            this.Text = "frmCam";
            this.Load += new System.EventHandler(this.frmCam_Load);
            this.plPersonName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tiCapture;
        private System.Windows.Forms.Panel plPersonName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.ListBox lbxPerson;
        private System.Windows.Forms.ComboBox cbxPersonGroup;
        private System.Windows.Forms.PictureBox picRender;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tiPersonLabel;
        private System.Windows.Forms.Panel plCam;
    }
}