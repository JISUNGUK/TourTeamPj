using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TourTeamProject
{
    public partial class RecommendCourse : MetroForm
    {
        List<TourSearchResult> TourLIST = new List<TourSearchResult>();
        string apiurl = "http://api.visitkorea.or.kr/openapi/service/rest/";
        string language = "KorService";
        string languageAfter = "/searchKeyword?ServiceKey=7V8bwwI0r4itRyj%2BK9kCFfFaFV5sv7alU9slMR%2FGEbZBiRwf1lkOkEq%2Fn0eR%2FXwckcRZq2xCyV4nnbYzzaGYRg%3D%3D&keyword=";
        string afterurl = "&areaCode=&sigunguCode=&cat1=";
        string cat1 = "C01";
        string cat2w = "&cat2=";
        string cat2 = "C0112";
        string cat3w = "&cat3=";
        string cat3 = "C01120001";
        string lasturi = "&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&arrange=A&_type=json";
        string numofRows = "&numOfRows=";
        int numRow = 12;
        string numpage = "&pageNo=";
        int pageNo = 1;

        WebRequest hw;
        WebResponse hr;
        StreamReader sr;
        IntegratedSearch IR;//통합검색의 클래스를 사용!!

        public string Language { get => language; set => language = value; }

        public RecommendCourse()
        {
            InitializeComponent();
        }


        private void RecommendCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pageNo = 1;
            DisplayResult();

        }

        private void DisplayResult()
        {
            string keyword = WebUtility.UrlEncode(searchKeyword.Text);
            string url = apiurl + language + languageAfter + keyword + afterurl + cat1 + cat2w + cat2 + cat3w + cat3 + lasturi + numofRows + numRow + numpage + pageNo;
            hw = (HttpWebRequest)WebRequest.Create(url);
            hr = (HttpWebResponse)hw.GetResponse();
            sr = new StreamReader(hr.GetResponseStream());
            IR = new IntegratedSearch();
            IR.NumofRows = numRow;
            IR.PageCount = pageNo;
            IR.DisplayResult(dv_Place, sr.ReadToEnd());
            MessageBox.Show(sr.ReadToEnd());
            pageNum.Text = "검색건수:" + IR.TotalCount;
            currentPage.Text = "현재 쪽:" + IR.PageCount;
            pageNo = IR.PageCount;
            totalpgNum.Text = "전체 쪽수:" + IR.TotalPageNum;

            TourLIST = IR.TourList;




        }

        private void radioFamily_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFamily.Checked)
            {
                cat1 = "C01";
                cat2 = "C0112";
                cat3 = "C01120001";
            }
            else if (aloneCourse.Checked)
            {
                cat1 = "C01";
                cat2 = "C0113";
                cat3 = "C01130001";
            }
            else if (radioHealing.Checked)
            {
                cat1 = "C01";
                cat2 = "C0114";
                cat3 = "C01140001";
            }
            else if (walkingCourse.Checked)
            {
                cat1 = "C01";
                cat2 = "C0115";
                cat3 = "C01150001";
            }
            else if (campingCouse.Checked)
            {
                cat1 = "C01";
                cat2 = "C0116";
                cat3 = "C01160001";
            }
            else
            {
                cat1 = "C01";
                cat2 = "C0117";
                cat3 = "C01170001";
            }


        }

        private void Tourgridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (pageNo != 1)
            {
                pageNo = 1;
                currentPage.Text = "현재 쪽:" + pageNo;
                DisplayResult();
            }
            else
                MessageBox.Show("첫페이지입니다");


        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (pageNo > 1)
            {
                pageNo--;
                DisplayResult();
                currentPage.Text = "현재 쪽:" + pageNo;

            }
            else
                MessageBox.Show("첫페이지입니다");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNo < IR.TotalPageNum)
            {
                pageNo++;
                DisplayResult();
                currentPage.Text = "현재 쪽:" + pageNo;

            }
            else
                MessageBox.Show("마지막 페이지입니다");

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (pageNo != IR.TotalPageNum)
            {
                pageNo = IR.TotalPageNum;
                DisplayResult();
                currentPage.Text = "현재 쪽:" + pageNo;

            }
            else
                MessageBox.Show("더이상 페이지가 없습니다");

        }

        private void RowNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RowNum.SelectedIndex > -1)
            {
                numRow = Int32.Parse(RowNum.SelectedItem.ToString());
            }
        }

        private void searchKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pageNo = 1;
                DisplayResult();
            }
        }

        private void dv_Place_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dv_Place.CurrentRow.Index > -1)
            {
                string contentid = TourLIST[dv_Place.CurrentRow.Index].Contentid;
                string contentpid = TourLIST[dv_Place.CurrentRow.Index].Contenttypeid;

                DetailTour dt = new DetailTour();
                dt.Contentid = contentid;
                dt.Contentpid = contentpid;
                dt.Show();

            }

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
