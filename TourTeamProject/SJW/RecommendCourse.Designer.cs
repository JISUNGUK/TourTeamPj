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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Tourgridview1 = new System.Windows.Forms.DataGridView();
            this.radioFamily = new MetroFramework.Controls.MetroRadioButton();
            this.aloneCourse = new MetroFramework.Controls.MetroRadioButton();
            this.radioHealing = new MetroFramework.Controls.MetroRadioButton();
            this.TasteCouse = new MetroFramework.Controls.MetroRadioButton();
            this.campingCouse = new MetroFramework.Controls.MetroRadioButton();
            this.walkingCourse = new MetroFramework.Controls.MetroRadioButton();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnFirst = new MetroFramework.Controls.MetroButton();
            this.totalpgNum = new MetroFramework.Controls.MetroLabel();
            this.currentPage = new MetroFramework.Controls.MetroLabel();
            this.pageNum = new MetroFramework.Controls.MetroLabel();
            this.btnLast = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.RowNum = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tourgridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 11);
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
            this.groupBox1.Location = new System.Drawing.Point(327, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "코스목록";
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(3, 46);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(234, 21);
            this.searchKeyword.TabIndex = 2;
            this.searchKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchKeyword_KeyUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
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
            this.splitContainer1.Panel2.Controls.Add(this.Tourgridview1);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 571);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 7;
            // 
            // Tourgridview1
            // 
            this.Tourgridview1.AllowUserToAddRows = false;
            this.Tourgridview1.AllowUserToDeleteRows = false;
            this.Tourgridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tourgridview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tourgridview1.Location = new System.Drawing.Point(0, 0);
            this.Tourgridview1.Name = "Tourgridview1";
            this.Tourgridview1.RowTemplate.Height = 23;
            this.Tourgridview1.Size = new System.Drawing.Size(1097, 433);
            this.Tourgridview1.TabIndex = 6;
            this.Tourgridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tourgridview1_CellClick);
            // 
            // radioFamily
            // 
            this.radioFamily.AutoSize = true;
            this.radioFamily.Checked = true;
            this.radioFamily.Location = new System.Drawing.Point(26, 21);
            this.radioFamily.Name = "radioFamily";
            this.radioFamily.Size = new System.Drawing.Size(71, 15);
            this.radioFamily.TabIndex = 7;
            this.radioFamily.TabStop = true;
            this.radioFamily.Text = "가족코스";
            this.radioFamily.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // aloneCourse
            // 
            this.aloneCourse.AutoSize = true;
            this.aloneCourse.Location = new System.Drawing.Point(175, 20);
            this.aloneCourse.Name = "aloneCourse";
            this.aloneCourse.Size = new System.Drawing.Size(83, 15);
            this.aloneCourse.TabIndex = 8;
            this.aloneCourse.TabStop = true;
            this.aloneCourse.Text = "나홀로코스";
            this.aloneCourse.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // radioHealing
            // 
            this.radioHealing.AutoSize = true;
            this.radioHealing.Location = new System.Drawing.Point(335, 20);
            this.radioHealing.Name = "radioHealing";
            this.radioHealing.Size = new System.Drawing.Size(71, 15);
            this.radioHealing.TabIndex = 9;
            this.radioHealing.TabStop = true;
            this.radioHealing.Text = "힐링코스";
            // 
            // TasteCouse
            // 
            this.TasteCouse.AutoSize = true;
            this.TasteCouse.Location = new System.Drawing.Point(335, 52);
            this.TasteCouse.Name = "TasteCouse";
            this.TasteCouse.Size = new System.Drawing.Size(59, 15);
            this.TasteCouse.TabIndex = 10;
            this.TasteCouse.TabStop = true;
            this.TasteCouse.Text = "맛코스";
            this.TasteCouse.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // campingCouse
            // 
            this.campingCouse.AutoSize = true;
            this.campingCouse.Location = new System.Drawing.Point(175, 52);
            this.campingCouse.Name = "campingCouse";
            this.campingCouse.Size = new System.Drawing.Size(71, 15);
            this.campingCouse.TabIndex = 11;
            this.campingCouse.TabStop = true;
            this.campingCouse.Text = "캠핑코스";
            this.campingCouse.CheckedChanged += new System.EventHandler(this.radioFamily_CheckedChanged);
            // 
            // walkingCourse
            // 
            this.walkingCourse.AutoSize = true;
            this.walkingCourse.Location = new System.Drawing.Point(26, 52);
            this.walkingCourse.Name = "walkingCourse";
            this.walkingCourse.Size = new System.Drawing.Size(71, 15);
            this.walkingCourse.TabIndex = 12;
            this.walkingCourse.TabStop = true;
            this.walkingCourse.Text = "도보코스";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(81, 93);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.Style = MetroFramework.MetroColorStyle.White;
            this.btnPreview.TabIndex = 47;
            this.btnPreview.Text = "이전";
            this.btnPreview.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 93);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(72, 23);
            this.btnFirst.Style = MetroFramework.MetroColorStyle.White;
            this.btnFirst.TabIndex = 45;
            this.btnFirst.Text = "처음";
            this.btnFirst.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // totalpgNum
            // 
            this.totalpgNum.AutoSize = true;
            this.totalpgNum.Location = new System.Drawing.Point(564, 9);
            this.totalpgNum.Name = "totalpgNum";
            this.totalpgNum.Size = new System.Drawing.Size(72, 19);
            this.totalpgNum.TabIndex = 52;
            this.totalpgNum.Text = "전체 쪽수:";
            // 
            // currentPage
            // 
            this.currentPage.AutoSize = true;
            this.currentPage.Location = new System.Drawing.Point(469, 8);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(58, 19);
            this.currentPage.TabIndex = 51;
            this.currentPage.Text = "현재 쪽:";
            // 
            // pageNum
            // 
            this.pageNum.AutoSize = true;
            this.pageNum.Location = new System.Drawing.Point(673, 9);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(72, 19);
            this.pageNum.TabIndex = 53;
            this.pageNum.Text = "검색 건수:";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(243, 93);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.Style = MetroFramework.MetroColorStyle.White;
            this.btnLast.TabIndex = 48;
            this.btnLast.Text = "끝";
            this.btnLast.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(162, 93);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.Style = MetroFramework.MetroColorStyle.White;
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "다음";
            this.btnNext.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.RowNum.Location = new System.Drawing.Point(327, 8);
            this.RowNum.Name = "RowNum";
            this.RowNum.Size = new System.Drawing.Size(121, 29);
            this.RowNum.TabIndex = 7;
            this.RowNum.SelectedIndexChanged += new System.EventHandler(this.RowNum_SelectedIndexChanged);
            // 
            // RecommendCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 651);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RecommendCourse";
            this.Text = "맛코스";
            this.Load += new System.EventHandler(this.RecommendCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tourgridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Tourgridview1;
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
    }
}