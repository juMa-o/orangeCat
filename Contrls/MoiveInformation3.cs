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
            num();
        }
        //电影表加载到窗体的方法
        public void filminformationData()
        {
            try
            {

                string sql = "select * from MoiveInformation";
                //string sql = string.Format("select * from MoiveInformation m,OpenDate1 o1,OpenTime ot where m.OpenDate1id=o1.id and m.OpenTimeid=ot.id");
                DataTable getfilminformation = ADO.Select(sql);
                filminformation.AutoGenerateColumns = false;
                filminformation.DataSource = getfilminformation;
                if (getfilminformation.Rows.Count == 0)
                {
                    contextMenuStrip1.Items[2].Visible = false;
                }
                else
                {
                    contextMenuStrip1.Items[2].Visible = true;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void filminformationDatachaN()
        {
            try
            {
                if (chaname.Text!="")
                {
                    string sql = "select * from MoiveInformation where MovieName like'%" + filmname.Text + "%'";
                    DataTable getfilminformation = ADO.Select(sql);
                    filminformation.AutoGenerateColumns = false;
                    filminformation.DataSource = getfilminformation;
                    if (getfilminformation.Rows.Count == 0)
                    {
                        contextMenuStrip1.Items[2].Visible = false;
                    }
                    else
                    {
                        contextMenuStrip1.Items[2].Visible = true;

                    }
                }
                
            }
            catch (Exception)
            {
                
            }
        }
        public void filminformationDatachaI()
        {
            try
            {
                if (filmid.Text!="")
                {
                    string sql = "select * from MoiveInformation where id=" +filmid.Text.ToInt() + "";
                    DataTable getfilminformation = ADO.Select(sql);
                    filminformation.AutoGenerateColumns = false;
                    filminformation.DataSource = getfilminformation;
                    if (getfilminformation.Rows.Count == 0)
                    {
                        contextMenuStrip1.Items[2].Visible = false;
                    }
                    else
                    {
                        contextMenuStrip1.Items[2].Visible = true;

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void filminformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmdeletes();
        }
        //电影信息表的多行删除方法
        public void filmdeletes()
        {
            int n = filminformation.SelectedRows.Count;
            DialogResult Result = MessageBox.Show("确定要删除当前" + n + "记录吗？删除后不可恢复！", "提示", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                string sql = "delete from MoiveInformation where id in(";
                for (int i = 0; i < n; i++)
                {
                    sql += filminformation.SelectedRows[i].Cells["id"].Value.ToString() + ",";
                }
                sql = sql.Remove(sql.Length - 1);
                sql += ")";
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
            DialogResult a = MessageBox.Show("确定要退出本系统吗？", "提示", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filminformationData();
            num();
        }
        public void num()
        {
            toolStripStatusLabel3.Text = toolStripStatusLabel3.Text.Substring(0, 5);
            string sql = string.Format("select * from MoiveInformation ,OpenDate1,OpenTime ");
            DataTable number = ADO.Select(sql);
            int num1 = number.Rows.Count;
            toolStripStatusLabel3.Text += num1 + "条记录";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void filminformation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in filminformation.Rows)
            {
                filminformation.Rows[0].Cells[0].Value = row.Index;
            }    //自动编号，与数据无关
            
        }


    private void chaname_Click(object sender, EventArgs e)
        {
            filminformationDatachaN();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            filminformationData();
        }

        private void filminformation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   // 获取数据表格中的删除按钮
                if (this.filminformation.Columns[e.ColumnIndex].Name == "De" && filminformation.CurrentCell.Value.ToString() == "删除")
                {
                    int filmnamee = int.Parse(this.filminformation.SelectedRows[0].Cells["id"].Value.ToString());
                    if (DialogResult.Yes == MessageBox.Show("删除后不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        string sql = string.Format("delete from MoiveInformation where id={0}", filmnamee);
                        if (ADO.InsertDeleteUpdate(sql) > 0)
                        {
                            MessageBox.Show("删除成功");
                            this.filminformationData();
                            num();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误操作！" + ex.Message);
            }
            //修改
            try
            {
                if (filminformation.Columns[e.ColumnIndex].Name == "Updata" && filminformation.CurrentCell.Value.ToString() == "详情")
                {
                    //获取到ID，之后根据这个ID进行修改
                    string id = filminformation.CurrentRow.Cells["id"].Value.ToString();
                    MoiveUpdate xiugai = new MoiveUpdate();
                    xiugai.Tag = id;//把获取到的ID存放到窗体的Tag属性当中
                    xiugai.ShowDialog();
                    filminformationData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误操作！" + ex.Message);
            }
        }

        private void filminformation_Click(object sender, EventArgs e)
        {

        }

        private void filminformation_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动序号
            foreach (DataGridViewRow Row in filminformation.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }

        private void chaid_Click(object sender, EventArgs e)
        {
            filminformationDatachaI();
        }
    }
}

