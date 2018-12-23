namespace TourTeamProject
{
    partial class newControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fastival = new MetroFramework.Controls.MetroButton();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_TourInfo = new MetroFramework.Controls.MetroButton();
            this.photo = new System.Windows.Forms.PictureBox();
            this.btn_benefit = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_Fastival);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.btn_TourInfo);
            this.panel1.Controls.Add(this.photo);
            this.panel1.Controls.Add(this.btn_benefit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 120);
            this.panel1.TabIndex = 9;
            // 
            // btn_Fastival
            // 
            this.btn_Fastival.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Fastival.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Fastival.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Fastival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fastival.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Fastival.Location = new System.Drawing.Point(280, 71);
            this.btn_Fastival.Name = "btn_Fastival";
            this.btn_Fastival.Size = new System.Drawing.Size(68, 46);
            this.btn_Fastival.TabIndex = 7;
            this.btn_Fastival.Text = "축제정보";
            this.btn_Fastival.UseCustomBackColor = true;
            this.btn_Fastival.UseSelectable = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Title.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Title.Location = new System.Drawing.Point(136, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(176, 24);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Cousce 1 서울";
            // 
            // btn_TourInfo
            // 
            this.btn_TourInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TourInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TourInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TourInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TourInfo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_TourInfo.Location = new System.Drawing.Point(208, 71);
            this.btn_TourInfo.Name = "btn_TourInfo";
            this.btn_TourInfo.Size = new System.Drawing.Size(68, 46);
            this.btn_TourInfo.TabIndex = 6;
            this.btn_TourInfo.Text = "관광정보";
            this.btn_TourInfo.UseCustomBackColor = true;
            this.btn_TourInfo.UseSelectable = true;
            this.btn_TourInfo.Click += new System.EventHandler(this.btn_TourInfo_Click);
            // 
            // photo
            // 
            this.photo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.photo.Location = new System.Drawing.Point(0, 0);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(130, 120);
            this.photo.TabIndex = 3;
            this.photo.TabStop = false;
            // 
            // btn_benefit
            // 
            this.btn_benefit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_benefit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_benefit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_benefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_benefit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_benefit.Location = new System.Drawing.Point(136, 71);
            this.btn_benefit.Name = "btn_benefit";
            this.btn_benefit.Size = new System.Drawing.Size(68, 46);
            this.btn_benefit.TabIndex = 5;
            this.btn_benefit.Text = "방문혜택";
            this.btn_benefit.UseCustomBackColor = true;
            this.btn_benefit.UseSelectable = true;
            this.btn_benefit.Click += new System.EventHandler(this.btn_benefit_Click);
            // 
            // newControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "newControl";
            this.Size = new System.Drawing.Size(352, 120);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_Fastival;
        private System.Windows.Forms.Label lbl_Title;
        private MetroFramework.Controls.MetroButton btn_TourInfo;
        private System.Windows.Forms.PictureBox photo;
        private MetroFramework.Controls.MetroButton btn_benefit;
    }
}
