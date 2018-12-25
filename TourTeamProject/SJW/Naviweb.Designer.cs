namespace TourTeamProject
{
    partial class Naviweb
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
            this.webView1 = new EO.WebBrowser.WebView();
            this.webControl1 = new EO.WinForm.WebControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.latitudeText = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.searchKeyword = new System.Windows.Forms.TextBox();
            this.webPage = new EO.WinForm.WebControl();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.ObjectForScripting = null;
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(31, 105);
            this.webControl1.Margin = new System.Windows.Forms.Padding(5);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(1876, 648);
            this.webControl1.TabIndex = 0;
            this.webControl1.Text = "webControl1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(31, 105);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroButton1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.latitudeText);
            this.splitContainer1.Panel1.Controls.Add(this.btnForward);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.searchKeyword);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webPage);
            this.splitContainer1.Size = new System.Drawing.Size(1876, 648);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1279, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "위도경도";
            // 
            // latitudeText
            // 
            this.latitudeText.Location = new System.Drawing.Point(1372, 5);
            this.latitudeText.Margin = new System.Windows.Forms.Padding(5);
            this.latitudeText.Multiline = true;
            this.latitudeText.Name = "latitudeText";
            this.latitudeText.Size = new System.Drawing.Size(339, 55);
            this.latitudeText.TabIndex = 3;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.White;
            this.btnForward.Enabled = false;
            this.btnForward.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnForward.ForeColor = System.Drawing.Color.Blue;
            this.btnForward.Location = new System.Drawing.Point(157, 9);
            this.btnForward.Margin = new System.Windows.Forms.Padding(5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(118, 58);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(6, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 58);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // searchKeyword
            // 
            this.searchKeyword.Location = new System.Drawing.Point(284, 7);
            this.searchKeyword.Margin = new System.Windows.Forms.Padding(5);
            this.searchKeyword.Multiline = true;
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Size = new System.Drawing.Size(966, 56);
            this.searchKeyword.TabIndex = 0;
            this.searchKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // webPage
            // 
            this.webPage.BackColor = System.Drawing.Color.White;
            this.webPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPage.Location = new System.Drawing.Point(0, 0);
            this.webPage.Margin = new System.Windows.Forms.Padding(5);
            this.webPage.Name = "webPage";
            this.webPage.Size = new System.Drawing.Size(1876, 584);
            this.webPage.TabIndex = 0;
            this.webPage.Text = "webControl2";
            this.webPage.WebView = this.webView1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1711, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(165, 50);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "주변검색";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Naviweb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 788);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.webControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Naviweb";
            this.Padding = new System.Windows.Forms.Padding(31, 105, 31, 35);
            this.Text = "지도검색";
            this.Load += new System.EventHandler(this.Naviweb_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WebView webView1;
        private EO.WinForm.WebControl webControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox searchKeyword;
        private EO.WinForm.WebControl webPage;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox latitudeText;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}