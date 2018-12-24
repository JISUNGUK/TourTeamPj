using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using EO.WebBrowser;

namespace TourTeamProject
{
    public partial class Naviweb : MetroFramework.Forms.MetroForm
    {
        NavigationTask nv;
        System.Windows.Forms.Timer tr;
        private string address;
        private string location;
        private string mapx;
        private string mapy;
        private string oldUrl="";
        public Naviweb()
        {
            InitializeComponent();
        }
        public string Address { get => address; set => address = value; }
        public string Location1 { get => location; set => location = value; }
        public string Mapx { get => mapx; set => mapx = value; }
        public string Mapy { get => mapy; set => mapy = value; }

        private void Naviweb_Load(object sender, EventArgs e)
        {
            tr = new System.Windows.Forms.Timer();
            
            tr.Tick += Tr_Tick;
            InitWebbrowser(address);
        }

        private void Tr_Tick(object sender, EventArgs e)
        {
            if(webView1.Url.Contains("/@")&&webView1.Url!=oldUrl)
                {
                searchKeyword.Text = webView1.Url;
                webPage.WebView = webView1;
                int latitude = searchKeyword.Text.IndexOf("/@");
                int altitude = searchKeyword.Text.IndexOf("z/");
                latitudeText.Text = searchKeyword.Text.Substring(latitude + 2, altitude - latitude - 1);
                location = latitudeText.Text;
                oldUrl = webView1.Url;
                tr.Enabled = false;
            }
        }

        /// <summary>
        /// 웹브라우저에 화면을 출력 url을 입력하면 해당 웹페이지로 이동함
        /// 구글맵을 사용시 www.google.co.kr/maps/search/검색어 형식으로 이용하고 해당 페이지의 url이 www.google.co.kr/maps/place/@위도,경도,z형식으로 나올때까지 기다렸다가 해당 내용이 나올때 location변수에 해당 위도,경도,z값을 저장함
        /// </summary>
        /// <param name="url"></param>
        public void InitWebbrowser(string url)
        {
            
            nv = webView1.LoadUrl("https://" + url);
            

             if (url.Contains("www.google.co.kr/maps/search"))
             {
                latitudeText.Text = "위도:" + mapx + "경도:" + mapy;
                
                webPage.WebView = webView1;
                searchKeyword.Text = url;
            }
             else
             {
                 webPage.WebView = webView1;
             }


            tr.Enabled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InitWebbrowser(searchKeyword.Text);
            }

            if (webView1.CanGoBack)
                btnBack.Enabled = true;
            else
                btnBack.Enabled = false;
            if (webView1.CanGoForward)
                btnForward.Enabled = true;
            else
                btnForward.Enabled = false;

            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webView1.GoBack();
            webPage.WebView = webView1;

            if (webView1.CanGoBack)
                btnBack.Enabled = true;
            else
                btnBack.Enabled = false;
            if (webView1.CanGoForward)
                btnForward.Enabled = true;
            else
                btnForward.Enabled = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webView1.GoForward();
            webPage.WebView = webView1;

            if (webView1.CanGoBack)
                btnBack.Enabled = true;
            else
                btnBack.Enabled = false;
            if (webView1.CanGoForward)
                btnForward.Enabled = true;
            else
                btnForward.Enabled = false;


        }


    }
}
