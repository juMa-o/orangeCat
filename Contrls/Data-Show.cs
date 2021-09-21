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
using System.Runtime.InteropServices;
namespace XINGJI_Film.Contrls
{
    public partial class DataShow : UserControl
    {        
        public DataShow()
        {
            InitializeComponent();
        }
        private void Data_Show_Load(object sender, EventArgs e)
        {
            f();//数据显示
            timer1.Start();//数据每五秒刷新
            timer2.Start();//清理内存，回收垃圾
        }
        //排行榜
        public void Ranking()
        {
            string sql = "select top 10 count(MovieName) as Rankings ,MovieName,MovieType,ScreenTime,MoiveInformation.Price from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where MoiveInformation.ScreenStatus='已上映' group by MovieName,MovieType,MoiveInformation.Price,ScreenTime order by Rankings desc";
            MovieRanking.AutoGenerateColumns = false;//取消自增列
            MovieRanking.DataSource = ADO.Select(sql);//绑定数据源
        }
        //总票房量（总销售额）
        public void Solds()
        {
            string sql = String.Format("select sum(Price) from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid");
            DataTable GetTable = ADO.Select(sql);
            BoxOffice.Text = GetTable.Rows[0][0].ToString();
        }
        //用户注册
            private void uiButton2_Click(object sender, EventArgs e)
            {
            if (UserName.Text != "" & Mob.Text != "" & Password.Text != "")
            {
                //sql语句(增)
                string sql = string.Format("insert Users(UserName,Number,Password,RegisterTime) values('{0}','{1}','{2}','{3}')", UserName.Text, Mob.Text, Password.Text,DateTime.Now);
                string sql1 = string.Format("select * from Users where Number='{0}'", Mob.Text);
                if (ADO.Select(sql1).Rows.Count<=0)
                {
                    if (ADO.InsertDeleteUpdate(sql) > 0)
                    {
                        UIMessageTip.ShowOk("注册成功！");
                        UserName.Clear(); Mob.Clear(); Password.Clear();  //注册成功后清空
                    }
                    else
                    {
                        UIMessageTip.ShowError("注册失败，请检查填写信息是否有误。");
                    }
                }
                else
                {
                    UIMessageTip.Show("账号已被注册！");
                }
            }
            else
            {
                UIMessageTip.ShowError("注册信息填写不许有空项！");
            }
        }
        private void uiButton3_Click(object sender, EventArgs e)//清除按钮
        {
            //清空数据
            ShowPicture.Image = null; ActTheLeadingRole.Clear();Direct.Clear();Duration.Clear();MovieNames.Clear();BriefIntroduction.Clear();Price.Clear();uiRadioNo.Checked= true;ScreenTime.Text ="";MovieType.Clear();
        }
       private void MovieRanking_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//绘制事件
        {
            //自动序号与数据无关
            foreach (DataGridViewRow Row in MovieRanking.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }
        //计时器(主页数据刷新)
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                OrdersInformation1 ordersInformation = new OrdersInformation1(); ordersInformation.num();
                Orderslabel.Text = SaveDatas.OrdersNum.ToString();
                string TodayOrderssql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where Orders.OrderStartTime between '" + DateTime.Now.ToShortDateString() + "'and '" + DateTime.Now.Tomorrow().ToString("yyyy'-'MM'-'dd") + "'");
                DataTable numbers = ADO.Select(TodayOrderssql);
                SaveDatas.TdOrdersNum = int.Parse(TodayOrders.Text = numbers.Rows.Count.ToString());
                string Seats = "select count(Orderid) as counts from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where OrderStatus='已完成'";
                DataTable GetTable1 = ADO.Select(Seats);
                Sessions.Text = GetTable1.Rows[0][0].ToString();//总座次
                Ranking();Solds(); Thread.Sleep(1);
            }
            catch (Exception EX)
            {
                UIMessageTip.ShowError(EX.Message);
            }
        }
        void f()
        {
            string sql = String.Format("select sum(Price) from Orders o,MoiveInformation m where o.MovieInformationid=m.id");
            DataTable GetTable = ADO.Select(sql);
            BoxOffice.Text = GetTable.Rows[0][0].ToString();
            OrdersInformation1 ordersInformation = new OrdersInformation1(); ordersInformation.num();
            Orderslabel.Text = SaveDatas.OrdersNum.ToString();
            string TodayOrderssql = String.Format("select * from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where Orders.OrderStartTime between '" + DateTime.Now.ToShortDateString() + "'and '" + DateTime.Now.Tomorrow().ToString("yyyy'-'MM'-'dd") + "'");
            DataTable numbers = ADO.Select(TodayOrderssql);
            SaveDatas.TdOrdersNum = int.Parse(TodayOrders.Text = numbers.Rows.Count.ToString());
            string Seats = "select count(Orderid) as counts from Orders left join MoiveInformation on Orders.MovieInformationid=MoiveInformation.id left join Auditorium on Orders.Auditoriumid=Auditorium.id left join users on Orders.Userid=Users.id left join Seat on Seat.seatID=Orders.Seatid left join OpenDate1 on OpenDate1.id=Orders.OpenDateid left join OpenTime on OpenTime.id=Orders.OpenTimeid where OrderStatus='已完成'";
            DataTable GetTable1 = ADO.Select(Seats);
            Sessions.Text = GetTable1.Rows[0][0].ToString();//总座次
            Ranking();
            Contrls.SoldNoteInformation soldNoteInformation = new SoldNoteInformation();soldNoteInformation.Dispose();
            Contrls.UserInformation userInformation = new UserInformation();userInformation.Dispose();
            ordersInformation.Dispose(); MoiveInformation1 moiveInformation1 = new  MoiveInformation1();moiveInformation1.Dispose();
        }
        private void Sead_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(sf)); t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.DisableComObjectEagerCleanup();
        }
        public bool Result = false;
        public string FileRealPos = "";
        public string[] ImageDate;
        public string MovieImagesPos = "";
        public void sf() {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "请选择一张图片";
            openFile.Multiselect = false;
            openFile.Filter = "(.JPG*)|*.JPG*|(.png*)|*.png*|*.bmp|*.bmp*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileRealPos = openFile.FileName;//图片名称及路径
                    ImageDate = FileRealPos.Split('.');
                    ShowPicture.Image = Image.FromFile(FileRealPos);//展示
                    string ImagesName = DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString();
                    ImagesName = System.Text.RegularExpressions.Regex.Replace(ImagesName, ":", "");
                    MovieImagesPos = Application.StartupPath.ToString()+"\\MovieImages\\" +ImagesName+ "." + ImageDate[1];
                    UIMessageTip.ShowOk("上传成功！");
                    Result = true;
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError("上传失败"+(ex.Message));
                }
            }
        }
        //录入电影信息--添加数据 
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string ScreenStatus = "";
            try
            {
                if (Result!=false&&ActTheLeadingRole.Text != "" &&Direct.Text != "" && Duration.Text != "" && MovieNames.Text != "" & Price.Text != "" &&MovieType.Text != "" && BriefIntroduction.Text != "")
                {
                    File.Copy(FileRealPos, MovieImagesPos);
                    if (uiRadioYes.Checked)
                    {
                        ScreenStatus = "已上映";
                    }
                    else
                    {
                        ScreenStatus = "未上映";
                    }
                    string sql = string.Format("insert MoiveInformation(MovieName,ActTheLeadingRole,Direct,Duration,MovieType,ScreenTime,Price,BriefIntroduction,ScreenStatus,ImagesPos) values('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}')", MovieNames.Text, ActTheLeadingRole.Text, Direct.Text, Duration.Text, MovieType.Text, DateTime.Parse(ScreenTime.Text), double.Parse(Price.Text), BriefIntroduction.Text, ScreenStatus, MovieImagesPos);
                    InsertMovieInformation(sql);
                }
                else
                {
                    UIMessageTip.ShowError("请填写完整！");
                }
            }
            catch (Exception EX)
            {
                UIMessageTip.Show("上传错误" +EX.Message);
            }
        }
        //传SQL语句并执行操作的方法
        public void InsertMovieInformation(string sql)
        {
            if (ADO.InsertDeleteUpdate(sql) > 0)
            {
                UIMessageTip.Show("已录入");
                //清空数据
                ActTheLeadingRole.Clear(); Direct.Clear(); Duration.Clear(); MovieNames.Clear(); BriefIntroduction.Clear(); Price.Clear(); uiRadioNo.Checked = true; ScreenTime.Text = ""; MovieType.Clear(); ShowPicture.Image = null;
                //释放内存
             
            }
            else
            {
                UIMessageTip.Show("录入失败");
            }
        }
        private void ScreenTime_CloseUp(object sender, EventArgs e)
        {
            UIMessageTip.Show(ScreenTime.Text);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            FlushMemory();
        }
        /// <summary>
        /// 刷新内存
        /// </summary>
        public static void FlushMemory()
        {
            GarbageCollect();

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        /// <summary>
        /// 主动通知系统进行垃圾回收
        /// </summary>
        public static void GarbageCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        /// <summary>
        /// 把不频繁执行或者已经很久没有执行的代码,没有必要留在物理内存中,只会造成浪费;放在虚拟内存中,等执行这部分代码的时候,再调出来
        /// </summary>
        /// <param name="process"></param>
        /// <param name="minSize"></param>
        /// <param name="maxSize"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

    }
}
