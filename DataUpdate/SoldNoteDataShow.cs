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
    public partial class SoldNoteDataShow : Form
    {
        public SoldNoteDataShow()
        {
            InitializeComponent();
        }

        private void SoldNoteDataShow_Load(object sender, EventArgs e)
        {
            string sql = String.Format("select * from SoldNote left join MoiveInformation on SoldNote.MovieInformationid=MoiveInformation.id left join Auditorium on Auditorium.id=SoldNote.Auditoriumid left join Orders on Orders.Orderid=SoldNote.Orderid left join Users on Users.id=SoldNote.Userid where SoldNote.SoldNoteid={0} and OrderStatus='已完成'", int.Parse(this.Tag.ToString()));
            DataTable GetTable = ADO.Select(sql);
            SoldNoteid.Text = GetTable.Rows[0]["SoldNoteid"].ToString();
            AuditoriumName.Text = GetTable.Rows[0]["AuditoriumName"].ToString();
            MovieName.Text = GetTable.Rows[0]["MovieName"].ToString();
            MovieType.Text = GetTable.Rows[0]["MovieType"].ToString();
            OrderStartTime.Text = GetTable.Rows[0]["OrderStartTime"].ToString();
            OrderOverTime.Text = GetTable.Rows[0]["OrderOverTime"].ToString();
            OrderStatus.Text = GetTable.Rows[0]["OrderStatus"].ToString();
            UserName.Text = GetTable.Rows[0]["UserName"].ToString();
            Price.Text = GetTable.Rows[0]["Price"].ToString();
        }
        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
