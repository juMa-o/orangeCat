
namespace XINGJI_Film.Contrls
{
    partial class UserInformation
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button7 = new System.Windows.Forms.Button();
            this.userdata = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UName = new Sunny.UI.UITextBox();
            this.UID = new Sunny.UI.UITextBox();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chaUID = new System.Windows.Forms.Button();
            this.chaUName = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.AliceBlue;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(660, 7);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 37);
            this.button7.TabIndex = 17;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // userdata
            // 
            this.userdata.AllowUserToAddRows = false;
            this.userdata.AllowUserToDeleteRows = false;
            this.userdata.AllowUserToResizeColumns = false;
            this.userdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userdata.BackgroundColor = System.Drawing.Color.White;
            this.userdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userdata.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.userdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userdata.ColumnHeadersHeight = 31;
            this.userdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.USerID,
            this.dataGridViewTextBoxColumn3,
            this.MovieName1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.userdata.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.userdata.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.userdata.Location = new System.Drawing.Point(0, 61);
            this.userdata.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.userdata.Name = "userdata";
            this.userdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userdata.RowHeadersVisible = false;
            this.userdata.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.userdata.RowTemplate.Height = 27;
            this.userdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userdata.ShowCellErrors = false;
            this.userdata.ShowRowErrors = false;
            this.userdata.Size = new System.Drawing.Size(1549, 449);
            this.userdata.TabIndex = 21;
            this.userdata.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userdata_CellMouseDoubleClick);
            this.userdata.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.userdata_RowPostPaint);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "序号";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 78;
            // 
            // USerID
            // 
            this.USerID.DataPropertyName = "id";
            this.USerID.HeaderText = "UID";
            this.USerID.MinimumWidth = 6;
            this.USerID.Name = "USerID";
            this.USerID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MovieName1
            // 
            this.MovieName1.DataPropertyName = "Number";
            this.MovieName1.HeaderText = "用户账号";
            this.MovieName1.MinimumWidth = 6;
            this.MovieName1.Name = "MovieName1";
            this.MovieName1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "用户密码";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RegisterTime";
            this.Column1.HeaderText = "注册时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 124);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.刷新ToolStripMenuItem.ShowShortcutKeys = false;
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除ToolStripMenuItem.ShowShortcutKeys = false;
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // UName
            // 
            this.UName.BackColor = System.Drawing.Color.White;
            this.UName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UName.FillColor = System.Drawing.Color.White;
            this.UName.FillDisableColor = System.Drawing.Color.Transparent;
            this.UName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UName.ForeColor = System.Drawing.Color.Black;
            this.UName.Location = new System.Drawing.Point(347, 9);
            this.UName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UName.Maximum = 2147483647D;
            this.UName.Minimum = -2147483648D;
            this.UName.MinimumSize = new System.Drawing.Size(1, 1);
            this.UName.Name = "UName";
            this.UName.Padding = new System.Windows.Forms.Padding(5);
            this.UName.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.UName.RectColor = System.Drawing.Color.Black;
            this.UName.RectDisableColor = System.Drawing.Color.Transparent;
            this.UName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.UName.Size = new System.Drawing.Size(211, 34);
            this.UName.Style = Sunny.UI.UIStyle.Custom;
            this.UName.TabIndex = 20;
            this.UName.Watermark = "输入用户姓名";
            // 
            // UID
            // 
            this.UID.BackColor = System.Drawing.Color.White;
            this.UID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UID.FillColor = System.Drawing.Color.White;
            this.UID.FillDisableColor = System.Drawing.Color.Transparent;
            this.UID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UID.ForeColor = System.Drawing.Color.Black;
            this.UID.Location = new System.Drawing.Point(13, 9);
            this.UID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UID.Maximum = 2147483647D;
            this.UID.Minimum = -2147483648D;
            this.UID.MinimumSize = new System.Drawing.Size(1, 1);
            this.UID.Name = "UID";
            this.UID.Padding = new System.Windows.Forms.Padding(5);
            this.UID.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.UID.RectColor = System.Drawing.Color.Black;
            this.UID.RectDisableColor = System.Drawing.Color.Transparent;
            this.UID.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.UID.Size = new System.Drawing.Size(211, 34);
            this.UID.Style = Sunny.UI.UIStyle.Custom;
            this.UID.TabIndex = 21;
            this.UID.Watermark = "输入用户UID";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel2.Text = "当前记录：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chaUID);
            this.panel1.Controls.Add(this.chaUName);
            this.panel1.Controls.Add(this.UName);
            this.panel1.Controls.Add(this.UID);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 66);
            this.panel1.TabIndex = 22;
            // 
            // chaUID
            // 
            this.chaUID.BackColor = System.Drawing.Color.Transparent;
            this.chaUID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chaUID.BackgroundImage")));
            this.chaUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chaUID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chaUID.ForeColor = System.Drawing.Color.White;
            this.chaUID.Image = ((System.Drawing.Image)(resources.GetObject("chaUID.Image")));
            this.chaUID.Location = new System.Drawing.Point(235, 10);
            this.chaUID.Name = "chaUID";
            this.chaUID.Size = new System.Drawing.Size(72, 33);
            this.chaUID.TabIndex = 26;
            this.chaUID.Text = "查询";
            this.chaUID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chaUID.UseVisualStyleBackColor = false;
            this.chaUID.Click += new System.EventHandler(this.chaUID_Click);
            // 
            // chaUName
            // 
            this.chaUName.BackColor = System.Drawing.Color.Transparent;
            this.chaUName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chaUName.BackgroundImage")));
            this.chaUName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chaUName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chaUName.ForeColor = System.Drawing.Color.White;
            this.chaUName.Image = ((System.Drawing.Image)(resources.GetObject("chaUName.Image")));
            this.chaUName.Location = new System.Drawing.Point(571, 10);
            this.chaUName.Name = "chaUName";
            this.chaUName.Size = new System.Drawing.Size(72, 33);
            this.chaUName.TabIndex = 25;
            this.chaUName.Text = "查询";
            this.chaUName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chaUName.UseVisualStyleBackColor = false;
            this.chaUName.Click += new System.EventHandler(this.chaUName_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1549, 25);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 20);
            this.toolStripStatusLabel1.Text = "--电影信息数据--";
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userdata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserInformation";
            this.Size = new System.Drawing.Size(1549, 532);
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView userdata;
        private Sunny.UI.UITextBox UName;
        private Sunny.UI.UITextBox UID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn USerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button chaUID;
        private System.Windows.Forms.Button chaUName;
    }
}
