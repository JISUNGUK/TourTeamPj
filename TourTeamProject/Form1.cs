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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        #region 서버스트링 부분 severStr보고 알아서 붙여 쓸것!
        //string severStr = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/locationBasedList";
        //string serviceKey =
        //    "?ServiceKey=" + "es9jiHOYsOYG9C2%2BzmyeSFxtnzPNcWqLMis2T6Ol2mU1rXVIUntZUjLnFo6W%2B5dKu3den7QwTLrY%2FSTg%2Fa%2F%2BCQ%3D%3D";
        //string contentTypeId = "&contentTypeId=" + "&mapX=126.981106&mapY=37.568477";
        //string radius = "&radius=" + "2000";
        //string listYN = "&listYN=" + "Y";
        //string mobileOs = "&MobileOS=" + "ETC";
        //string MobileApp = "&MobileApp=" + "TourAPI3.0_Guide";
        //string arrang = "&arrange=" + "A";                  //  정렬구분 a:제목순 b:조회순 c:수정일 d:생성일순
        //string numofRows = "&numOfRows" + "12";
        //string pageNo = "&pageNo=" + "3"; 
        #endregion

        int count = 0;
        string hi;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                hi = "안";
            else if (count == 2)
                hi += "녕";
            else if (count == 3)
                hi += "하";
            else if (count == 4)
                hi += "세";
            else if (count == 5)
                hi += "요";
            else if (count == 6) 
                count = 0;

            label1.Font = new Font("굴림", 20.5f);
            label1.Text = hi;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowIcon = false;
                notifyIcon1.Visible = true;
                
            }
            
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowIcon = true;
            notifyIcon1.Visible = false;
        }

        private void btn_SerchMap_Click(object sender, EventArgs e)
        {
            FrmMySpaceSearch from = new FrmMySpaceSearch();
            from.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MySchduel_Click(object sender, EventArgs e)
        {
            FrmMySchdual from = new FrmMySchdual();
            from.ShowDialog();
        }

        private void btn_Region_Click(object sender, EventArgs e)
        {
            FormTouristInformationByRegion ftbr = new FormTouristInformationByRegion();
            ftbr.ShowDialog();
        }

        private void btn_Epillogue_Click(object sender, EventArgs e)
        {
            FormApilogue fa = new FormApilogue();
            fa.ShowDialog();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            IntegratedSearch ITS = new IntegratedSearch();
            ITS.Show();
        }

        private void btn_RecommandPlace_Click(object sender, EventArgs e)
        {
            RecommendCourse rcs = new RecommendCourse();
            rcs.Show();

        }



        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((ToolStripMenuItem)sender).Text);
            if (((ToolStripMenuItem)sender).Text=="열기")
            {
                notifyIcon1_MouseDoubleClick(null, null);
            }
            else if (((ToolStripMenuItem)sender).Text == "프로그램정보")
            {
                FrmInfo form = new FrmInfo();
                form.Show();
            }
            else if(((ToolStripMenuItem)sender).Text == "종료")
            {
                Application.Exit();
            }

        }
    }
}
