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
        private string address;
        private string location;
        public Naviweb()
        {
            InitializeComponent();
        }
        public string Address { get => address; set => address = value; }
        public string Location1 { get => location; set => location = value; }

        private void Naviweb_Load(object sender, EventArgs e)
        {
            InitWebbrowser("www.google.co.kr/maps/search/" + address);
        }

        /// <summary>
        /// 웹브라우저에 화면을 출력 url을 입력하면 해당 웹페이지로 이동함
        /// 구글맵을 사용시 www.google.co.kr/maps/search/검색어 형식으로 이용하고 해당 페이지의 url이 www.google.co.kr/maps/place/@위도,경도,z형식으로 나올때까지 기다렸다가 해당 내용이 나올때 location변수에 해당 위도,경도,z값을 저장함
        /// </summary>
        /// <param name="url"></param>
        public void InitWebbrowser(string url)
        {
            nv = webView1.LoadUrl("https://" + url);
            if (webView1.CanGoBack)
                btnBack.Enabled = true;
            else
                btnBack.Enabled = false;
            if (webView1.CanGoForward)
                btnForward.Enabled = true;
            else
                btnForward.Enabled = false;
            if (url.Contains("www.google.co.kr/maps/search"))
            {
                while (true)
                {
                    MessageBox.Show("로딩중:" + webView1.Url);
                    if (webView1.Url.Contains("/@"))
                    {
                        searchKeyword.Text = webView1.Url;
                        webPage.WebView = webView1;
                        int latitude = searchKeyword.Text.IndexOf("/@");
                        int altitude = searchKeyword.Text.IndexOf("z/");
                        latitudeText.Text = searchKeyword.Text.Substring(latitude + 2, altitude - latitude - 1);
                        location = latitudeText.Text;
                        break;
                    }
                }
            }
            else
            {
                webPage.WebView = webView1;
            }


        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InitWebbrowser(searchKeyword.Text);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webView1.GoBack();
            webPage.WebView = webView1;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webView1.GoForward();
            webPage.WebView = webView1;
        }


    }
}
