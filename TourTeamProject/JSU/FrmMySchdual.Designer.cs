namespace TourTeamProject
{
    partial class FrmMySchdual
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.grup_Goday = new System.Windows.Forms.GroupBox();
            this.dateTime_End = new MetroFramework.Controls.MetroDateTime();
            this.dateTime_Start = new MetroFramework.Controls.MetroDateTime();
            this.grup_Tick = new System.Windows.Forms.GroupBox();
            this.rbo_Hana_3 = new MetroFramework.Controls.MetroRadioButton();
            this.rbo_Rail_7 = new MetroFramework.Controls.MetroRadioButton();
            this.rbo_Rail_5 = new MetroFramework.Controls.MetroRadioButton();
            this.rbo_Rail_3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pick5 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick6 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick7 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick8 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick4 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick3 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick2 = new MetroFramework.Controls.MetroButton();
            this.btn_Pick1 = new MetroFramework.Controls.MetroButton();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Tab2Title = new System.Windows.Forms.Label();
            this.btn_Clear = new MetroFramework.Controls.MetroButton();
            this.btn_ShowSchdual = new MetroFramework.Controls.MetroButton();
            this.btn_Img = new MetroFramework.Controls.MetroButton();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.grup_Goday.SuspendLayout();
            this.grup_Tick.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Controls.Add(this.metroTabPage3);
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1083, 482);
            this.tabControl.TabIndex = 1;
            this.tabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.grup_Goday);
            this.metroTabPage1.Controls.Add(this.grup_Tick);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1075, 437);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // grup_Goday
            // 
            this.grup_Goday.BackColor = System.Drawing.Color.White;
            this.grup_Goday.Controls.Add(this.dateTime_End);
            this.grup_Goday.Controls.Add(this.dateTime_Start);
            this.grup_Goday.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grup_Goday.Location = new System.Drawing.Point(0, 196);
            this.grup_Goday.Name = "grup_Goday";
            this.grup_Goday.Size = new System.Drawing.Size(1013, 156);
            this.grup_Goday.TabIndex = 3;
            this.grup_Goday.TabStop = false;
            this.grup_Goday.Text = "출발일 선택";
            // 
            // dateTime_End
            // 
            this.dateTime_End.Enabled = false;
            this.dateTime_End.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dateTime_End.Location = new System.Drawing.Point(640, 70);
            this.dateTime_End.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateTime_End.Name = "dateTime_End";
            this.dateTime_End.Size = new System.Drawing.Size(250, 39);
            this.dateTime_End.Style = MetroFramework.MetroColorStyle.Green;
            this.dateTime_End.TabIndex = 1;
            // 
            // dateTime_Start
            // 
            this.dateTime_Start.Enabled = false;
            this.dateTime_Start.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dateTime_Start.Location = new System.Drawing.Point(99, 70);
            this.dateTime_Start.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateTime_Start.Name = "dateTime_Start";
            this.dateTime_Start.Size = new System.Drawing.Size(250, 39);
            this.dateTime_Start.Style = MetroFramework.MetroColorStyle.Green;
            this.dateTime_Start.TabIndex = 0;
            this.dateTime_Start.ValueChanged += new System.EventHandler(this.dateTime_Start_ValueChanged);
            // 
            // grup_Tick
            // 
            this.grup_Tick.BackColor = System.Drawing.Color.White;
            this.grup_Tick.Controls.Add(this.rbo_Hana_3);
            this.grup_Tick.Controls.Add(this.rbo_Rail_7);
            this.grup_Tick.Controls.Add(this.rbo_Rail_5);
            this.grup_Tick.Controls.Add(this.rbo_Rail_3);
            this.grup_Tick.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grup_Tick.Location = new System.Drawing.Point(3, 14);
            this.grup_Tick.Name = "grup_Tick";
            this.grup_Tick.Size = new System.Drawing.Size(1009, 145);
            this.grup_Tick.TabIndex = 2;
            this.grup_Tick.TabStop = false;
            this.grup_Tick.Text = "티켓 선택";
            // 
            // rbo_Hana_3
            // 
            this.rbo_Hana_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbo_Hana_3.AutoSize = true;
            this.rbo_Hana_3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbo_Hana_3.Location = new System.Drawing.Point(750, 56);
            this.rbo_Hana_3.Name = "rbo_Hana_3";
            this.rbo_Hana_3.Size = new System.Drawing.Size(185, 25);
            this.rbo_Hana_3.Style = MetroFramework.MetroColorStyle.Green;
            this.rbo_Hana_3.TabIndex = 3;
            this.rbo_Hana_3.Text = "metroRadioButton2";
            this.rbo_Hana_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbo_Hana_3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbo_Hana_3.UseSelectable = true;
            this.rbo_Hana_3.CheckedChanged += new System.EventHandler(this.btn_Rail_3_CheckedChanged);
            // 
            // rbo_Rail_7
            // 
            this.rbo_Rail_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbo_Rail_7.AutoSize = true;
            this.rbo_Rail_7.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbo_Rail_7.Location = new System.Drawing.Point(517, 56);
            this.rbo_Rail_7.Name = "rbo_Rail_7";
            this.rbo_Rail_7.Size = new System.Drawing.Size(185, 25);
            this.rbo_Rail_7.Style = MetroFramework.MetroColorStyle.Green;
            this.rbo_Rail_7.TabIndex = 2;
            this.rbo_Rail_7.Text = "metroRadioButton2";
            this.rbo_Rail_7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbo_Rail_7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbo_Rail_7.UseSelectable = true;
            this.rbo_Rail_7.CheckedChanged += new System.EventHandler(this.btn_Rail_3_CheckedChanged);
            // 
            // rbo_Rail_5
            // 
            this.rbo_Rail_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbo_Rail_5.AutoSize = true;
            this.rbo_Rail_5.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbo_Rail_5.Location = new System.Drawing.Point(284, 56);
            this.rbo_Rail_5.Name = "rbo_Rail_5";
            this.rbo_Rail_5.Size = new System.Drawing.Size(185, 25);
            this.rbo_Rail_5.Style = MetroFramework.MetroColorStyle.Green;
            this.rbo_Rail_5.TabIndex = 1;
            this.rbo_Rail_5.Text = "metroRadioButton2";
            this.rbo_Rail_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbo_Rail_5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbo_Rail_5.UseSelectable = true;
            this.rbo_Rail_5.CheckedChanged += new System.EventHandler(this.btn_Rail_3_CheckedChanged);
            // 
            // rbo_Rail_3
            // 
            this.rbo_Rail_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbo_Rail_3.AutoSize = true;
            this.rbo_Rail_3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbo_Rail_3.Location = new System.Drawing.Point(51, 56);
            this.rbo_Rail_3.Name = "rbo_Rail_3";
            this.rbo_Rail_3.Size = new System.Drawing.Size(185, 25);
            this.rbo_Rail_3.Style = MetroFramework.MetroColorStyle.Green;
            this.rbo_Rail_3.TabIndex = 0;
            this.rbo_Rail_3.Text = "metroRadioButton1";
            this.rbo_Rail_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbo_Rail_3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbo_Rail_3.UseSelectable = true;
            this.rbo_Rail_3.CheckedChanged += new System.EventHandler(this.btn_Rail_3_CheckedChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.btn_Pick5);
            this.metroTabPage2.Controls.Add(this.btn_Pick6);
            this.metroTabPage2.Controls.Add(this.btn_Pick7);
            this.metroTabPage2.Controls.Add(this.btn_Pick8);
            this.metroTabPage2.Controls.Add(this.btn_Pick4);
            this.metroTabPage2.Controls.Add(this.btn_Pick3);
            this.metroTabPage2.Controls.Add(this.btn_Pick2);
            this.metroTabPage2.Controls.Add(this.btn_Pick1);
            this.metroTabPage2.Controls.Add(this.lbl_Title);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1075, 437);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(790, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "｜";
            // 
            // btn_Pick5
            // 
            this.btn_Pick5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick5.Location = new System.Drawing.Point(722, 225);
            this.btn_Pick5.Name = "btn_Pick5";
            this.btn_Pick5.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick5.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick5.TabIndex = 10;
            this.btn_Pick5.UseSelectable = true;
            this.btn_Pick5.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick5.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick6
            // 
            this.btn_Pick6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick6.Location = new System.Drawing.Point(503, 225);
            this.btn_Pick6.Name = "btn_Pick6";
            this.btn_Pick6.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick6.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick6.TabIndex = 9;
            this.btn_Pick6.UseSelectable = true;
            this.btn_Pick6.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick6.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick7
            // 
            this.btn_Pick7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick7.Location = new System.Drawing.Point(284, 225);
            this.btn_Pick7.Name = "btn_Pick7";
            this.btn_Pick7.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick7.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick7.TabIndex = 8;
            this.btn_Pick7.UseSelectable = true;
            this.btn_Pick7.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick7.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick8
            // 
            this.btn_Pick8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick8.Location = new System.Drawing.Point(65, 225);
            this.btn_Pick8.Name = "btn_Pick8";
            this.btn_Pick8.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick8.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick8.TabIndex = 7;
            this.btn_Pick8.UseSelectable = true;
            this.btn_Pick8.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick8.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick4
            // 
            this.btn_Pick4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick4.Location = new System.Drawing.Point(722, 64);
            this.btn_Pick4.Name = "btn_Pick4";
            this.btn_Pick4.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick4.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick4.TabIndex = 6;
            this.btn_Pick4.UseSelectable = true;
            this.btn_Pick4.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick4.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick3
            // 
            this.btn_Pick3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick3.Location = new System.Drawing.Point(503, 64);
            this.btn_Pick3.Name = "btn_Pick3";
            this.btn_Pick3.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick3.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick3.TabIndex = 5;
            this.btn_Pick3.UseSelectable = true;
            this.btn_Pick3.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick3.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick2
            // 
            this.btn_Pick2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick2.Location = new System.Drawing.Point(284, 64);
            this.btn_Pick2.Name = "btn_Pick2";
            this.btn_Pick2.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick2.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick2.TabIndex = 4;
            this.btn_Pick2.UseSelectable = true;
            this.btn_Pick2.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick2.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // btn_Pick1
            // 
            this.btn_Pick1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Pick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pick1.Location = new System.Drawing.Point(65, 64);
            this.btn_Pick1.Name = "btn_Pick1";
            this.btn_Pick1.Size = new System.Drawing.Size(161, 135);
            this.btn_Pick1.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Pick1.TabIndex = 3;
            this.btn_Pick1.UseSelectable = true;
            this.btn_Pick1.TextChanged += new System.EventHandler(this.btn_Pick_TextChanged);
            this.btn_Pick1.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1075, 47);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "방문할 지역을 선택하세요";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lbl_Tab2Title);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1075, 437);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lbl_Tab2Title
            // 
            this.lbl_Tab2Title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Tab2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Tab2Title.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Tab2Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Tab2Title.Name = "lbl_Tab2Title";
            this.lbl_Tab2Title.Size = new System.Drawing.Size(1075, 47);
            this.lbl_Tab2Title.TabIndex = 3;
            this.lbl_Tab2Title.Text = "여행일정 (2019,5555,5555)~(232323123)";
            this.lbl_Tab2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(173, 542);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(177, 46);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "초기화";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ShowSchdual
            // 
            this.btn_ShowSchdual.Enabled = false;
            this.btn_ShowSchdual.Location = new System.Drawing.Point(462, 544);
            this.btn_ShowSchdual.Name = "btn_ShowSchdual";
            this.btn_ShowSchdual.Size = new System.Drawing.Size(177, 42);
            this.btn_ShowSchdual.TabIndex = 5;
            this.btn_ShowSchdual.Text = "계획짜기";
            this.btn_ShowSchdual.UseSelectable = true;
            this.btn_ShowSchdual.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Img
            // 
            this.btn_Img.Enabled = false;
            this.btn_Img.Location = new System.Drawing.Point(751, 544);
            this.btn_Img.Name = "btn_Img";
            this.btn_Img.Size = new System.Drawing.Size(177, 42);
            this.btn_Img.TabIndex = 6;
            this.btn_Img.Text = "내보내보기";
            this.btn_Img.UseSelectable = true;
            this.btn_Img.Click += new System.EventHandler(this.btn_Img_Click);
            // 
            // FrmMySchdual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 626);
            this.Controls.Add(this.btn_Img);
            this.Controls.Add(this.btn_ShowSchdual);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmMySchdual";
            this.Text = "여행일정 만들기";
            this.Load += new System.EventHandler(this.FrmMySchdual_Load);
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.grup_Goday.ResumeLayout(false);
            this.grup_Tick.ResumeLayout(false);
            this.grup_Tick.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
 
        private System.Windows.Forms.GroupBox grup_Tick;
        private System.Windows.Forms.GroupBox grup_Goday;
        private MetroFramework.Controls.MetroRadioButton rbo_Rail_5;
        private MetroFramework.Controls.MetroRadioButton rbo_Rail_3;
        private MetroFramework.Controls.MetroRadioButton rbo_Hana_3;
        private MetroFramework.Controls.MetroRadioButton rbo_Rail_7;
        private MetroFramework.Controls.MetroDateTime dateTime_Start;
        private MetroFramework.Controls.MetroDateTime dateTime_End;
        private MetroFramework.Controls.MetroButton btn_ShowSchdual;
        private MetroFramework.Controls.MetroButton btn_Clear;
        private System.Windows.Forms.Label lbl_Title;
        private MetroFramework.Controls.MetroButton btn_Pick1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_Pick5;
        private MetroFramework.Controls.MetroButton btn_Pick6;
        private MetroFramework.Controls.MetroButton btn_Pick7;
        private MetroFramework.Controls.MetroButton btn_Pick8;
        private MetroFramework.Controls.MetroButton btn_Pick4;
        private MetroFramework.Controls.MetroButton btn_Pick3;
        private MetroFramework.Controls.MetroButton btn_Pick2;
        private MetroFramework.Controls.MetroButton btn_Img;
        private System.Windows.Forms.Label lbl_Tab2Title;
    }
}