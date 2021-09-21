using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XINGJI_Film.Contrls
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
        }
        private void UserInformation_Load(object sender, EventArgs e)
        {
            ChaUser(); num();
        }
        public int n = 0;//存放数据数量
        public void ChaUser()
        {
            string sql = "select * from Users";
            DataTable GetTable = ADO.Select(sql);
            if (GetTable.Rows.Count<=0)
            {
                contextMenuStrip1.Items[0].Visible = false;
                contextMenuStrip1.Items[2].Visible = false;
            }
            else
            {
                contextMenuStrip1.Items[0].Visible = true;
                contextMenuStrip1.Items[2].Visible = true;
                userdata.AutoGenerateColumns = false;
                userdata.DataSource = GetTable;
                n = GetTable.Rows.Count;
            }
        }
        public void num()
        {
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text.Substring(0, 5);//重新拉取，防止文字重复显示
            toolStripStatusLabel2.Text += n + "条记录";
        }
        private void userdata_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动序号
            foreach (DataGridViewRow Row in userdata.Rows)
            {
                Row.Cells[0].Value = Row.Index + 1;
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChaUser(); num();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChaUser(); num();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("确定要退出本系统吗？", "提示", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersDeletes();
        }
        public void UsersDeletes()
        {

            int n = userdata.SelectedRows.Count;
            if (n!=0)
            {
                DialogResult Result = MessageBox.Show("确定要删除当前" + n + "记录吗？删除后不可恢复！", "提示", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.OK)
                {
                    string sql = "delete from Users where id in(";
                    for (int i = 0; i < n; i++)
                    {
                        sql += userdata.SelectedRows[i].Cells["USerID"].Value.ToString() + ",";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ")";
                    if (ADO.InsertDeleteUpdate(sql) > 0)
                    {
                        MessageBox.Show("删除成功！"); ChaUser(); num();
                    }
                }
            }
        }    
        private void userdata_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (userdata.SelectedRows.Count>0)
            {
                DataUpdate.UsersDataShow Ud = new DataUpdate.UsersDataShow(); Ud.Tag = userdata.SelectedRows[0].Cells["USerID"].Value.ToString();
                Ud.ShowDialog(); ChaUser();
            }
        }
        private void chaUID_Click(object sender, EventArgs e)
        {
             UID.Text=UID.Text.Trim();
            if (UID.Text!= "")
            {
                try
                {
                    string sql = string.Format("select * from Users where id={0}", UID.Text);
                    DataTable GetTable = ADO.Select(sql);
                    if (GetTable.Rows.Count > 0)
                    {
                        userdata.AutoGenerateColumns = false;
                        userdata.DataSource = GetTable;
                    }
                    else
                    {
                        Help.ShowPopup(chaUID, "没有找到该用户信息，请重新查询。", new Point(chaUID.Right, chaUID.Bottom));
                    }
                }
                catch (Exception ex)
                {

                    Help.ShowPopup(chaUID, "" + ex.Message + "。", new Point(chaUID.Right, chaUID.Bottom));
                }
            }
        }
        private void chaUName_Click_1(object sender, EventArgs e)
        {
            UName.Text=UName.Text.Trim();
            if (UName.Text!= "")
            {
                try
                {
                    string sql = string.Format("select * from Users where UserName like'{0}%'", UName.Text);
                    DataTable GetTable = ADO.Select(sql);
                    if (GetTable.Rows.Count > 0)
                    {
                        userdata.AutoGenerateColumns = false;
                        userdata.DataSource = GetTable;
                    }
                    else
                    {
                        Help.ShowPopup(chaUName, "没有找到该用户信息，请重新查询。", new Point(chaUName.Right, chaUName.Bottom));
                    }
                }
                catch (Exception ex)
                {
                    Help.ShowPopup(chaUName, "" + ex.Message + "。", new Point(chaUName.Right, chaUName.Bottom));
                }
            }
        }
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataUpdate.UsersDataShow Ud = new DataUpdate.UsersDataShow(); Ud.Tag = userdata.SelectedRows[0].Cells["USerID"].Value.ToString();
            Ud.ShowDialog(); ChaUser();
        }
    }
}
