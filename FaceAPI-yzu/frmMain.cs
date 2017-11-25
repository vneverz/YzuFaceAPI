using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAPI_yzu
{
    public partial class frmMain : Form
    {
        public frmMain() => InitializeComponent();

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void detectToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmDetect());

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmVerify());

        private void idenityToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmIdentify());

        private void personalGroupToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmUsers());

        private void captureToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmCapture());

        private void camToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmCam());
        private void emotionToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new Forms.frmEmotion());

        private void OpenForm(Form objFrm)
        {
            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }
    }
}
