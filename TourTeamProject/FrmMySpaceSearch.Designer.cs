namespace TourTeamProject
{
    partial class FrmMySpaceSearch
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
            this.label3 = new System.Windows.Forms.Label();
            this.dv_Place2 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_PageInfo = new MetroFramework.Controls.MetroLabel();
            this.txt_Radius = new MetroFramework.Controls.MetroTextBox();
            this.txt_Point = new MetroFramework.Controls.MetroTextBox();
            this.btn_Search = new MetroFramework.Controls.MetroButton();
            this.btn_Next = new MetroFramework.Controls.MetroButton();
            this.btn_Prev = new MetroFramework.Controls.MetroButton();
            this.dv_Place = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "좌표 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "거리";
            // 
            // dv_Place2
            // 
            this.dv_Place2.AllowUserToAddRows = false;
            this.dv_Place2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_Place2.Location = new System.Drawing.Point(0, 322);
            this.dv_Place2.Name = "dv_Place2";
            this.dv_Place2.ReadOnly = true;
            this.dv_Place2.RowTemplate.Height = 23;
            this.dv_Place2.Size = new System.Drawing.Size(479, 251);
            this.dv_Place2.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(878, 7);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(269, 25);
            this.textBox4.TabIndex = 8;
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
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dv_Place);
            this.splitContainer1.Panel2.Controls.Add(this.dv_Place2);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 541);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbl_PageInfo);
            this.metroPanel1.Controls.Add(this.txt_Radius);
            this.metroPanel1.Controls.Add(this.textBox4);
            this.metroPanel1.Controls.Add(this.txt_Point);
            this.metroPanel1.Controls.Add(this.btn_Search);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.btn_Next);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.btn_Prev);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1168, 38);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_PageInfo
            // 
            this.lbl_PageInfo.AutoSize = true;
            this.lbl_PageInfo.Location = new System.Drawing.Point(771, 9);
            this.lbl_PageInfo.Name = "lbl_PageInfo";
            this.lbl_PageInfo.Size = new System.Drawing.Size(81, 19);
            this.lbl_PageInfo.TabIndex = 9;
            this.lbl_PageInfo.Text = "metroLabel1";
            // 
            // txt_Radius
            // 
            // 
            // 
            // 
            this.txt_Radius.CustomButton.Image = null;
            this.txt_Radius.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txt_Radius.CustomButton.Name = "";
            this.txt_Radius.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Radius.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Radius.CustomButton.TabIndex = 1;
            this.txt_Radius.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Radius.CustomButton.UseSelectable = true;
            this.txt_Radius.CustomButton.Visible = false;
            this.txt_Radius.Lines = new string[] {
        "2000"};
            this.txt_Radius.Location = new System.Drawing.Point(357, 9);
            this.txt_Radius.MaxLength = 32767;
            this.txt_Radius.Name = "txt_Radius";
            this.txt_Radius.PasswordChar = '\0';
            this.txt_Radius.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Radius.SelectedText = "";
            this.txt_Radius.SelectionLength = 0;
            this.txt_Radius.SelectionStart = 0;
            this.txt_Radius.ShortcutsEnabled = true;
            this.txt_Radius.Size = new System.Drawing.Size(100, 23);
            this.txt_Radius.TabIndex = 9;
            this.txt_Radius.Text = "2000";
            this.txt_Radius.UseSelectable = true;
            this.txt_Radius.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Radius.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Point
            // 
            // 
            // 
            // 
            this.txt_Point.CustomButton.Image = null;
            this.txt_Point.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txt_Point.CustomButton.Name = "";
            this.txt_Point.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Point.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Point.CustomButton.TabIndex = 1;
            this.txt_Point.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Point.CustomButton.UseSelectable = true;
            this.txt_Point.CustomButton.Visible = false;
            this.txt_Point.Lines = new string[0];
            this.txt_Point.Location = new System.Drawing.Point(59, 9);
            this.txt_Point.MaxLength = 32767;
            this.txt_Point.Name = "txt_Point";
            this.txt_Point.PasswordChar = '\0';
            this.txt_Point.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Point.SelectedText = "";
            this.txt_Point.SelectionLength = 0;
            this.txt_Point.SelectionStart = 0;
            this.txt_Point.ShortcutsEnabled = true;
            this.txt_Point.Size = new System.Drawing.Size(209, 23);
            this.txt_Point.TabIndex = 9;
            this.txt_Point.UseSelectable = true;
            this.txt_Point.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Point.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(510, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseSelectable = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(677, 9);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "앞으로";
            this.btn_Next.UseSelectable = true;
            this.btn_Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(596, 9);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Prev.TabIndex = 9;
            this.btn_Prev.Text = "뒤로";
            this.btn_Prev.UseSelectable = true;
            this.btn_Prev.Click += new System.EventHandler(this.button2_Click);
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
            this.dv_Place.EnableHeadersVisualStyles = false;
            this.dv_Place.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dv_Place.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dv_Place.Location = new System.Drawing.Point(0, 0);
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
            this.dv_Place.Size = new System.Drawing.Size(1168, 499);
            this.dv_Place.Style = MetroFramework.MetroColorStyle.Blue;
            this.dv_Place.TabIndex = 8;
            // 
            // FrmMySpaceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 621);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMySpaceSearch";
            this.Text = "내 주변 검색";
            this.Load += new System.EventHandler(this.FrmMySpaceSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Place)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dv_Place2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid dv_Place;
        private MetroFramework.Controls.MetroButton btn_Search;
        private MetroFramework.Controls.MetroTextBox txt_Point;
        private MetroFramework.Controls.MetroTextBox txt_Radius;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_PageInfo;
        private MetroFramework.Controls.MetroButton btn_Next;
        private MetroFramework.Controls.MetroButton btn_Prev;
    }
}