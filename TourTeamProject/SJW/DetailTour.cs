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
        private string contentid, contentpid, address;
        private string servicekey = "7V8bwwI0r4itRyj%2BK9kCFfFaFV5sv7alU9slMR%2FGEbZBiRwf1lkOkEq%2Fn0eR%2FXwckcRZq2xCyV4nnbYzzaGYRg%3D%3D";
        private string url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailCommon?ServiceKey=";

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
            if (addrLabel.Text != "주소:없음")
            {
                Naviweb nw = new Naviweb();
                nw.Address = address;
                nw.Show();
            }
        }



        public string Address { get => address; set => address = value; }

        private void DetailTour_Load(object sender, EventArgs e)
        {

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
                addrLabel.Text = "주소:" + jitem["addr1"].ToString();





        }
    }
}
