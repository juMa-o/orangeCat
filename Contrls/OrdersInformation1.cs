using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace XINGJI_Film
{
    public partial class OrdersInformation1 : UserControl
    {
        public OrdersInformation1()
        {
            InitializeComponent();
        }
        //查询订单信息表
        public void chaOrder()
        {
            string sql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid");
            DataTable getTable = ADO.Select(sql);
            Orderdata1.AutoGenerateColumns = false;
            Orderdata1.DataSource = getTable;
            if (getTable.Rows.Count== 0)
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
        //数据记录
        public void num()
        {
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text.Substring(0, 5);
            string sql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid");
            DataTable number = ADO.Select(sql);
            int num1 = number.Rows.Count;
            Contrls.SaveDatas.OrdersNum = num1;
            toolStripStatusLabel2.Text += num1 + "条记录";
        }
        private void Orderdata1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in Orderdata1.Rows)
            {
                Orderdata1.Rows[0].Cells[0].Value = row.Index;
            }    //自动编号，与数据无关
        }
        private void OrdersInformation1_Load(object sender, EventArgs e)
        {
            chaOrder(); num();
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersDeletes();
        }
        //订单表的多行删除方法
        void OrdersDeletes()
        {
            try
            {
                int n = Orderdata1.SelectedRows.Count;
                DialogResult Result = MessageBox.Show("确定要删除当前选中的" + n + "条数据吗？删除后不可恢复！", "提示", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.OK)
                {
                    string sql = "delete from Orders where Orderid in(";
                    for (int i = 0; i < n; i++)
                    {
                        sql += Orderdata1.SelectedRows[i].Cells["Orderid"].Value.ToString() + ",";
                    }
                    sql = sql.Remove(sql.Length - 1); sql += ")";
                    if (ADO.InsertDeleteUpdate(sql) > 0)
                    {
                        MessageBox.Show("删除成功!"); chaOrder(); num();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chaOrder();
        }
        //退出系统
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("确定要退出本系统吗？", "提示", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            chaOrder();//刷新数据
        }
        private void chaid_Click(object sender, EventArgs e)
        {
            OrdersInformationUID();
        }
        //根据订单编号查询
        public void OrdersInformationOID()
        {
            OID.Text= OID.Text.Trim();//清除两端空格
            if (OID.Text != "")
            {
                try
                {
                    string sql = "select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid  where Orderid=" + OID.Text + "";
                    DataTable getTable = ADO.Select(sql);
                    
                    if (getTable.Rows.Count>0)
                    {
                    Orderdata1.AutoGenerateColumns = false;
                    Orderdata1.DataSource = getTable;
                    }
                    else
                    {
                        Help.ShowPopup(chaOID, "没有找到该订单信息", new Point(chaOID.Right, chaOID.Bottom));
                    }
                }
                catch (Exception)
                {
                    Help.ShowPopup(chaOID, "请输入正确数据(格式不正确)", new Point(chaOID.Right, chaOID.Bottom));
                }
            }           
        }
        //根据售票员ID查询
        public void OrdersInformationUID()
        {
             UID.Text= UID.Text.Trim();
            if (UID.Text!="")
            {
                try
                {
                    string sql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid  where Users.id={0}",UID.Text);
                    DataTable getTable = ADO.Select(sql);
                    if (getTable.Rows.Count>0)
                    {
                    Orderdata1.AutoGenerateColumns = false;
                    Orderdata1.DataSource = getTable;
                    }
                    else
                    {
                        Help.ShowPopup(chaUID, "没有找到该订单信息", new Point(chaUID.Right, chaUID.Bottom));
                    }
                }
                catch (Exception)
                {
                    Help.ShowPopup(chaUID, "请输入正确数据(格式不正确)", new Point(chaUID.Right, chaUID.Bottom));
                }
            }            
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            chaOrder();//刷新数据
        }
        private void chaOID_Click(object sender, EventArgs e)
        {
            OrdersInformationOID();
        }

        private void chaUID_Click(object sender, EventArgs e)
        {
            OrdersInformationUID();
        }

        private void Orderdata1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataUpdate.OrderDataShow Od = new DataUpdate.OrderDataShow();Od.Tag = Orderdata1.SelectedRows[0].Cells["Orderid"].Value.ToString();
            Od.ShowDialog();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataUpdate.OrderDataShow Od = new DataUpdate.OrderDataShow(); Od.Tag = Orderdata1.SelectedRows[0].Cells["Orderid"].Value.ToString();
            Od.ShowDialog();
        }

        private void Orderdata1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动序号
            foreach (DataGridViewRow Row in Orderdata1.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }

        private void Orderdata1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Orderdata1.SelectedRows.Count>0)
            {
                DataUpdate.OrderDataShow Od = new DataUpdate.OrderDataShow(); Od.Tag = Orderdata1.SelectedRows[0].Cells["Orderid"].Value.ToString();
                Od.ShowDialog();
            }
        }
    }
}
