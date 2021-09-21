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
    public partial class Operation : Form
    {
        public Operation()
        {
            InitializeComponent();
        }

        private void Operation_Load(object sender, EventArgs e)
        {
            string sql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where Orders.Orderid={0}",int.Parse(this.Tag.ToString()));
            DataTable getTable = ADO.Select(sql);
            Orderdata1.AutoGenerateColumns = false;
            Orderdata1.DataSource = getTable;
        }
    }
}
