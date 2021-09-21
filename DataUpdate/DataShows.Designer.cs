namespace XINGJI_Film.forms
{
    partial class DataShows
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
            this.uiRadioNo = new Sunny.UI.UIRadioButton();
            this.uiRadioYes = new Sunny.UI.UIRadioButton();
            this.ScreenTime = new System.Windows.Forms.DateTimePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.Direct = new Sunny.UI.UITextBox();
            this.MovieType = new Sunny.UI.UITextBox();
            this.Duration = new Sunny.UI.UITextBox();
            this.ActTheLeadingRole = new Sunny.UI.UITextBox();
            this.Price = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.BriefIntroduction = new Sunny.UI.UITextBox();
            this.MovieName = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.ShowPicture = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Sead = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // uiRadioNo
            // 
            this.uiRadioNo.Checked = true;
            this.uiRadioNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioNo.Location = new System.Drawing.Point(486, 253);
            this.uiRadioNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioNo.Name = "uiRadioNo";
            this.uiRadioNo.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioNo.Size = new System.Drawing.Size(64, 29);
            this.uiRadioNo.TabIndex = 21;
            this.uiRadioNo.Text = "否";
            // 
            // uiRadioYes
            // 
            this.uiRadioYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioYes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioYes.Location = new System.Drawing.Point(428, 253);
            this.uiRadioYes.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioYes.Name = "uiRadioYes";
            this.uiRadioYes.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioYes.Size = new System.Drawing.Size(64, 29);
            this.uiRadioYes.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioYes.TabIndex = 22;
            this.uiRadioYes.Text = "是";
            // 
            // ScreenTime
            // 
            this.ScreenTime.Location = new System.Drawing.Point(146, 253);
            this.ScreenTime.Name = "ScreenTime";
            this.ScreenTime.Size = new System.Drawing.Size(200, 25);
            this.ScreenTime.TabIndex = 20;
            this.ScreenTime.CloseUp += new System.EventHandler(this.ScreenTime_CloseUp);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(34, 244);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(145, 34);
            this.uiLabel5.TabIndex = 13;
            this.uiLabel5.Text = "上映时间：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Direct
            // 
            this.Direct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Direct.FillColor = System.Drawing.Color.White;
            this.Direct.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Direct.Location = new System.Drawing.Point(146, 63);
            this.Direct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Direct.Maximum = 2147483647D;
            this.Direct.Minimum = -2147483648D;
            this.Direct.MinimumSize = new System.Drawing.Size(1, 1);
            this.Direct.Name = "Direct";
            this.Direct.Padding = new System.Windows.Forms.Padding(5);
            this.Direct.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Direct.RectColor = System.Drawing.SystemColors.ControlText;
            this.Direct.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.Direct.Size = new System.Drawing.Size(404, 34);
            this.Direct.Style = Sunny.UI.UIStyle.Custom;
            this.Direct.TabIndex = 8;
            // 
            // MovieType
            // 
            this.MovieType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MovieType.FillColor = System.Drawing.Color.White;
            this.MovieType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MovieType.Location = new System.Drawing.Point(146, 189);
            this.MovieType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieType.Maximum = 2147483647D;
            this.MovieType.Minimum = -2147483648D;
            this.MovieType.MinimumSize = new System.Drawing.Size(1, 1);
            this.MovieType.Name = "MovieType";
            this.MovieType.Padding = new System.Windows.Forms.Padding(5);
            this.MovieType.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.MovieType.RectColor = System.Drawing.SystemColors.ControlText;
            this.MovieType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.MovieType.Size = new System.Drawing.Size(404, 34);
            this.MovieType.Style = Sunny.UI.UIStyle.Custom;
            this.MovieType.TabIndex = 9;
            // 
            // Duration
            // 
            this.Duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Duration.FillColor = System.Drawing.Color.White;
            this.Duration.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Duration.Location = new System.Drawing.Point(146, 123);
            this.Duration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Duration.Maximum = 2147483647D;
            this.Duration.Minimum = -2147483648D;
            this.Duration.MinimumSize = new System.Drawing.Size(1, 1);
            this.Duration.Name = "Duration";
            this.Duration.Padding = new System.Windows.Forms.Padding(5);
            this.Duration.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Duration.RectColor = System.Drawing.SystemColors.ControlText;
            this.Duration.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.Duration.Size = new System.Drawing.Size(404, 34);
            this.Duration.Style = Sunny.UI.UIStyle.Custom;
            this.Duration.TabIndex = 10;
            // 
            // ActTheLeadingRole
            // 
            this.ActTheLeadingRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ActTheLeadingRole.FillColor = System.Drawing.Color.White;
            this.ActTheLeadingRole.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ActTheLeadingRole.Location = new System.Drawing.Point(146, 8);
            this.ActTheLeadingRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActTheLeadingRole.Maximum = 2147483647D;
            this.ActTheLeadingRole.Minimum = -2147483648D;
            this.ActTheLeadingRole.MinimumSize = new System.Drawing.Size(1, 1);
            this.ActTheLeadingRole.Name = "ActTheLeadingRole";
            this.ActTheLeadingRole.Padding = new System.Windows.Forms.Padding(5);
            this.ActTheLeadingRole.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.ActTheLeadingRole.RectColor = System.Drawing.SystemColors.ControlText;
            this.ActTheLeadingRole.RectDisableColor = System.Drawing.Color.Transparent;
            this.ActTheLeadingRole.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.ActTheLeadingRole.Size = new System.Drawing.Size(404, 34);
            this.ActTheLeadingRole.Style = Sunny.UI.UIStyle.Custom;
            this.ActTheLeadingRole.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.FillColor = System.Drawing.Color.White;
            this.Price.FillDisableColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Price.Location = new System.Drawing.Point(146, 289);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Price.Maximum = 2147483647D;
            this.Price.Minimum = -2147483648D;
            this.Price.MinimumSize = new System.Drawing.Size(1, 1);
            this.Price.Name = "Price";
            this.Price.Padding = new System.Windows.Forms.Padding(5);
            this.Price.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Price.RectColor = System.Drawing.SystemColors.ControlText;
            this.Price.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.Price.Size = new System.Drawing.Size(126, 34);
            this.Price.Style = Sunny.UI.UIStyle.Custom;
            this.Price.TabIndex = 12;
            this.Price.Text = "0.00";
            this.Price.Type = Sunny.UI.UITextBox.UIEditType.Double;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(34, 192);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(145, 34);
            this.uiLabel7.TabIndex = 14;
            this.uiLabel7.Text = "电影类型：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(34, 124);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(115, 34);
            this.uiLabel6.TabIndex = 15;
            this.uiLabel6.Text = "时长：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel14.ForeColor = System.Drawing.Color.Black;
            this.uiLabel14.Location = new System.Drawing.Point(368, 249);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(89, 34);
            this.uiLabel14.TabIndex = 16;
            this.uiLabel14.Text = "上映：";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(34, 63);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(115, 34);
            this.uiLabel4.TabIndex = 17;
            this.uiLabel4.Text = "导演：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(34, 290);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(130, 34);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 18;
            this.uiLabel8.Text = "价格：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(34, 8);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(115, 34);
            this.uiLabel3.TabIndex = 19;
            this.uiLabel3.Text = "主演：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BriefIntroduction
            // 
            this.BriefIntroduction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BriefIntroduction.FillColor = System.Drawing.Color.White;
            this.BriefIntroduction.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BriefIntroduction.Location = new System.Drawing.Point(103, 361);
            this.BriefIntroduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BriefIntroduction.Maximum = 2147483647D;
            this.BriefIntroduction.Minimum = -2147483648D;
            this.BriefIntroduction.MinimumSize = new System.Drawing.Size(1, 1);
            this.BriefIntroduction.Multiline = true;
            this.BriefIntroduction.Name = "BriefIntroduction";
            this.BriefIntroduction.Padding = new System.Windows.Forms.Padding(5);
            this.BriefIntroduction.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.BriefIntroduction.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.BriefIntroduction.Size = new System.Drawing.Size(389, 196);
            this.BriefIntroduction.Style = Sunny.UI.UIStyle.Black;
            this.BriefIntroduction.TabIndex = 23;
            // 
            // MovieName
            // 
            this.MovieName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MovieName.FillColor = System.Drawing.Color.White;
            this.MovieName.FillDisableColor = System.Drawing.Color.Transparent;
            this.MovieName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MovieName.Location = new System.Drawing.Point(680, 24);
            this.MovieName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieName.Maximum = 2147483647D;
            this.MovieName.Minimum = -2147483648D;
            this.MovieName.MinimumSize = new System.Drawing.Size(1, 1);
            this.MovieName.Name = "MovieName";
            this.MovieName.Padding = new System.Windows.Forms.Padding(5);
            this.MovieName.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.MovieName.RectColor = System.Drawing.SystemColors.ControlText;
            this.MovieName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.MovieName.Size = new System.Drawing.Size(404, 34);
            this.MovieName.Style = Sunny.UI.UIStyle.Custom;
            this.MovieName.TabIndex = 24;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(33, 352);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(72, 34);
            this.uiLabel9.TabIndex = 25;
            this.uiLabel9.Text = "简介：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(573, 25);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(135, 34);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 26;
            this.uiLabel2.Text = "电影名称：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.uiButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.uiButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(740, 498);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.uiButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.uiButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.uiButton3.Size = new System.Drawing.Size(140, 59);
            this.uiButton3.Style = Sunny.UI.UIStyle.Green;
            this.uiButton3.TabIndex = 27;
            this.uiButton3.Text = "返回";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiButton1.Location = new System.Drawing.Point(541, 498);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiButton1.Size = new System.Drawing.Size(124, 59);
            this.uiButton1.Style = Sunny.UI.UIStyle.LightBlue;
            this.uiButton1.TabIndex = 28;
            this.uiButton1.Text = "确认修改";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // ShowPicture
            // 
            this.ShowPicture.BackColor = System.Drawing.Color.Transparent;
            this.ShowPicture.Location = new System.Drawing.Point(715, 94);
            this.ShowPicture.Name = "ShowPicture";
            this.ShowPicture.Size = new System.Drawing.Size(262, 292);
            this.ShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPicture.TabIndex = 29;
            this.ShowPicture.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(574, 94);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(135, 34);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 26;
            this.uiLabel1.Text = "图片：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sead
            // 
            this.Sead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sead.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.Sead.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.Sead.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.Sead.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.Sead.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Sead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Sead.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Sead.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Sead.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Sead.Location = new System.Drawing.Point(575, 147);
            this.Sead.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sead.Name = "Sead";
            this.Sead.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.Sead.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.Sead.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.Sead.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.Sead.Size = new System.Drawing.Size(90, 42);
            this.Sead.Style = Sunny.UI.UIStyle.Office2010Blue;
            this.Sead.TabIndex = 30;
            this.Sead.Text = "更换";
            this.Sead.Click += new System.EventHandler(this.Sead_Click);
            // 
            // DataShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 569);
            this.Controls.Add(this.Sead);
            this.Controls.Add(this.ShowPicture);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.BriefIntroduction);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiRadioNo);
            this.Controls.Add(this.uiRadioYes);
            this.Controls.Add(this.ScreenTime);
            this.Controls.Add(this.Direct);
            this.Controls.Add(this.MovieType);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.ActTheLeadingRole);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel14);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1247, 616);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1247, 616);
            this.Name = "DataShows";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "详情";
            this.Load += new System.EventHandler(this.DataShows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButton uiRadioNo;
        private Sunny.UI.UIRadioButton uiRadioYes;
        private System.Windows.Forms.DateTimePicker ScreenTime;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox Direct;
        private Sunny.UI.UITextBox MovieType;
        private Sunny.UI.UITextBox Duration;
        private Sunny.UI.UITextBox ActTheLeadingRole;
        private Sunny.UI.UITextBox Price;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox BriefIntroduction;
        private Sunny.UI.UITextBox MovieName;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.PictureBox ShowPicture;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton Sead;
    }
}