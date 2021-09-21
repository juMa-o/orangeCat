
namespace XINGJI_Film.Contrls
{
    partial class UserInformations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chaOID = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UID = new Sunny.UI.UITextBox();
            this.OID = new Sunny.UI.UITextBox();
            this.chaUID = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Orderdata1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orderdata1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 20);
            this.toolStripStatusLabel1.Text = "--电影信息数据--";
            // 
            // chaOID
            // 
            this.chaOID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chaOID.BackgroundImage")));
            this.chaOID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chaOID.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chaOID.Location = new System.Drawing.Point(231, 17);
            this.chaOID.Name = "chaOID";
            this.chaOID.Size = new System.Drawing.Size(61, 27);
            this.chaOID.TabIndex = 18;
            this.chaOID.Text = "  查询";
            this.chaOID.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UID);
            this.panel1.Controls.Add(this.OID);
            this.panel1.Controls.Add(this.chaUID);
            this.panel1.Controls.Add(this.chaOID);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 66);
            this.panel1.TabIndex = 25;
            // 
            // UID
            // 
            this.UID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UID.FillColor = System.Drawing.Color.White;
            this.UID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UID.Location = new System.Drawing.Point(308, 13);
            this.UID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UID.Maximum = 2147483647D;
            this.UID.Minimum = -2147483648D;
            this.UID.MinimumSize = new System.Drawing.Size(1, 1);
            this.UID.Name = "UID";
            this.UID.Padding = new System.Windows.Forms.Padding(5);
            this.UID.Size = new System.Drawing.Size(211, 34);
            this.UID.TabIndex = 20;
            this.UID.Watermark = "输入用户账号";
            // 
            // OID
            // 
            this.OID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OID.FillColor = System.Drawing.Color.White;
            this.OID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.OID.Location = new System.Drawing.Point(14, 13);
            this.OID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OID.Maximum = 2147483647D;
            this.OID.Minimum = -2147483648D;
            this.OID.MinimumSize = new System.Drawing.Size(1, 1);
            this.OID.Name = "OID";
            this.OID.Padding = new System.Windows.Forms.Padding(5);
            this.OID.Size = new System.Drawing.Size(211, 34);
            this.OID.TabIndex = 21;
            this.OID.Watermark = "输入用户UID";
            // 
            // chaUID
            // 
            this.chaUID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chaUID.BackgroundImage")));
            this.chaUID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chaUID.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chaUID.Location = new System.Drawing.Point(526, 17);
            this.chaUID.Name = "chaUID";
            this.chaUID.Size = new System.Drawing.Size(61, 27);
            this.chaUID.TabIndex = 19;
            this.chaUID.Text = "  查询";
            this.chaUID.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(640, -1);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 59);
            this.button7.TabIndex = 17;
            this.button7.Text = "刷新";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel2.Text = "当前记录：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1549, 26);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "--";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "详情";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 37;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direct";
            this.dataGridViewTextBoxColumn4.HeaderText = "用户密码";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // MovieName1
            // 
            this.MovieName1.DataPropertyName = "MovieName";
            this.MovieName1.HeaderText = "用户账号";
            this.MovieName1.MinimumWidth = 6;
            this.MovieName1.Name = "MovieName1";
            this.MovieName1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActTheLeadingRole";
            this.dataGridViewTextBoxColumn3.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Orderid
            // 
            this.Orderid.DataPropertyName = "Orderid";
            this.Orderid.HeaderText = "UID";
            this.Orderid.MinimumWidth = 6;
            this.Orderid.Name = "Orderid";
            this.Orderid.ReadOnly = true;
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "--";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "删除";
            this.Column2.Width = 37;
            // 
            // Orderdata1
            // 
            this.Orderdata1.AllowUserToAddRows = false;
            this.Orderdata1.AllowUserToDeleteRows = false;
            this.Orderdata1.AllowUserToResizeColumns = false;
            this.Orderdata1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Orderdata1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Orderdata1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Orderdata1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orderdata1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Orderdata1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Orderdata1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Orderdata1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Orderdata1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orderdata1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Orderdata1.ColumnHeadersHeight = 31;
            this.Orderdata1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Orderid,
            this.dataGridViewTextBoxColumn3,
            this.MovieName1,
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Orderdata1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Orderdata1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Orderdata1.Location = new System.Drawing.Point(0, 63);
            this.Orderdata1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Orderdata1.Name = "Orderdata1";
            this.Orderdata1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Orderdata1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Orderdata1.RowHeadersVisible = false;
            this.Orderdata1.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orderdata1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Orderdata1.RowTemplate.Height = 27;
            this.Orderdata1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orderdata1.Size = new System.Drawing.Size(1549, 449);
            this.Orderdata1.TabIndex = 24;
            // 
            // UserInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Orderdata1);
            this.Name = "UserInformations";
            this.Size = new System.Drawing.Size(1549, 532);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orderdata1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button chaOID;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UITextBox UID;
        private Sunny.UI.UITextBox OID;
        private System.Windows.Forms.Button chaUID;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridView Orderdata1;
    }
}
