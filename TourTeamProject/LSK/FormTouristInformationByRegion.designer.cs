namespace TourTeamProject
{
    partial class FormTouristInformationByRegion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbService1 = new System.Windows.Forms.ComboBox();
            this.CmbRegion1 = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbService2 = new System.Windows.Forms.ComboBox();
            this.CmbService3 = new System.Windows.Forms.ComboBox();
            this.CmbRegion2 = new System.Windows.Forms.ComboBox();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "관광타입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "서비스분류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "지역";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "검색";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "타입선택",
            "관광지",
            "문화시설",
            "축제공연행사",
            "여행코스",
            "레포츠",
            "숙박",
            "쇼핑",
            "음식점"});
            this.CmbType.Location = new System.Drawing.Point(156, 65);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(170, 20);
            this.CmbType.TabIndex = 4;
            this.CmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // CmbService1
            // 
            this.CmbService1.FormattingEnabled = true;
            this.CmbService1.Location = new System.Drawing.Point(156, 99);
            this.CmbService1.Name = "CmbService1";
            this.CmbService1.Size = new System.Drawing.Size(170, 20);
            this.CmbService1.TabIndex = 5;
            this.CmbService1.SelectedIndexChanged += new System.EventHandler(this.CmbService1_SelectedIndexChanged);
            // 
            // CmbRegion1
            // 
            this.CmbRegion1.FormattingEnabled = true;
            this.CmbRegion1.Items.AddRange(new object[] {
            "지역선택",
            "서울",
            "인천",
            "대전",
            "대구",
            "광주",
            "부산",
            "울산",
            "세종특별자치시",
            "경기도",
            "강원도",
            "충청북도",
            "충청남도",
            "경상북도",
            "경상남도",
            "전라북도",
            "전라남도",
            "제주도"});
            this.CmbRegion1.Location = new System.Drawing.Point(156, 133);
            this.CmbRegion1.Name = "CmbRegion1";
            this.CmbRegion1.Size = new System.Drawing.Size(170, 20);
            this.CmbRegion1.TabIndex = 8;
            this.CmbRegion1.SelectedIndexChanged += new System.EventHandler(this.CmbRegion1_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(156, 172);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CmbService2
            // 
            this.CmbService2.Enabled = false;
            this.CmbService2.FormattingEnabled = true;
            this.CmbService2.Location = new System.Drawing.Point(370, 99);
            this.CmbService2.Name = "CmbService2";
            this.CmbService2.Size = new System.Drawing.Size(170, 20);
            this.CmbService2.TabIndex = 6;
            this.CmbService2.SelectedIndexChanged += new System.EventHandler(this.CmbService2_SelectedIndexChanged);
            // 
            // CmbService3
            // 
            this.CmbService3.Enabled = false;
            this.CmbService3.FormattingEnabled = true;
            this.CmbService3.Location = new System.Drawing.Point(583, 99);
            this.CmbService3.Name = "CmbService3";
            this.CmbService3.Size = new System.Drawing.Size(170, 20);
            this.CmbService3.TabIndex = 7;
            this.CmbService3.SelectedIndexChanged += new System.EventHandler(this.CmbService3_SelectedIndexChanged);
            // 
            // CmbRegion2
            // 
            this.CmbRegion2.Enabled = false;
            this.CmbRegion2.FormattingEnabled = true;
            this.CmbRegion2.Location = new System.Drawing.Point(370, 133);
            this.CmbRegion2.Name = "CmbRegion2";
            this.CmbRegion2.Size = new System.Drawing.Size(170, 20);
            this.CmbRegion2.TabIndex = 9;
            this.CmbRegion2.SelectedIndexChanged += new System.EventHandler(this.CmbRegion2_SelectedIndexChanged);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(260, 700);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(97, 23);
            this.BtnPrev.TabIndex = 13;
            this.BtnPrev.Text = "이전 페이지";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(584, 700);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(97, 23);
            this.BtnNext.TabIndex = 14;
            this.BtnNext.Text = "다음 페이지";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(23, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(913, 482);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FormTouristInformationByRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 736);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.CmbRegion2);
            this.Controls.Add(this.CmbRegion1);
            this.Controls.Add(this.CmbService3);
            this.Controls.Add(this.CmbService2);
            this.Controls.Add(this.CmbService1);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTouristInformationByRegion";
            this.Text = "지역별 관광정보";
            this.Load += new System.EventHandler(this.FormTouristInformationByRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbService1;
        private System.Windows.Forms.ComboBox CmbRegion1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CmbService2;
        private System.Windows.Forms.ComboBox CmbService3;
        private System.Windows.Forms.ComboBox CmbRegion2;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
    }
}