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
using XINGJI_Film.Contrls;

namespace XINGJI_Film
{
    public partial class Main : Form
    {
        //优化加载界面
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public Main()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;//只获取主显示，让窗体正常显示，不遮挡其他
        }
        private void MoiveInformation_Load(object sender, EventArgs e)
        {
            if (Contrls.SaveDatas.User== "管理员")
            {
                panel3.Cursor = default;
                label1.Text += this.Tag;
                label4.Text+=Contrls.SaveDatas.User;
            }
            else if (Contrls.SaveDatas.User== "售票员")
            {
                Contrls.DataShow dataShow = new DataShow();dataShow.Dispose();
                panel3.Cursor = default;
                label1.Text += this.Tag;
                label4.Text += Contrls.SaveDatas.User;
                SoldNotebtn.Visible = false;
                ubtn.Visible = false;
                moivebtn.Visible = false;
                lblSideMove(Homebtn); panel3.Controls.Clear();
                Contrls.MovieShowMain movie = new MovieShowMain();
                panel3.Controls.Add(movie); movie.Dock = DockStyle.Fill;
            }
        }
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("确定要退出本系统吗？","提示",MessageBoxButtons.OKCancel);
            if (a==DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //移动条
        private void lblSideMove(Control btn)
        {
            lblSide.Top = btn.Top;
            lblSide.Height = btn.Height;
        }
        private void moivebtn_Click(object sender, EventArgs e)
        {
            Contrls.DataShow dataShow = new DataShow(); dataShow.Dispose();
            lblSideMove(moivebtn);
            MoiveInformation1 mv = new MoiveInformation1();
            panel3.Controls.Clear();
            panel3.Controls.Add(mv);
            mv.Dock = DockStyle.Fill;
        }
        private void Orderbtn_Click(object sender, EventArgs e)
        {   //判断使用者
            if (Contrls.SaveDatas.User == "管理员")
            {
                Contrls.DataShow dataShow = new DataShow(); dataShow.Dispose();
                lblSideMove(Orderbtn);panel3.Controls.Clear();OrdersInformation1 OI = new OrdersInformation1();
                panel3.Controls.Add(OI);OI.Dock = DockStyle.Fill;
            }
            else if (Contrls.SaveDatas.User == "售票员")
            {
                lblSideMove(Orderbtn); panel3.Controls.Clear();Conductor conductor = new Conductor();
                panel3.Controls.Add(conductor);conductor.Dock = DockStyle.Fill;
            }
        }
        private void SoldNotebtn_Click(object sender, EventArgs e)
        {
            Contrls.DataShow dataShow = new DataShow(); dataShow.Dispose();
            lblSideMove(SoldNotebtn); panel3.Controls.Clear();SoldNoteInformation s = new SoldNoteInformation();         
            panel3.Controls.Add(s);s.Dock = DockStyle.Fill;
        }      
        private void ubtn_Click(object sender, EventArgs e)
        {
            Contrls.DataShow dataShow = new DataShow(); dataShow.Dispose();
            lblSideMove(ubtn);
            panel3.Controls.Clear();
            UserInformation u = new UserInformation();
            panel3.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }
        private void Homebtn_Click(object sender, EventArgs e)
        {
            //判断使用者
            if (Contrls.SaveDatas.User == "管理员")
            {
                lblSideMove(Homebtn);panel3.Controls.Clear();DataShow ds = new DataShow();
                panel3.Controls.Add(ds);ds.Dock = DockStyle.Fill;
            }
            else if (Contrls.SaveDatas.User == "售票员")
            {
                lblSideMove(Homebtn); panel3.Controls.Clear();
                Contrls.MovieShowMain movie = new MovieShowMain();
                panel3.Controls.Add(movie); movie.Dock = DockStyle.Fill;
            }
        }
        private void CloseApp_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("确定要退出本系统吗？", "提示", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("是否退出","",MessageBoxButtons.YesNo);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}