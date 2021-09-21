using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sunny;
using Sunny.UI;
namespace XINGJI_Film
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (uid.Text == "" || pwd.Text == "")
            {
                UIMessageBox.Show("账号或密码不能为空！");
            }
            else
            {
                uidlogin();
            }
        }
        //售票员员登录方法
        public void uidlogin()
        {
            try
            {
                String sql = string.Format("select * from Users where Number= '{0}' and Password= '{1}'", uid.Text, pwd.Text);
                DataTable uidtable = ADO.Select(sql);
                if (uidtable.Rows.Count > 0)
                {
                    string name = uidtable.Rows[0]["UserName"].ToString();
                    UIMessageTip.ShowOk("售票员-" + name + "-登陆成功！");
                    Contrls.SaveDatas.User = "售票员";
                    Main m = new Main();
                    m.Tag=name;
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    UIMessageBox.Show("账号或密码错误，请重新输入！");
                }
            }
            catch (Exception ex)
            {

                UIMessageBox.Show("请输入正确的账号！" + ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wpa.qq.com/msgrd?v=3&uin=1146176128&site=qq&menu=yes");
        }
        private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }
        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;
                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }
        private void 售票员入口_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void 最小化_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void 退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
