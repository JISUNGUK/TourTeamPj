using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTeamProject
{
    public partial class newControl : UserControl
    {
        public newControl()
        {
            InitializeComponent();
        }
        public newControl(string title)
        {
            InitializeComponent();
            lbl_Title.Text = title;
        }

        private void btn_benefit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.lbl_Title.Text);
        }

        /// <summary>
        /// 상권이 폼에 매개변수 주어서 검색하도록
        /// </summary>
        private void btn_TourInfo_Click(object sender, EventArgs e)
        {
            FormTouristInformationByRegion ftb = new FormTouristInformationByRegion();
            ftb.Show();
        }
        private void btn_Fastival_Click(object sender, EventArgs e)
        {
            FormTouristInformationByRegion ftb = new FormTouristInformationByRegion();
            ftb.Show();

        }
    }
}
