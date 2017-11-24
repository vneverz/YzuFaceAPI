using FaceAPI_yzu.ClassLibrary;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAPI_yzu.Forms
{
    public partial class frmCam : Form
    {
        WebCam oWebCam;
        FaceServiceClient face = new FaceServiceClient(ConfigurationManager.AppSettings["FaceAPIKey"].ToString(), ConfigurationManager.AppSettings["FaceAPIRootUrl"].ToString());
        IDictionary DicPerson;
        FacePanelUtility objPlUtil = new FacePanelUtility();

        public frmCam()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 攝影機畫面讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCam_Load(object sender, EventArgs e)
        {
            new CognitiveUtility().BindPersonGroup(cbxPersonGroup, face, "");
            oWebCam = new WebCam();
            oWebCam.Container = picRender;
            tiCapture.Interval = 5000;
            objPlUtil.TargetPanel = plCam;
            plCam.Paint += objPlUtil.OnPaint;

            oWebCam.OpenConnection();
        }

        /// <summary>
        /// 點選開始的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            tiCapture.Enabled = true;
        }

        /// <summary>
        /// 點選停止的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            tiCapture.Enabled = false;
            oWebCam.Dispose();
        }

        /// <summary>
        /// 截取當下的圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapture_Click(object sender, EventArgs e)
        {
            this.GetFaceFromCamAsync();
        }

        /// <summary>
        /// 每固定時間進行畫面取的並進行人臉辨識的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void tiCapture_Tick(object sender, EventArgs e)
        {
            await this.GetFaceFromCamAsync();
        }

        private async Task GetFaceFromCamAsync()
        {
            oWebCam.Container.Height = picRender.Height;
            oWebCam.Container.Width = picRender.Width;

            string strTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string strFileFolder = ConfigurationManager.AppSettings["FileFolder"].ToString();
            string strFileName = strFileFolder + strTime + ".jpg";
            Image objImg = oWebCam.CaptureImage();
            objImg.Save(strFileName);
            plCam.BackgroundImage = Bitmap.FromFile(strFileName);

            // 先取出照片中的人臉與其FaceId
            Face[] faces = null;
            try
            {
                Stream st = File.OpenRead(strFileName);
                faces = await face.DetectAsync(st, true, true);
                objPlUtil.RenderFaceRectangle(faces);
            }
            catch (Exception ex)
            {
                string strErr = ex.Message;
            }

            // 將照片中的臉，與指定的PersonGroup進行比對
            if (faces != null)
            {
                Guid[] faceGuids = faces.Select(x => x.FaceId).ToArray();
                if (faceGuids.Length > 0)
                {
                    string strPersonGroup = ((Models.CognitiveModels.ListItem)cbxPersonGroup.SelectedItem).Value;
                    IdentifyResult[] result = await face.IdentifyAsync(strPersonGroup, faceGuids);

                    // 取得照片中的人臉
                    lbxPerson.Items.Clear();
                    string strPersonNameLabel = "";
                    for (int i = 0; i < result.Length; i++)
                    {
                        for (int p = 0; p < result[i].Candidates.Length; p++)
                        {
                            string strPersonId = result[i].Candidates[p].PersonId.ToString();
                            string strPersonName = (DicPerson.Contains(strPersonId)) ? DicPerson[strPersonId].ToString() : "";
                            lbxPerson.Items.Add(strPersonName);
                            strPersonNameLabel += strPersonName + ",";
                        }
                    }

                    // 顯示文字
                    if (strPersonNameLabel != "")
                    {
                        strPersonNameLabel = strPersonNameLabel.Substring(0, strPersonNameLabel.Length - 1);
                        lblPersonName.Text = strPersonNameLabel;
                        tiPersonLabel.Enabled = true;
                        plPersonName.Visible = true;
                    }
                }
            }
        }

        /// <summary>
        /// 報到文字一段時間消失的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiPersonLabel_Tick(object sender, EventArgs e)
        {
            plPersonName.Visible = false;
            tiPersonLabel.Enabled = false;
        }

        /// <summary>
        /// 將人員群組的人員資料放入到字典檔中的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void cbxPersonGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPersonGroupId = ((Models.CognitiveModels.ListItem)cbxPersonGroup.SelectedItem).Value;
            DicPerson = new Hashtable();
            Person[] objPersons = await face.GetPersonsAsync(strPersonGroupId);

            for (int i = 0; i < objPersons.Length; i++)
                DicPerson.Add(objPersons[i].PersonId.ToString().Replace("{", "").Replace("}", ""), objPersons[i].Name);
        }
    }
}
