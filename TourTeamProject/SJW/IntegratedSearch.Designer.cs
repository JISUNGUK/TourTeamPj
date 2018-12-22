﻿namespace TourTeamProject
{
    partial class IntegratedSearch
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnFirst = new MetroFramework.Controls.MetroButton();
            this.resultLbl = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.tourGridview = new System.Windows.Forms.DataGridView();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnLast = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.currentPage = new MetroFramework.Controls.MetroLabel();
            this.totalpgNum = new MetroFramework.Controls.MetroLabel();
            this.RowNum = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourGridview)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.totalpgNum);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.currentPage);
            this.splitContainer1.Panel1.Controls.Add(this.btnLast);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreview);
            this.splitContainer1.Panel1.Controls.Add(this.btnNext);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnFirst);
            this.splitContainer1.Panel1.Controls.Add(this.resultLbl);
            this.splitContainer1.Panel1.Controls.Add(this.searchResult);
            this.splitContainer1.Panel1.Controls.Add(this.searchKeyword);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tourGridview);
            this.splitContainer1.Size = new System.Drawing.Size(865, 439);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer1_Scroll);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(258, 47);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "이전";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(155, 47);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "처음";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(768, 55);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(57, 12);
            this.resultLbl.TabIndex = 40;
            this.resultLbl.Text = "검색건수:";
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(1025, -117);
            this.searchResult.Multiline = true;
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(33, 38);
            this.searchResult.TabIndex = 35;
            this.searchResult.Visible = false;
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(155, 25);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(384, 21);
            this.searchKeyword.TabIndex = 38;
            this.searchKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchKeyword_KeyUp);
            // 
            // tourGridview
            // 
            this.tourGridview.AllowUserToAddRows = false;
            this.tourGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourGridview.Location = new System.Drawing.Point(0, 0);
            this.tourGridview.Name = "tourGridview";
            this.tourGridview.ReadOnly = true;
            this.tourGridview.RowTemplate.Height = 23;
            this.tourGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tourGridview.Size = new System.Drawing.Size(865, 357);
            this.tourGridview.TabIndex = 0;
            this.tourGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourGridview_CellClick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(362, 47);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "다음";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(464, 47);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "끝";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "검색";
            // 
            // currentPage
            // 
            this.currentPage.AutoSize = true;
            this.currentPage.Location = new System.Drawing.Point(574, 51);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(58, 19);
            this.currentPage.TabIndex = 48;
            this.currentPage.Text = "현재 쪽:";
            // 
            // totalpgNum
            // 
            this.totalpgNum.AutoSize = true;
            this.totalpgNum.Location = new System.Drawing.Point(667, 51);
            this.totalpgNum.Name = "totalpgNum";
            this.totalpgNum.Size = new System.Drawing.Size(72, 19);
            this.totalpgNum.TabIndex = 49;
            this.totalpgNum.Text = "전체 쪽수:";
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
            this.RowNum.Location = new System.Drawing.Point(667, 23);
            this.RowNum.Name = "RowNum";
            this.RowNum.Size = new System.Drawing.Size(121, 29);
            this.RowNum.TabIndex = 1;
            this.RowNum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // IntegratedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 519);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IntegratedSearch";
            this.Text = "통합검색";
            this.Load += new System.EventHandler(this.IntegratedSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.DataGridView tourGridview;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnFirst;
        private MetroFramework.Controls.MetroComboBox RowNum;
        private MetroFramework.Controls.MetroLabel totalpgNum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel currentPage;
        private MetroFramework.Controls.MetroButton btnLast;
        private MetroFramework.Controls.MetroButton btnNext;
    }
}