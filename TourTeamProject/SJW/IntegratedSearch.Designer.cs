namespace TourTeamProject
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RowNum = new MetroFramework.Controls.MetroComboBox();
            this.totalpgNum = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.currentPage = new MetroFramework.Controls.MetroLabel();
            this.btnLast = new MetroFramework.Controls.MetroButton();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnFirst = new MetroFramework.Controls.MetroButton();
            this.resultLbl = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dv_Place = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.dv_Place);
            this.splitContainer1.Size = new System.Drawing.Size(824, 456);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer1_Scroll);
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
            this.RowNum.Location = new System.Drawing.Point(699, 46);
            this.RowNum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RowNum.Name = "RowNum";
            this.RowNum.Size = new System.Drawing.Size(92, 29);
            this.RowNum.TabIndex = 1;
            this.RowNum.UseSelectable = true;
            this.RowNum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // totalpgNum
            // 
            this.totalpgNum.AutoSize = true;
            this.totalpgNum.Location = new System.Drawing.Point(578, 90);
            this.totalpgNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalpgNum.Name = "totalpgNum";
            this.totalpgNum.Size = new System.Drawing.Size(72, 19);
            this.totalpgNum.TabIndex = 49;
            this.totalpgNum.Text = "전체 쪽수:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(106, 46);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "검색";
            // 
            // currentPage
            // 
            this.currentPage.AutoSize = true;
            this.currentPage.Location = new System.Drawing.Point(578, 44);
            this.currentPage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(58, 19);
            this.currentPage.TabIndex = 48;
            this.currentPage.Text = "현재 쪽:";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(424, 90);
            this.btnLast.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(55, 44);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "끝";
            this.btnLast.UseSelectable = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(249, 90);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(50, 44);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "이전";
            this.btnPreview.UseSelectable = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(335, 90);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 44);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "다음";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(505, 44);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(155, 90);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 44);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "처음";
            this.btnFirst.UseSelectable = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(577, 136);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(119, 24);
            this.resultLbl.TabIndex = 40;
            this.resultLbl.Text = "검색건수:";
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(1904, -225);
            this.searchResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchResult.Multiline = true;
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(58, 70);
            this.searchResult.TabIndex = 35;
            this.searchResult.Visible = false;
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(155, 46);
            this.searchKeyword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(324, 34);
            this.searchKeyword.TabIndex = 38;
            this.searchKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchKeyword_KeyUp);
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
            this.dv_Place.Size = new System.Drawing.Size(824, 249);
            this.dv_Place.Style = MetroFramework.MetroColorStyle.Blue;
            this.dv_Place.TabIndex = 10;
            this.dv_Place.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_Place_CellClick);
            // 
            // IntegratedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 609);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("굴림", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "IntegratedSearch";
            this.Padding = new System.Windows.Forms.Padding(37, 115, 37, 38);
            this.Text = "통합검색";
            this.Load += new System.EventHandler(this.IntegratedSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.TextBox searchKeyword;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnFirst;
        private MetroFramework.Controls.MetroComboBox RowNum;
        private MetroFramework.Controls.MetroLabel totalpgNum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel currentPage;
        private MetroFramework.Controls.MetroButton btnLast;
        private MetroFramework.Controls.MetroButton btnNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroGrid dv_Place;
    }
}