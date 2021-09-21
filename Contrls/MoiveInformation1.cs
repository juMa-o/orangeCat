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
    public partial class MoiveInformation1 : UserControl
    {
        public MoiveInformation1()
        {
            InitializeComponent();
        }
        private void MoiveInformation_Load(object sender, EventArgs e)
        {
            filminformationData();
            this.filminformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num();
        }
        //电影表数据查询展示
        public void filminformationData()
        {
            try
            {
                string sql = "select * from MoiveInformation";
                //string sql = string.Format("select * from MoiveInformation m,OpenDate1 o1,OpenTime ot where m.OpenDate1id=o1.id and m.OpenTimeid=ot.id");
                DataTable getfilminformation = ADO.Select(sql);
                filminformation.AutoGenerateColumns = false;
                filminformation.DataSource = getfilminformation;
                if (getfilminformation.Rows.Count==0)
                {
                    contextMenuStrip1.Items[2].Visible = false;
                    contextMenuStrip1.Items[0].Visible = false;
                }
                else
                {
                    contextMenuStrip1.Items[2].Visible = true;
                    contextMenuStrip1.Items[0].Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //根据电影名称查询
        public void filminformationDatachaN()
        {
            try
            {
                 filmname.Text=filmname.Text.Trim();//清除两端空格
                if (filmname.Text!= "")
                {
                    string sql = "select * from MoiveInformation where MovieName like'"+ filmname.Text + "%'";
                    DataTable getfilminformation = ADO.Select(sql);
                    if (getfilminformation.Rows.Count>0)
                    {
                    filminformation.DataSource = getfilminformation;
                    }
                    else
                    {
                        Help.ShowPopup(chaname, "没有找到您需要查询的影片信息", new Point(chaname.Right, chaname.Bottom));
                    }
                }
            }
            catch (Exception)
            {
                Help.ShowPopup(chaname, "没有找到您需要查询的影片信息", new Point(chaname.Right, chaname.Bottom));
            }
        }
        //根据影片编号查询
        public void filminformationDatachaI()
        {
            try
            {
                filmid.Text= filmid.Text.Trim();//清除两端空格
                if (filmid.Text!="")
                {
                    string sql = "select * from MoiveInformation where id=" +filmid.Text.ToInt() + "";
                    DataTable getfilminformation = ADO.Select(sql);
                    
                    if (getfilminformation.Rows.Count>0)
                    {
                        filminformation.AutoGenerateColumns = false;
                    filminformation.DataSource = getfilminformation;
                    }
                    else
                    {
                        Help.ShowPopup(chaid, "没有找到您要搜索的影片信息", new Point(chaid.Right, chaid.Bottom));
                    }
                }
            }
            catch (Exception)
            {
                Help.ShowPopup(chaid, "请输入正确ID", new Point(chaid.Right, chaid.Bottom));
            }
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmdeletes();
        }
        //电影信息表的多行删除方法
        public void filmdeletes()
        {
            int n = filminformation.SelectedRows.Count;//获取当前选中的总行数
            DialogResult Result = MessageBox.Show("确定要删除当前" + n + "记录吗？删除后不可恢复！", "提示", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                //开始拼接字符串
                string sql = "delete from MoiveInformation where id in(";
                for (int i = 0; i < n; i++)//顺序循环当前选中的行
                {
                    sql += filminformation.SelectedRows[i].Cells["id"].Value.ToString() + ",";//顺序循环拼接
                }
                sql = sql.Remove(sql.Length - 1);//把最后一位多余的逗号删除
                sql += ")";//完成拼接
                if (ADO.InsertDeleteUpdate(sql) > 0)
                {
                    MessageBox.Show("删除成功!");
                    num();
                    filminformationData();
                }
            }
        }
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("退出账号", "提示", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                Application.Exit();//退出应用
            }
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filminformationData();
            num();
        }
        //查询电影表的总记录数
        public void num()
        {
            toolStripStatusLabel3.Text = toolStripStatusLabel3.Text.Substring(0, 5);
            string sql = string.Format("select * from MoiveInformation ,OpenDate1,OpenTime ");
            DataTable number = ADO.Select(sql);
            int num1 = number.Rows.Count;
            toolStripStatusLabel3.Text += num1 + "条记录";
        }
    private void chaname_Click(object sender, EventArgs e)
        {
            filminformationDatachaN();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        private void filminformation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void filminformation_Click(object sender, EventArgs e)
        {

        }
        private void filminformation_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动序号与数据无关
            foreach (DataGridViewRow Row in filminformation.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }
        private void chaid_Click(object sender, EventArgs e)
        {
            filminformationDatachaI();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            UIMessageTip.Show(dateTimePicker1.Text);
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            UIMessageTip.Show(dateTimePicker2.Text);
        }
        
        private void filminformation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (filminformation.SelectedRows.Count>0)
            {
                forms.DataShows de = new forms.DataShows();
                de.Tag = filminformation.SelectedRows[0].Cells["id"].Value.ToString();
                de.ShowDialog();
                filminformationData();
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.DataShows de = new forms.DataShows();
            de.Tag = filminformation.SelectedRows[0].Cells["id"].Value.ToString(); de.ShowDialog();filminformationData();
        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            filminformationDatachaN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"select * from MoiveInformation ,OpenDate1,OpenTime where ScreenTime between '{DateTime.Parse(dateTimePicker1.Text)}' and '{DateTime.Parse( dateTimePicker2.Text)}'";
            DataTable getfilminformation = ADO.Select(sql);
            if (getfilminformation.Rows.Count>0)
            {
                filminformation.AutoGenerateColumns = false;
                filminformation.DataSource = getfilminformation;
            }
            else
            {
                UIMessageTip.ShowWarning("没有满足该条件的影片信息");
            }
            
        }
    }
}

