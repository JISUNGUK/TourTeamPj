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
            this.btn_Region = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_SerchMap = new System.Windows.Forms.Button();
            this.btn_RecommandPlace = new System.Windows.Forms.Button();
            this.btn_Epillogue = new System.Windows.Forms.Button();
            this.btn_MySchduel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_Region
            // 
            this.btn_Region.Location = new System.Drawing.Point(12, 118);
            this.btn_Region.Name = "btn_Region";
            this.btn_Region.Size = new System.Drawing.Size(313, 146);
            this.btn_Region.TabIndex = 0;
            this.btn_Region.Text = "지역별 관광정보";
            this.btn_Region.UseVisualStyleBackColor = true;
            this.btn_Region.Click += new System.EventHandler(this.btn_Region_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(331, 118);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(308, 146);
            this.btn_Total.TabIndex = 1;
            this.btn_Total.Text = "통합검색";
            this.btn_Total.UseVisualStyleBackColor = true;
            // 
            // btn_SerchMap
            // 
            this.btn_SerchMap.Location = new System.Drawing.Point(12, 270);
            this.btn_SerchMap.Name = "btn_SerchMap";
            this.btn_SerchMap.Size = new System.Drawing.Size(205, 146);
            this.btn_SerchMap.TabIndex = 3;
            this.btn_SerchMap.Text = "내주변 검색";
            this.btn_SerchMap.UseVisualStyleBackColor = true;
            this.btn_SerchMap.Click += new System.EventHandler(this.btn_SerchMap_Click);
            // 
            // btn_RecommandPlace
            // 
            this.btn_RecommandPlace.Location = new System.Drawing.Point(223, 270);
            this.btn_RecommandPlace.Name = "btn_RecommandPlace";
            this.btn_RecommandPlace.Size = new System.Drawing.Size(205, 146);
            this.btn_RecommandPlace.TabIndex = 4;
            this.btn_RecommandPlace.Text = "추천여행지";
            this.btn_RecommandPlace.UseVisualStyleBackColor = true;
            // 
            // btn_Epillogue
            // 
            this.btn_Epillogue.Location = new System.Drawing.Point(434, 270);
            this.btn_Epillogue.Name = "btn_Epillogue";
            this.btn_Epillogue.Size = new System.Drawing.Size(205, 146);
            this.btn_Epillogue.TabIndex = 5;
            this.btn_Epillogue.Text = "내일로 후기";
            this.btn_Epillogue.UseVisualStyleBackColor = true;
            this.btn_Epillogue.Click += new System.EventHandler(this.btn_Epillogue_Click);
            // 
            // btn_MySchduel
            // 
            this.btn_MySchduel.Location = new System.Drawing.Point(223, 422);
            this.btn_MySchduel.Name = "btn_MySchduel";
            this.btn_MySchduel.Size = new System.Drawing.Size(205, 146);
            this.btn_MySchduel.TabIndex = 7;
            this.btn_MySchduel.Text = "나만의 여행일정 만들기";
            this.btn_MySchduel.UseVisualStyleBackColor = true;
            this.btn_MySchduel.Click += new System.EventHandler(this.btn_MySchduel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
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
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(658, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MySchduel);
            this.Controls.Add(this.btn_Epillogue);
            this.Controls.Add(this.btn_RecommandPlace);
            this.Controls.Add(this.btn_SerchMap);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.btn_Region);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "박스접는상권";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Region;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_SerchMap;
        private System.Windows.Forms.Button btn_RecommandPlace;
        private System.Windows.Forms.Button btn_Epillogue;
        private System.Windows.Forms.Button btn_MySchduel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

