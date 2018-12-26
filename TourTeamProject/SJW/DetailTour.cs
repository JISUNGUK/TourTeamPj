using Newtonsoft.Json.Linq;
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
    public partial class DetailTour : MetroForm
    {
        ToolTip t1;
        private string contentid, contentpid, address;
        private string servicekey = "7V8bwwI0r4itRyj%2BK9kCFfFaFV5sv7alU9slMR%2FGEbZBiRwf1lkOkEq%2Fn0eR%2FXwckcRZq2xCyV4nnbYzzaGYRg%3D%3D";
        private string url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailCommon?ServiceKey=";
        private string mapx;
        private string mapy;

        private string endurl = "&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&defaultYN=Y&firstImageYN=Y&areacodeYN=Y&catcodeYN=Y&addrinfoYN=Y&mapinfoYN=Y&overviewYN=Y&transGuideYN=Y&_type=json";
        public DetailTour()
        {
            InitializeComponent();
            
        }

        public string Contentid { get => contentid; set => contentid = value; }
        public string Contentpid { get => contentpid; set => contentpid = value; }
        public string Servicekey { get => servicekey; set => servicekey = value; }

        private void addrLabel_Click(object sender, EventArgs e)
        {
            
        }
       



        public string Address { get => address; set => address = value; }
        public string Mapx { get => mapx; set => mapx = value; }
        public string Mapy { get => mapy; set => mapy = value; }

        private void linkedLabel_Click(object sender, EventArgs e)
        {
            if (linkedLabel.Text != "주소:없음")
            {
                Naviweb nw = new Naviweb();
                nw.Address = "www.google.co.kr/maps/search/" + address;       nw.Show();  
              
            }

        }

        private void DetailTour_Load(object sender, EventArgs e)
        {
            linkedLabel.MouseEnter += linkedLabel_MouseEnter;
            if (address != null)
            {
                t1 = new ToolTip();
                t1.Active = true;
                t1.AutoPopDelay = 1;                              
            }

            string path = url + servicekey + "&contentTypeId=" + contentpid + "&contentId=" + contentid + endurl;
            HttpWebRequest hw = (HttpWebRequest)WebRequest.Create(path);
            HttpWebResponse hr = (HttpWebResponse)hw.GetResponse();
            StreamReader sr = new StreamReader(hr.GetResponseStream());
            string jsonResult = sr.ReadToEnd();
            JObject jobject = JObject.Parse(jsonResult);
            JObject jresponse = JObject.Parse(jobject["response"].ToString());
            JObject jbody = JObject.Parse(jresponse["body"].ToString());
            JObject jitems = JObject.Parse(jbody["items"].ToString());
            JObject jitem = JObject.Parse(jitems["item"].ToString());

            result.Text = jitem["overview"].ToString().Replace("<b>", "").Replace("</b>", "").Replace("<br>", "").Replace("</br>", "").Replace("<br />", "").Replace("<strong>", "").Replace("</strong>", "");
            Title.Text = jitem["title"].ToString();
            if (jitem["firstimage"] != null)
            {

                PlacePIc.ImageLocation = jitem["firstimage"].ToString();
            }
            if (jitem["zipcode"] != null)
                PostLabel.Text = "우편번호:" + jitem["zipcode"].ToString();
            if (jitem["addr1"] != null)
                linkedLabel.Text = "주소:" + jitem["addr1"].ToString();





        }

        private void linkedLabel_MouseEnter(object sender, EventArgs e)
        {
           if(t1!=null)
            {                
                t1.Show("해당 주소의 지도로 이동합니다", linkedLabel, 1000);
            }
            
        }
    }
}
