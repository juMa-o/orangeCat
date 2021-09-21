using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using Sunny.UI;
    namespace XINGJI_Film
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (uid.Text==""||pwd.Text=="")
            {
                UIMessageBox.Show("账号或密码不许为空！");
            }
            else
            {
                   Admnlogin();  
            }
        }
        //管理员登录方法
        public void Admnlogin()
        {
            try
            {
                String sql = string.Format("select * from Admin where Number= '{0}' and Password= '{1}'", uid.Text, pwd.Text);
                DataTable uidtable = ADO.Select(sql);
                //判断查询到的记录
                if (uidtable.Rows.Count > 0)
                {
                    string name = uidtable.Rows[0]["AdminName"].ToString();
                    UIMessageTip.ShowOk("管理员-" + name + "-登陆成功！");
                    Main m = new Main();
                    Contrls.SaveDatas.User = "管理员";
                    m.Tag = name;
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {

                    UIMessageBox.Show("账号或密码错误，请重新输入！","提示");
                }
            }
            //处理异常，防止账号框中输入文本
            catch (Exception ex)
            {
                UIMessageBox.Show("账号或密码错误，请重新输入！" + ex.Message);
            }
        }
        private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置
        private void AdminLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }
        private void AdminLogin_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        private void AdminLogin_MouseMove(object sender, MouseEventArgs e)
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
        private void 退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 最小化_Click(object sender, EventArgs e)
        {
              this.WindowState=FormWindowState.Minimized;
        }
        private void 售票员入口_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
