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

namespace TourTeamProject
{
    public partial class FormDetailItem : MetroFramework.Forms.MetroForm
    {
        private TourSk item;
        private string authenticationKey = "70i7ZBjwMhQcgYsy9HnYEEXv%2FXQ5MxlEHeHcsNd17WY8r%2Fl57uRYryqyC93hdqLDj5WgQ5GwgvA0pgV9sCKcAQ%3D%3D"; // 인증키입니다.
        PictureBox pictureBox;
        ListView listView;
        List<MoreImage> moreImages;

        public FormDetailItem()
        {
            InitializeComponent();
        }

        public FormDetailItem(TourSk item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void FormDetailItem_Load(object sender, EventArgs e)
        {
            moreImages = new List<MoreImage>();

            CommonTab();
            MoreImageTab();
        }

        List<string> smallImg = new List<string>();

        /// <summary>
        /// 추가이미지가 있다면 추가되는 탭입니다.
        /// </summary>
        private void MoreImageTab()
        {
            string query2 = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailImage?ServiceKey=" + authenticationKey + "&contentTypeId=" + item.Contenttypeid + "&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&contentId=" + item.Contentid + "&imageYN=Y&_type=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(query2);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string jsonString2 = streamReader.ReadToEnd();

            JObject jObject = JObject.Parse(jsonString2);
            jObject = JObject.Parse(jObject["response"].ToString());
            jObject = JObject.Parse(jObject["body"].ToString());

            if (Int32.Parse(jObject["totalCount"].ToString()) > 0)
            {
                JObject jObject2 = JObject.Parse(jObject["items"].ToString());
                listView = new ListView();
                listView.Size = new Size(220, 395);
                listView.Location = new Point(630, 21);
                listView.View = View.LargeIcon;

                ImageList imageList = new ImageList();
                
                imageList.ImageSize = new Size(150, 100);
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                listView.LargeImageList = imageList;

                if (Int32.Parse(jObject["totalCount"].ToString()) == 1)
                {
                    JObject jObject3 = JObject.Parse(jObject2["item"].ToString());

                    pictureBox = new PictureBox();
                    pictureBox.Location = new Point(26, 21);
                    pictureBox.Size = new Size(595, 395);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.ImageLocation = jObject3["originimgurl"].ToString();

                    Image smallImage = Image.FromStream(GetImage(jObject3["smallimageurl"].ToString()));
                    imageList.Images.Add(smallImage);
                    
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.ImageIndex = 0;
                    listView.Items.Add(listViewItem);

                    tabControl1.TabPages.Add("MoreImage", "추가이미지");
                    tabControl1.TabPages["MoreImage"].Controls.Add(pictureBox);
                    tabControl1.TabPages["MoreImage"].Controls.Add(listView);
                    tabControl1.TabPages["MoreImage"].BackColor = Color.White;
                }
                else
                {
                    JArray jArray = JArray.Parse(jObject2["item"].ToString());

                    pictureBox = new PictureBox();
                    pictureBox.Location = new Point(26, 21);
                    pictureBox.Size = new Size(595, 395);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.ImageLocation = jArray[0]["originimgurl"].ToString();

                    int index = 0;

                    foreach (JObject item in jArray)
                    {
                        MoreImage moreImage = new MoreImage
                        {
                            Contentid = item["contentid"].ToString(),
                            Originimgurl = item["originimgurl"].ToString(),
                            Serialnum = item["serialnum"].ToString(),
                            Smallimageurl = item["smallimageurl"].ToString()
                        };

                        moreImages.Add(moreImage);

                        smallImg.Add(item["smallimageurl"].ToString());

                        ListViewItem listViewItem = new ListViewItem();

                        Image smallImage = Image.FromStream(GetImage(item["smallimageurl"].ToString()));
                        imageList.Images.Add(smallImage);
                        listViewItem.ImageIndex = index;
                        listView.Items.Add(listViewItem);

                        index++;
                    }

                    tabControl1.TabPages.Add("MoreImage", "추가이미지");
                    tabControl1.TabPages["MoreImage"].Controls.Add(pictureBox);
                    tabControl1.TabPages["MoreImage"].Controls.Add(listView);
                    tabControl1.TabPages["MoreImage"].BackColor = Color.White;

                    listView.SelectedIndexChanged += ListView_SelectedIndexChanged;

                }
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                count = listView.SelectedItems[0].Index;
            }
            catch (Exception)
            {
            }

            foreach (MoreImage item in moreImages)
            {
                if (item.Smallimageurl == smallImg[count])
                {
                    pictureBox.ImageLocation = item.Originimgurl;
                }
            }
        }

        /// <summary>
        /// 공통정보에 표시되는 정보입니다.
        /// </summary>
        private void CommonTab()
        {
            string query1 = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailCommon?ServiceKey=" + authenticationKey + "&contentTypeId=" + item.Contenttypeid + "&contentId=" + item.Contentid + "&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&defaultYN=Y&firstImageYN=Y&areacodeYN=Y&catcodeYN=Y&addrinfoYN=Y&mapinfoYN=Y&overviewYN=Y&transGuideYN=Y&_type=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(query1);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string jsonString1 = streamReader.ReadToEnd();

            JObject jsonObject = JObject.Parse(jsonString1);
            jsonObject = JObject.Parse(jsonObject["response"].ToString());
            jsonObject = JObject.Parse(jsonObject["body"].ToString());
            jsonObject = JObject.Parse(jsonObject["items"].ToString());
            jsonObject = JObject.Parse(jsonObject["item"].ToString());

            if (jsonObject["firstimage"] != null)
            {
                pictureBox1.ImageLocation = jsonObject["firstimage"].ToString();
            }
            else
            {
                pictureBox1.ImageLocation = "http://mplaza.co.kr/images/no_photo/car.gif";
            }

            label2.Text = jsonObject["overview"].ToString().Replace("<strong>", "").Replace("</strong>", "").Replace("<br>", "").Replace("<br />", "").Replace("nbsp;", "");

            if (jsonObject["zipcode"] != null)
            {
                label3.Text += " " + jsonObject["zipcode"].ToString();
            }
            else
            {
                label3.Text = String.Empty;
            }

            if (jsonObject["telname"] != null)
            {
                label4.Text += " " + jsonObject["telname"].ToString();
            }
            else
            {
                label4.Text = String.Empty;
            }

            if (jsonObject["tel"] != null)
            {
                label5.Text += " " + jsonObject["tel"].ToString();
            }
            else
            {
                label5.Text = String.Empty;
            }

            if (jsonObject["homepage"] != null)
            {
                label6.Text += " " + jsonObject["homepage"].ToString().Remove(0, jsonObject["homepage"].ToString().IndexOf(">") + 1).Replace("</a>", "");
            }
            else
            {
                label6.Text = String.Empty;
            }

            if (jsonObject["addr1"] != null && jsonObject["addr2"] != null)
            {
                label7.Text += " " + jsonObject["addr1"].ToString() + jsonObject["addr2"].ToString();
            }
            else if (jsonObject["addr1"] != null && jsonObject["addr2"] == null)
            {
                label7.Text += " " + jsonObject["addr1"].ToString();
            }
            else
            {
                label7.Text = String.Empty;
            }
        }

        /// <summary>
        /// 이미지string에 대한 stream을 반환합니다.
        /// </summary>
        /// <param name="imageString">이미지 관련 문자열입니다.</param>
        /// <returns></returns>
        public Stream GetImage(string imageString)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageString);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();

            return stream;
        }
    }
}
