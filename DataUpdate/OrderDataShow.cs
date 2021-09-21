using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XINGJI_Film.DataUpdate
{
    public partial class OrderDataShow : Form
    {
        public OrderDataShow()
        {
            InitializeComponent();
        }

        private void OrderDataShow_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where Orderid={0}",int.Parse(this.Tag.ToString()));
                DataTable GetTable = ADO.Select(sql);
                MovieName.Text=GetTable.Rows[0]["MovieName"].ToString();
                Orderid.Text = GetTable.Rows[0]["Orderid"].ToString();
                OpenDate.Text= GetTable.Rows[0]["OpenDate"].ToString();
                OpenTime.Text = GetTable.Rows[0]["OpenTime"].ToString();
                seatID.Text = GetTable.Rows[0]["seatID"].ToString();
                AuditoriumName.Text = GetTable.Rows[0]["AuditoriumName"].ToString();
                OrderStartTime.Text = GetTable.Rows[0]["OrderStartTime"].ToString();
                OrderOverTime.Text = GetTable.Rows[0]["OrderOverTime"].ToString();
                OrderStatus.Text = GetTable.Rows[0]["OrderStatus"].ToString();
                UserName.Text = GetTable.Rows[0]["UserName"].ToString();
                Price.Text = GetTable.Rows[0]["Price"].ToString();
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
