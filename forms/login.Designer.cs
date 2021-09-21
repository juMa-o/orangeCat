namespace XINGJI_Film
{
    partial class login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.LoginButton = new System.Windows.Forms.Button();
            this.uid = new Sunny.UI.UITextBox();
            this.pwd = new Sunny.UI.UITextBox();
            this.CheckBox1 = new Sunny.UI.UICheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化 = new System.Windows.Forms.ToolStripMenuItem();
            this.售票员入口 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(898, 691);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(133, 37);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // uid
            // 
            this.uid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uid.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uid.Location = new System.Drawing.Point(840, 560);
            this.uid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uid.Maximum = 2147483647D;
            this.uid.Minimum = -2147483648D;
            this.uid.MinimumSize = new System.Drawing.Size(1, 1);
            this.uid.Name = "uid";
            this.uid.Padding = new System.Windows.Forms.Padding(5);
            this.uid.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uid.RectColor = System.Drawing.Color.Black;
            this.uid.RectDisableColor = System.Drawing.Color.Transparent;
            this.uid.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uid.Size = new System.Drawing.Size(261, 34);
            this.uid.Style = Sunny.UI.UIStyle.Custom;
            this.uid.TabIndex = 2;
            this.uid.Watermark = "输入账号";
            // 
            // pwd
            // 
            this.pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwd.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pwd.FillDisableColor = System.Drawing.Color.Transparent;
            this.pwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pwd.Location = new System.Drawing.Point(840, 618);
            this.pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwd.Maximum = 2147483647D;
            this.pwd.Minimum = -2147483648D;
            this.pwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.pwd.Name = "pwd";
            this.pwd.Padding = new System.Windows.Forms.Padding(5);
            this.pwd.PasswordChar = '*';
            this.pwd.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pwd.RectColor = System.Drawing.Color.Black;
            this.pwd.RectDisableColor = System.Drawing.Color.Transparent;
            this.pwd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.pwd.Size = new System.Drawing.Size(261, 34);
            this.pwd.Style = Sunny.UI.UIStyle.Custom;
            this.pwd.TabIndex = 3;
            this.pwd.Watermark = "输入密码";
            // 
            // CheckBox1
            // 
            this.CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox1.Location = new System.Drawing.Point(805, 697);
            this.CheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.CheckBox1.Size = new System.Drawing.Size(83, 28);
            this.CheckBox1.TabIndex = 4;
            this.CheckBox1.TabStop = false;
            this.CheckBox1.Text = "记住我";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(1038, 697);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "忘记密码？";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1102, 747);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "星际影院©版权所有";
            // 
            // 退出
            // 
            this.退出.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(51, 24);
            this.退出.Text = "退出";
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // 最小化
            // 
            this.最小化.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.最小化.Name = "最小化";
            this.最小化.Size = new System.Drawing.Size(66, 24);
            this.最小化.Text = "最小化";
            this.最小化.Click += new System.EventHandler(this.最小化_Click);
            // 
            // 售票员入口
            // 
            this.售票员入口.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.售票员入口.ForeColor = System.Drawing.Color.White;
            this.售票员入口.Name = "售票员入口";
            this.售票员入口.ShortcutKeyDisplayString = "管理员入口";
            this.售票员入口.Size = new System.Drawing.Size(96, 24);
            this.售票员入口.Text = "管理员入口";
            this.售票员入口.Click += new System.EventHandler(this.售票员入口_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出,
            this.最小化,
            this.售票员入口});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1326, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 779);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.LoginButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1348, 830);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "星际影院";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginButton;
        private Sunny.UI.UITextBox uid;
        private Sunny.UI.UITextBox pwd;
        private Sunny.UI.UICheckBox CheckBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.ToolStripMenuItem 最小化;
        private System.Windows.Forms.ToolStripMenuItem 售票员入口;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

