using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTeamProject
{
    public partial class FrmInfo : MetroFramework.Forms.MetroForm
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("지성욱");
            sb.AppendLine("이상권");
            sb.AppendLine("손종완");
            sb.AppendLine("\t\t2018.12.23");

            this.label1.Text = sb.ToString();
        }
    }
}
