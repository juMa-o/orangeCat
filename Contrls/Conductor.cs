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
    public partial class Conductor : UserControl
    {
        public Conductor()
        {
            InitializeComponent();
        }
        private void Conductor_Load(object sender, EventArgs e)
        {
            chaOrder();num();
        }
        //查询订单信息表
        public void chaOrder()
        {
            string sql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid");
            DataTable getTable = ADO.Select(sql);
            Orderdata1.AutoGenerateColumns = false;
            Orderdata1.DataSource = getTable;
        }
        //根据订单编号查询
        public void OrdersInformationOID()
        {
            OID.Text = OID.Text.Trim();//清除两端空格
            if (OID.Text != "")
            {
                try
                {
                    string sql = "select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid  where Orderid=" + OID.Text + "";
                    DataTable getTable = ADO.Select(sql);

                    if (getTable.Rows.Count > 0)
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
        private void chaOID_Click(object sender, EventArgs e)
        {
            OrdersInformationOID();
        }
        //刷新
        private void button7_Click(object sender, EventArgs e)
        {
            chaOrder();num();
        }
        //绘制事件
        private void Orderdata1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动序号
            foreach (DataGridViewRow Row in Orderdata1.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }
        //双击单元格事件
        private void Orderdata1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Orderdata1.Columns[e.ColumnIndex].Name == "Column1"&&Orderdata1.SelectedRows.Count>0)
            {
                DataUpdate.Operation operation = new DataUpdate.Operation();
                operation.Tag=Orderdata1.SelectedRows[0].Cells[1].Value.ToString();
                operation.ShowDialog();
            }
        }
    }
}
