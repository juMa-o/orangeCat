
namespace XINGJI_Film.form
{
    partial class UserUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.UsersInformation = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersInformation)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-9, -5);
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
            this.chaUID.Click += new System.EventHandler(this.chaUID_Click);
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
            // UsersInformation
            // 
            this.UsersInformation.AllowUserToAddRows = false;
            this.UsersInformation.AllowUserToDeleteRows = false;
            this.UsersInformation.AllowUserToResizeColumns = false;
            this.UsersInformation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UsersInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsersInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersInformation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.UsersInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersInformation.ColumnHeadersHeight = 31;
            this.UsersInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Orderid,
            this.dataGridViewTextBoxColumn3,
            this.MovieName1,
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersInformation.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersInformation.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.UsersInformation.Location = new System.Drawing.Point(-9, 58);
            this.UsersInformation.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.UsersInformation.Name = "UsersInformation";
            this.UsersInformation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UsersInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UsersInformation.RowHeadersVisible = false;
            this.UsersInformation.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersInformation.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersInformation.RowTemplate.Height = 27;
            this.UsersInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersInformation.Size = new System.Drawing.Size(1567, 478);
            this.UsersInformation.TabIndex = 24;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1549, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.UsersInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUI";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersInformation)).EndInit();
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
        private System.Windows.Forms.DataGridView UsersInformation;
    }
}