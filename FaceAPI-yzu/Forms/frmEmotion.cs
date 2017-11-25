using Microsoft.ProjectOxford.Face;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAPI_yzu.Forms
{
    FaceServiceClient face = new FaceServiceClient(ConfigurationManager.AppSettings["FaceAPIKey"].ToString(), ConfigurationManager.AppSettings["FaceAPIRootUrl"].ToString());
    ClassLibrary.FacePanelUtility objPlUtil = new ClassLibrary.FacePanelUtility();

    public partial class frmEmotion : Form
    {
        public frmEmotion()
        {
            InitializeComponent();
        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
