namespace TourTeamProject
{
    partial class Apilogue
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblBloggerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblTitle.Location = new System.Drawing.Point(15, 23);
            this.LblTitle.MaximumSize = new System.Drawing.Size(234, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(61, 19);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "label1";
            // 
            // LblBloggerName
            // 
            this.LblBloggerName.AutoSize = true;
            this.LblBloggerName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblBloggerName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblBloggerName.Location = new System.Drawing.Point(15, 120);
            this.LblBloggerName.MaximumSize = new System.Drawing.Size(254, 0);
            this.LblBloggerName.Name = "LblBloggerName";
            this.LblBloggerName.Size = new System.Drawing.Size(44, 13);
            this.LblBloggerName.TabIndex = 1;
            this.LblBloggerName.Text = "label2";
            // 
            // Apilogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LblBloggerName);
            this.Controls.Add(this.LblTitle);
            this.Name = "Apilogue";
            this.Size = new System.Drawing.Size(271, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label LblTitle;
        internal System.Windows.Forms.Label LblBloggerName;
    }
}
