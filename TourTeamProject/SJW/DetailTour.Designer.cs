namespace TourTeamProject
{
    partial class DetailTour
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
            this.result = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.addrLabel = new System.Windows.Forms.Label();
            this.PlacePIc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlacePIc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.Location = new System.Drawing.Point(31, 442);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(663, 335);
            this.result.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("휴먼고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(26, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 28);
            this.Title.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY견고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(36, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "개요";
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PostLabel.Location = new System.Drawing.Point(469, 76);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(186, 37);
            this.PostLabel.TabIndex = 5;
            this.PostLabel.Text = "우편번호:없음";
            this.PostLabel.Click += new System.EventHandler(this.addrLabel_Click);
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrLabel.Location = new System.Drawing.Point(469, 211);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(132, 37);
            this.addrLabel.TabIndex = 6;
            this.addrLabel.Text = "주소:없음";
            this.addrLabel.Click += new System.EventHandler(this.addrLabel_Click);
            // 
            // PlacePIc
            // 
            this.PlacePIc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlacePIc.Image = global::TourTeamProject.Properties.Resources.no_detail_img;
            this.PlacePIc.Location = new System.Drawing.Point(31, 76);
            this.PlacePIc.Name = "PlacePIc";
            this.PlacePIc.Size = new System.Drawing.Size(432, 335);
            this.PlacePIc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlacePIc.TabIndex = 3;
            this.PlacePIc.TabStop = false;
            // 
            // DetailTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(721, 737);
            this.Controls.Add(this.addrLabel);
            this.Controls.Add(this.PostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlacePIc);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DetailTour";
            this.Load += new System.EventHandler(this.DetailTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlacePIc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox PlacePIc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label addrLabel;
    }
}