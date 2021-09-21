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
namespace XINGJI_Film.DataUpdate
{
    public partial class UsersDataShow : Form
    {
        public UsersDataShow()
        {
            InitializeComponent();
        }

        private void UsersDataShow_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from Users where id={0}", int.Parse(this.Tag.ToString()));
                DataTable GetTable= ADO.Select(sql);
                UserName.Text=GetTable.Rows[0]["UserName"].ToString();
                Number.Text = GetTable.Rows[0]["Number"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uiLabel12_Click(object sender, EventArgs e)
        {

        }
        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text != "" & Number.Text != "" & Password.Text != "")
                {
                    string sql = $"update Users set Password='{Password.Text}' where id={this.Tag}";
                    if (ADO.InsertDeleteUpdate(sql) > 0)
                    {
                        UIMessageTip.ShowOk("修改成功！"); this.Close();
                    }
                }
                else
                {
                    UIMessageTip.ShowError("请输入完整！");
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
    }
}
