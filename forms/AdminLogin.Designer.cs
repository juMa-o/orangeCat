namespace XINGJI_Film
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.LoginButton = new System.Windows.Forms.Button();
            this.pwd = new Sunny.UI.UITextBox();
            this.uid = new Sunny.UI.UITextBox();
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
            this.LoginButton.Location = new System.Drawing.Point(260, 671);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(127, 41);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pwd
            // 
            this.pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwd.FillColor = System.Drawing.Color.White;
            this.pwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pwd.Location = new System.Drawing.Point(204, 593);
            this.pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwd.Maximum = 2147483647D;
            this.pwd.Minimum = -2147483648D;
            this.pwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.pwd.Name = "pwd";
            this.pwd.Padding = new System.Windows.Forms.Padding(5);
            this.pwd.PasswordChar = '*';
            this.pwd.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pwd.RectColor = System.Drawing.Color.Black;
            this.pwd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.pwd.Size = new System.Drawing.Size(261, 34);
            this.pwd.Style = Sunny.UI.UIStyle.Custom;
            this.pwd.TabIndex = 3;
            this.pwd.Watermark = "输入密码";
            // 
            // uid
            // 
            this.uid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uid.FillColor = System.Drawing.Color.White;
            this.uid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uid.Location = new System.Drawing.Point(204, 535);
            this.uid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uid.Maximum = 2147483647D;
            this.uid.Minimum = -2147483648D;
            this.uid.MinimumSize = new System.Drawing.Size(1, 1);
            this.uid.Name = "uid";
            this.uid.Padding = new System.Windows.Forms.Padding(5);
            this.uid.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uid.RectColor = System.Drawing.Color.Black;
            this.uid.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uid.Size = new System.Drawing.Size(261, 34);
            this.uid.Style = Sunny.UI.UIStyle.Custom;
            this.uid.TabIndex = 2;
            this.uid.Watermark = "输入账号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 746);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 12;
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
            this.售票员入口.Size = new System.Drawing.Size(96, 24);
            this.售票员入口.Text = "售票员入口";
            this.售票员入口.Click += new System.EventHandler(this.售票员入口_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出,
            this.最小化,
            this.售票员入口});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1330, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 783);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1348, 830);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员系统";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminLogin_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private Sunny.UI.UITextBox pwd;
        private Sunny.UI.UITextBox uid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.ToolStripMenuItem 最小化;
        private System.Windows.Forms.ToolStripMenuItem 售票员入口;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}