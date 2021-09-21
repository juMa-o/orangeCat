using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.Threading;
using System.IO;
namespace XINGJI_Film.Contrls
{
    public partial class MovieShowMain : UserControl
    {
        public MovieShowMain()
        {
            InitializeComponent();
        }
        private void MovieShowMain_Load(object sender, EventArgs e)
        {
            Ranking();
        }
        public void Ranking()
        {
            try
            {
                string sql = " select top 6 count(MoiveInformation.id) as Rankings ,MovieName,ImagesPos,MovieType,ScreenTime,MoiveInformation.ActTheLeadingRole from Orders left join MoiveInformation on Orders.MovieInformationid = MoiveInformation.id left join Auditorium on Orders.Auditoriumid = Auditorium.id left join users on Orders.Userid = Users.id left join Seat on Seat.seatID = Orders.Seatid left join OpenDate1 on OpenDate1.id = Orders.OpenDateid left join OpenTime on OpenTime.id = Orders.OpenTimeid where MoiveInformation.ScreenStatus = '已上映' group by MovieName,MovieType,MoiveInformation.Price,ScreenTime,ImagesPos,MoiveInformation.ActTheLeadingRole order by Rankings desc";
                DataTable dataTable = ADO.Select(sql);
                string[] Images = new string[6];string[] FilmName = new string[6];
                Images[0] = dataTable.Rows[0]["ImagesPos"].ToString();
                Images[1] = dataTable.Rows[1]["ImagesPos"].ToString();
                Images[2] = dataTable.Rows[2]["ImagesPos"].ToString();
                Images[3] = dataTable.Rows[3]["ImagesPos"].ToString();
                Images[4] = dataTable.Rows[4]["ImagesPos"].ToString();
                Images[5] = dataTable.Rows[5]["ImagesPos"].ToString();
                pictureBox1.Image = Image.FromFile(Images[0]);
                pictureBox2.Image = Image.FromFile(Images[1]);
                pictureBox3.Image = Image.FromFile(Images[2]);
                pictureBox4.Image = Image.FromFile(Images[3]);
                pictureBox5.Image = Image.FromFile(Images[4]);
                pictureBox6.Image = Image.FromFile(Images[5]);
               
                    labelp11.Text=dataTable.Rows[0]["MovieName"].ToString();
                    labelp21.Text=dataTable.Rows[1]["MovieName"].ToString();
                   labelp31.Text =dataTable.Rows[2]["MovieName"].ToString();
                   label1p41.Text= dataTable.Rows[3]["MovieName"].ToString();
                   labelp51.Text=dataTable.Rows[4]["MovieName"].ToString();
                   labelp61.Text= dataTable.Rows[5]["MovieName"].ToString();
              
                    labelp12.Text = dataTable.Rows[0]["MovieType"].ToString();
                    labelp22.Text = dataTable.Rows[1]["MovieType"].ToString();
                    labelp32.Text = dataTable.Rows[2]["MovieType"].ToString();
                    labelp42.Text = dataTable.Rows[3]["MovieType"].ToString();
                    labelp52.Text = dataTable.Rows[4]["MovieType"].ToString();
                    labelp62.Text =dataTable.Rows[5]["MovieType"].ToString();
               
                    labelp13.Text = dataTable.Rows[0]["ActTheLeadingRole"].ToString();
                    labelp23.Text = dataTable.Rows[1]["ActTheLeadingRole"].ToString();
                    labelp33.Text = dataTable.Rows[2]["ActTheLeadingRole"].ToString();
                    label1p43.Text = dataTable.Rows[3]["ActTheLeadingRole"].ToString();
                    labelp53.Text = dataTable.Rows[4]["ActTheLeadingRole"].ToString();
                    labelp63.Text = dataTable.Rows[5]["ActTheLeadingRole"].ToString();
            }
            catch (Exception ex)
            {
                UIMessageTip.ShowError(ex.Message);
            }
        }
    }
}
