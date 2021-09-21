using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace XINGJI_Film.Contrls
{
    public partial class SoldNoteInformation : UserControl
    {
        public SoldNoteInformation()
        {
            InitializeComponent();
        }
        private void SoldNoteInformation_Load(object sender, EventArgs e)
        {
            ChaSoldNote(); num();
        }
        //销售记录表多行删除方法
        public void SoldNoteDeletes()
        {
            int n=SoldNotedata.SelectedRows.Count;//获取用户当前选中的行数
            if (n!=0)
            {
                DialogResult Result = MessageBox.Show("确定要删除当前" + n + "记录吗？删除后不可恢复！", "提示", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.OK)
                {
                    //开始字符串拼接
                    string sql = "Delete from SoldNote where SoldNoteid in (";
                    for (int i = 0; i < n; i++)//循环顺序选中的行
                    {
                        sql += SoldNotedata.SelectedRows[i].Cells["SoldNoteid"].Value.ToString() + ",";//循环拼接
                    }
                    sql = sql.Remove(sql.Length - 1); sql += ")";//删除最后多余的一位并完成拼接
                    if (ADO.InsertDeleteUpdate(sql) > 0)
                    {
                        MessageBox.Show("删除成功！"); ChaSoldNote(); num();
                    }
                }
            }
        }
        public int n = 0;//存放数据数量
        //加载销售表数据
        public void ChaSoldNote()
        {
            string sql = "select * from SoldNote left join MoiveInformation  on SoldNote.MovieInformationid=MoiveInformation.id left join Auditorium on Auditorium.id=SoldNote.Auditoriumid left join Orders on Orders.Orderid=SoldNote.Orderid left join Users on Users.id=SoldNote.Userid where OrderStatus='已完成'";
            DataTable getTable = ADO.Select(sql);
            SoldNotedata.AutoGenerateColumns = false;//取消表格自增列
            SoldNotedata.DataSource = getTable;//绑定数据源
            n = getTable.Rows.Count;
            if (n== 0)
            {
                contextMenuStrip1.Items[2].Visible = false;
                contextMenuStrip1.Items[0].Visible = false;
            }
            else
            {
                contextMenuStrip1.Items[2].Visible = true;
            }
        }
        //数据记录
        public void num()
        {
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text.Substring(0, 5);//截取字符串(从一位开始截取，截取五位)
            toolStripStatusLabel2.Text +=n+ "条记录";
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoldNoteDeletes();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChaSoldNote(); num();
        }
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("确定要退出本系统吗？", "提示", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ChaSoldNote(); num();
        }
        //根据订单ID查询
        public void ChaOrderId()
        {
            uiTextBox2.Text= uiTextBox2.Text.Trim();
            if (uiTextBox2.Text!="")
            {
                try
                {
                    string sql = String.Format("select * from SoldNote left join MoiveInformation on SoldNote.MovieInformationid=MoiveInformation.id left join Auditorium on Auditorium.id=SoldNote.Auditoriumid left join Orders on Orders.Orderid=SoldNote.Orderid left join Users on Users.id=SoldNote.Userid where Orders.Orderid={0} and Orders.OrderStatus='已完成'", uiTextBox2.Text);
                    DataTable GetTable = ADO.Select(sql);
                    if (GetTable.Rows.Count>0)
                    {
                        SoldNotedata.AutoGenerateColumns = false;//取消表格自增列
                        SoldNotedata.DataSource = GetTable;//绑定数据源
                    }
                    else
                    {
                        Help.ShowPopup(chaOID, "没有找到您需要查询的销售信息", new Point(chaOID.Right, chaOID.Bottom));
                    }
                }
                catch (Exception)
                {
                    Help.ShowPopup(chaOID, "请输入正确数据", new Point(chaOID.Right, chaOID.Bottom));//提示窗口
                }
            }
        }
        //根据销售ID查询
        public void ChaSoldNoteID()
        {
            uiTextBox1.Text = uiTextBox1.Text.Trim();
            if (uiTextBox1.Text != "")
            {
                try
                {
                    string sql = String.Format("select * from SoldNote left join MoiveInformation on SoldNote.MovieInformationid=MoiveInformation.id left join Auditorium on Auditorium.id=SoldNote.Auditoriumid left join Orders on Orders.Orderid=SoldNote.Orderid left join Users on Users.id=SoldNote.Userid where SoldNote.SoldNoteid={0} and  Orders.OrderStatus='已完成'", uiTextBox1.Text);
                    DataTable GetTable = ADO.Select(sql);
                    if (GetTable.Rows.Count>0)
                    {
                        SoldNotedata.AutoGenerateColumns = false;//取消自增列
                        SoldNotedata.DataSource = GetTable;//绑定数据源
                    }
                    else
                    {
                        Help.ShowPopup(ChaSNID, "没有找到您需要查询的销售信息", new Point(ChaSNID.Right, ChaSNID.Bottom));//提示窗口
                    }
                }
                catch (Exception)
                {
                    Help.ShowPopup(ChaSNID, "请输入正确数据", new Point(ChaSNID.Right, ChaSNID.Bottom));
                }
            }
        }
        private void SoldNotedata_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动序号与数据无关
            foreach (DataGridViewRow Row in SoldNotedata.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }

        private void chaOID_Click(object sender, EventArgs e)
        {
            ChaOrderId();
        }

        private void ChaSNID_Click(object sender, EventArgs e)
        {
            ChaSoldNoteID();
        }

        private void SoldNotedata_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataUpdate.SoldNoteDataShow SD = new DataUpdate.SoldNoteDataShow(); SD.Tag = SoldNotedata.SelectedRows[0].Cells["SoldNoteid"].Value.ToString(); SD.ShowDialog();

            }
            catch(Exception)
            {
            }
        }
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataUpdate.SoldNoteDataShow SD = new DataUpdate.SoldNoteDataShow(); SD.Tag = SoldNotedata.SelectedRows[0].Cells["SoldNoteid"].Value.ToString(); SD.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
    }
}
