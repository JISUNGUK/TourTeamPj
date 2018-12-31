namespace TourTeamProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TourSystem";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.pictureBox1);
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroTile1.Location = new System.Drawing.Point(-5, 105);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(337, 86);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "지역관광정보";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TourTeamProject.Properties.Resources.다운로드;
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroTile2.Location = new System.Drawing.Point(20, 206);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(312, 75);
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "통합검색";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroTile3.Location = new System.Drawing.Point(20, 302);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(312, 75);
            this.metroTile3.TabIndex = 15;
            this.metroTile3.Text = "추천코스";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroTile4.Location = new System.Drawing.Point(20, 397);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(312, 75);
            this.metroTile4.TabIndex = 17;
            this.metroTile4.Text = "내주변엔";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroTile5.Location = new System.Drawing.Point(20, 491);
            this.metroTile5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(312, 75);
            this.metroTile5.TabIndex = 19;
            this.metroTile5.Text = "여행일정";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroTile6.Location = new System.Drawing.Point(20, 582);
            this.metroTile6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(312, 75);
            this.metroTile6.TabIndex = 21;
            this.metroTile6.Text = "여행후기";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.UseCustomBackColor = true;
            this.metroTile6.UseCustomForeColor = true;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::TourTeamProject.Properties.Resources.chat_comment_feedback_review_512;
            this.pictureBox6.Location = new System.Drawing.Point(20, 582);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(102, 69);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = global::TourTeamProject.Properties.Resources.calendar_1559935_960_720;
            this.pictureBox5.Location = new System.Drawing.Point(20, 497);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(102, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::TourTeamProject.Properties.Resources.location2_512;
            this.pictureBox4.Location = new System.Drawing.Point(20, 403);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::TourTeamProject.Properties.Resources.img_320735;
            this.pictureBox3.Location = new System.Drawing.Point(20, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::TourTeamProject.Properties.Resources._47px_Search_Noun_project_15028_svg;
            this.pictureBox2.Location = new System.Drawing.Point(20, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TourTeamProject.Properties.Resources._55856_79175_443;
            this.pictureBox7.Location = new System.Drawing.Point(253, 34);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(716, 617);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::TourTeamProject.Properties.Resources._55856_79175_443;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(970, 657);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Text = "집에서 떠나요~~";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

