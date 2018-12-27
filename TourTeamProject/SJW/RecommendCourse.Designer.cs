namespace TourTeamProject
{
    partial class RecommendCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TasteCouse = new MetroFramework.Controls.MetroRadioButton();
            this.campingCouse = new MetroFramework.Controls.MetroRadioButton();
            this.walkingCourse = new MetroFramework.Controls.MetroRadioButton();
            this.radioHealing = new MetroFramework.Controls.MetroRadioButton();
            this.aloneCourse = new MetroFramework.Controls.MetroRadioButton();
            this.radioFamily = new MetroFramework.Controls.MetroRadioButton();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RowNum = new MetroFramework.Controls.MetroComboBox();
            this.btnLast = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.pageNum = new MetroFramework.Controls.MetroLabel();
            this.totalpgNum = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.currentPage = new MetroFramework.Controls.MetroLabel();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnFirst = new MetroFramework.Controls.MetroButton();
            this.dv_Place = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "추천여행 코스";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TasteCouse);
            this.groupBox1.Controls.Add(this.campingCouse);
            this.groupBox1.Controls.Add(this.walkingCourse);
            this.groupBox1.Controls.Add(this.radioHealing);
            this.groupBox1.Controls.Add(this.aloneCourse);
            this.groupBox1.Controls.Add(this.radioFamily);
            this.groupBox1.Location = new System.Drawing.Point(260, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(299, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "코스목록";
            // 
            // TasteCouse
            // 
            this.TasteCouse.AutoSize = true;
            this.TasteCouse.Location = new System.Drawing.Point(218, 93);
            this.TasteCouse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TasteCouse.Name = "TasteCouse";
            this.TasteCouse.Size = new System.Drawing.Size(59, 15);
            this.TasteCouse.TabIndex = 10;
            this.TasteCouse.TabStop = true;
            this.TasteCouse.Text = "맛코스";
            this.TasteCouse.UseSelectable = true;
            this.TasteCouse.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // campingCouse
            // 
            this.campingCouse.AutoSize = true;
            this.campingCouse.Location = new System.Drawing.Point(108, 93);
            this.campingCouse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.campingCouse.Name = "campingCouse";
            this.campingCouse.Size = new System.Drawing.Size(71, 15);
            this.campingCouse.TabIndex = 11;
            this.campingCouse.TabStop = true;
            this.campingCouse.Text = "캠핑코스";
            this.campingCouse.UseSelectable = true;
            this.campingCouse.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // walkingCourse
            // 
            this.walkingCourse.AutoSize = true;
            this.walkingCourse.Location = new System.Drawing.Point(12, 93);
            this.walkingCourse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.walkingCourse.Name = "walkingCourse";
            this.walkingCourse.Size = new System.Drawing.Size(71, 15);
            this.walkingCourse.TabIndex = 12;
            this.walkingCourse.TabStop = true;
            this.walkingCourse.Text = "도보코스";
            this.walkingCourse.UseSelectable = true;
            // 
            // radioHealing
            // 
            this.radioHealing.AutoSize = true;
            this.radioHealing.Location = new System.Drawing.Point(218, 41);
            this.radioHealing.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioHealing.Name = "radioHealing";
            this.radioHealing.Size = new System.Drawing.Size(71, 15);
            this.radioHealing.TabIndex = 9;
            this.radioHealing.TabStop = true;
            this.radioHealing.Text = "힐링코스";
            this.radioHealing.UseSelectable = true;
            // 
            // aloneCourse
            // 
            this.aloneCourse.AutoSize = true;
            this.aloneCourse.Location = new System.Drawing.Point(108, 41);
            this.aloneCourse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.aloneCourse.Name = "aloneCourse";
            this.aloneCourse.Size = new System.Drawing.Size(83, 15);
            this.aloneCourse.TabIndex = 8;
            this.aloneCourse.TabStop = true;
            this.aloneCourse.Text = "나홀로코스";
            this.aloneCourse.UseSelectable = true;
            this.aloneCourse.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // radioFamily
            // 
            this.radioFamily.AutoSize = true;
            this.radioFamily.Checked = true;
            this.radioFamily.Location = new System.Drawing.Point(12, 41);
            this.radioFamily.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioFamily.Name = "radioFamily";
            this.radioFamily.Size = new System.Drawing.Size(71, 15);
            this.radioFamily.TabIndex = 7;
            this.radioFamily.TabStop = true;
            this.radioFamily.Text = "가족코스";
            this.radioFamily.UseSelectable = true;
            this.radioFamily.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(6, 88);
            this.searchKeyword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(191, 23);
            this.searchKeyword.TabIndex = 2;
            this.searchKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchKeyword_KeyUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(37, 115);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RowNum);
            this.splitContainer1.Panel1.Controls.Add(this.btnLast);
            this.splitContainer1.Panel1.Controls.Add(this.btnNext);
            this.splitContainer1.Panel1.Controls.Add(this.pageNum);
            this.splitContainer1.Panel1.Controls.Add(this.totalpgNum);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.currentPage);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreview);
            this.splitContainer1.Panel1.Controls.Add(this.btnFirst);
            this.splitContainer1.Panel1.Controls.Add(this.searchKeyword);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dv_Place);
            this.splitContainer1.Size = new System.Drawing.Size(662, 431);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // RowNum
            // 
            this.RowNum.FormattingEnabled = true;
            this.RowNum.ItemHeight = 23;
            this.RowNum.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.RowNum.Location = new System.Drawing.Point(131, 47);
            this.RowNum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RowNum.Name = "RowNum";
            this.RowNum.Size = new System.Drawing.Size(95, 29);
            this.RowNum.TabIndex = 7;
            this.RowNum.UseSelectable = true;
            this.RowNum.SelectedIndexChanged += new System.EventHandler(this.RowNum_SelectedIndexChanged);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(155, 110);
            this.btnLast.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(42, 44);
            this.btnLast.Style = MetroFramework.MetroColorStyle.White;
            this.btnLast.TabIndex = 48;
            this.btnLast.Text = "끝";
            this.btnLast.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLast.UseSelectable = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(108, 110);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 44);
            this.btnNext.Style = MetroFramework.MetroColorStyle.White;
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "다음";
            this.btnNext.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pageNum
            // 
            this.pageNum.AutoSize = true;
            this.pageNum.Location = new System.Drawing.Point(489, 28);
            this.pageNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(72, 19);
            this.pageNum.TabIndex = 53;
            this.pageNum.Text = "검색 건수:";
            // 
            // totalpgNum
            // 
            this.totalpgNum.AutoSize = true;
            this.totalpgNum.Location = new System.Drawing.Point(489, 9);
            this.totalpgNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalpgNum.Name = "totalpgNum";
            this.totalpgNum.Size = new System.Drawing.Size(72, 19);
            this.totalpgNum.TabIndex = 52;
            this.totalpgNum.Text = "전체 쪽수:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(209, 88);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 41);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // currentPage
            // 
            this.currentPage.AutoSize = true;
            this.currentPage.Location = new System.Drawing.Point(489, 47);
            this.currentPage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(58, 19);
            this.currentPage.TabIndex = 51;
            this.currentPage.Text = "현재 쪽:";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(64, 110);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(46, 44);
            this.btnPreview.Style = MetroFramework.MetroColorStyle.White;
            this.btnPreview.TabIndex = 47;
            this.btnPreview.Text = "이전";
            this.btnPreview.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPreview.UseSelectable = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(6, 110);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(57, 44);
            this.btnFirst.Style = MetroFramework.MetroColorStyle.White;
            this.btnFirst.TabIndex = 45;
            this.btnFirst.Text = "처음";
            this.btnFirst.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnFirst.UseSelectable = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dv_Place
            // 
            this.dv_Place.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.dv_Place.AllowUserToAddRows = false;
            this.dv_Place.AllowUserToDeleteRows = false;
            this.dv_Place.AllowUserToResizeColumns = false;
            this.dv_Place.AllowUserToResizeRows = false;
            this.dv_Place.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dv_Place.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dv_Place.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dv_Place.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_Place.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dv_Place.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv_Place.DefaultCellStyle = dataGridViewCellStyle2;
            this.dv_Place.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_Place.EnableHeadersVisualStyles = false;
            this.dv_Place.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dv_Place.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dv_Place.Location = new System.Drawing.Point(0, 0);
            this.dv_Place.Margin = new System.Windows.Forms.Padding(5);
            this.dv_Place.Name = "dv_Place";
            this.dv_Place.ReadOnly = true;
            this.dv_Place.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_Place.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dv_Place.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dv_Place.RowTemplate.Height = 23;
            this.dv_Place.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dv_Place.ShowCellErrors = false;
            this.dv_Place.ShowRowErrors = false;
            this.dv_Place.Size = new System.Drawing.Size(662, 237);
            this.dv_Place.Style = MetroFramework.MetroColorStyle.Blue;
            this.dv_Place.TabIndex = 9;
            this.dv_Place.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_Place_CellClick);
            // 
            // RecommendCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 584);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("굴림", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RecommendCourse";
            this.Padding = new System.Windows.Forms.Padding(37, 115, 37, 38);
            this.Text = "추천코스";
            this.Load += new System.EventHandler(this.RecommendCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroRadioButton TasteCouse;
        private MetroFramework.Controls.MetroRadioButton campingCouse;
        private MetroFramework.Controls.MetroRadioButton walkingCourse;
        private MetroFramework.Controls.MetroRadioButton radioHealing;
        private MetroFramework.Controls.MetroRadioButton aloneCourse;
        private MetroFramework.Controls.MetroRadioButton radioFamily;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroButton btnFirst;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroComboBox RowNum;
        private MetroFramework.Controls.MetroButton btnLast;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroLabel pageNum;
        private MetroFramework.Controls.MetroLabel totalpgNum;
        private MetroFramework.Controls.MetroLabel currentPage;
        private MetroFramework.Controls.MetroGrid dv_Place;
    }
}