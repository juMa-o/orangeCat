using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Sunny;
using System.Threading;
using System.IO;
namespace XINGJI_Film.forms
{
    public partial class DataShows : Form
    {
        public DataShows()
        {
            InitializeComponent();
        }
        public bool NUm = false;

        delegate void SetTextCallBack(string text);
        private void SetText(string text)
        {
            if (this.ShowPicture.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text });
            }
            else
            {
                this.ShowPicture.Text = text;
            }
        }
        private void LoadData()
        {
            SetText("");
        }
        private void DataShows_Load(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(LoadData);
            Thread thread = new Thread(ts);
            thread.Name = "LoadData";

            try
            {
                string sql = string.Format(" select* from MoiveInformation where id={0}", int.Parse(this.Tag.ToString()));
                DataTable GetTable = ADO.Select(sql);
                MovieName.Text =GetTable.Rows[0]["MovieName"].ToString();
                ActTheLeadingRole.Text = GetTable.Rows[0]["ActTheLeadingRole"].ToString();
                Direct.Text = GetTable.Rows[0]["Direct"].ToString();
                Duration.Text = GetTable.Rows[0]["Duration"].ToString();
                MovieType.Text = GetTable.Rows[0]["MovieType"].ToString();
                ScreenTime.Text = GetTable.Rows[0]["ScreenTime"].ToString();
                Price.Text = GetTable.Rows[0]["Price"].ToString();
                BriefIntroduction.Text = GetTable.Rows[0]["BriefIntroduction"].ToString();
                if (GetTable.Rows[0]["ImagesPos"].ToString()!="")
                {
                    ShowPicture.Image = Image.FromFile(GetTable.Rows[0]["ImagesPos"].ToString());NUm = true;
                   Contrls.SaveDatas.Pictruepos= GetTable.Rows[0]["ImagesPos"].ToString();
                }                    
                if (GetTable.Rows[0]["ScreenStatus"].ToString().Trim()=="已上映")
                {
                    uiRadioYes.Checked = true;
                }
                else
                {
                    uiRadioNo.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Result = false;
        public string FileRealPos = "";
        public string[] ImageDate;
        public string MovieImagesPos = "";
         public void OF()
        {
          OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "请选择一张图片";
            openFile.Multiselect = false;
            openFile.Filter = "(.JPG*)|*.JPG*|(.png*)|*.png*|*.bmp|*.bmp*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileRealPos = openFile.FileName;//图片名称及路径
                    ImageDate = FileRealPos.Split('.');
                    ShowPicture.Image = null;
                    ShowPicture.Image = Image.FromFile(FileRealPos);//展示
                    string ImagesName = "";
                    ImagesName = DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString();
                    ImagesName=System.Text.RegularExpressions.Regex.Replace(ImagesName,":","");
                    MovieImagesPos = Application.StartupPath.ToString() + "\\MovieImages\\" + ImagesName+ "." + ImageDate[1];
                    UIMessageTip.ShowOk("上传成功！");
                    Result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("上传失败" + (ex.Message)); this.Close();
                }
            }
        }
        private void Sead_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(OF)); t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.DisableComObjectEagerCleanup();
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            d();
            
        }
        public void d()
        {
            try
            {
                string ScreenStatus = "";
                if (uiRadioYes.Checked)
                {
                    ScreenStatus = "已上映";
                }
                else
                {
                    ScreenStatus = "未上映";
                }
                if (Result == true)
                {

                    if (Contrls.SaveDatas.Pictruepos != "")
                    {
                        //File.Delete(FileRealPos);

                    }
                    File.Copy(FileRealPos, MovieImagesPos);
                    string sql2 = string.Format("update MoiveInformation set MovieName = '{0}', ActTheLeadingRole = '{1}', Direct = '{2}', Duration = '{3}', MovieType = '{4}', ScreenTime = '{5}', Price = {6}, BriefIntroduction = '{7}', ScreenStatus = '{8}',ImagesPos='{9}' where id = {10}", MovieName.Text, ActTheLeadingRole.Text, Direct.Text, Duration.Text, MovieType.Text, DateTime.Parse(ScreenTime.Text), Double.Parse(Price.Text), BriefIntroduction.Text, ScreenStatus, MovieImagesPos, int.Parse(this.Tag.ToString()));
                    ADO.InsertDeleteUpdate(sql2);
                    if (ADO.InsertDeleteUpdate(sql2) > 0)
                    {
                        UIMessageTip.ShowOk("修改成功！"); this.Close();
                    }
                }
                else
                {
                    string sql = string.Format("update MoiveInformation set MovieName = '{0}', ActTheLeadingRole = '{1}', Direct = '{2}', Duration = '{3}', MovieType = '{4}', ScreenTime = '{5}', Price = {6}, BriefIntroduction = '{7}', ScreenStatus = '{8}' where id = {9}", MovieName.Text, ActTheLeadingRole.Text, Direct.Text, Duration.Text, MovieType.Text, DateTime.Parse(ScreenTime.Text), Double.Parse(Price.Text), BriefIntroduction.Text, ScreenStatus, int.Parse(this.Tag.ToString()));
                    if (ADO.InsertDeleteUpdate(sql) > 0)
                    {
                        UIMessageTip.ShowOk("修改成功！"); this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误" + ex.Message);
            }
        }
        private void ScreenTime_CloseUp(object sender, EventArgs e)
        {
            UIMessageTip.Show(ScreenTime.Text);
        }
    }
}
