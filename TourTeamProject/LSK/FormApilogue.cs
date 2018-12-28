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
    public partial class FormApilogue : MetroFramework.Forms.MetroForm
    {
        FormTouristInformationByRegion ftibr = new FormTouristInformationByRegion();

        string keyWord = String.Empty; // 네이버 블로그의 내일로후기의 키워드입니다.
        List<Blog> listBlog = new List<Blog>();
        int currentPage = 0;
        int totalPage = 0;

        public FormApilogue()
        {
            InitializeComponent();
        }

        private void FormApilogue_Load(object sender, EventArgs e)
        {
            listBlog.Clear();
            panel1.Controls.Clear();

            keyWord = String.Empty;
            keyWord = ConvertKeyword("내일로여행후기");
            string jsonStr = GetJson(keyWord);
            JObject jObject = JObject.Parse(jsonStr);

            if ((Int32.Parse(jObject["total"].ToString()) % 8) != 0)
            {
                totalPage = Int32.Parse(jObject["total"].ToString()) / 8 + 1;
            }
            else
            {
                totalPage = Int32.Parse(jObject["total"].ToString()) / 8;
            }

            JArray jArray = JArray.Parse(jObject["items"].ToString());

            foreach (JObject item in jArray)
            {
                Blog blog = new Blog
                {
                    Title = item["title"].ToString().Replace("<b>", "").Replace("</b>", ""),
                    Link = item["link"].ToString(),
                    Description = item["description"].ToString().Replace("<b>", "").Replace("</b>", ""),
                    Bloggername = item["bloggername"].ToString(),
                    Bloggerlink = item["bloggerlink"].ToString(),
                    Postdate = new DateTime(Int32.Parse(item["postdate"].ToString().Remove(4)), Int32.Parse(item["postdate"].ToString().Remove(0, 4).Remove(2)), Int32.Parse(item["postdate"].ToString().Remove(0, 6)))
                };

                listBlog.Add(blog);
            }

            Apilogue icon = new Apilogue();

            for (int i = 0; i < listBlog.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(12, 0);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 1:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(307, 0);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 2:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(12, 165);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 3:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(307, 165);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 4:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(12, 330);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 5:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(307, 330);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 6:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(12, 495);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                    case 7:
                        icon = new Apilogue(listBlog[i].Title, listBlog[i].Bloggername, listBlog[i].Bloggerlink + "/" + listBlog[i].Link.Remove(0, listBlog[i].Link.IndexOf("?") + 24));
                        icon.Location = new Point(307, 495);
                        panel1.Controls.Add(icon);
                        icon.Click += Icon_Click;
                        break;
                }
            }

            label1.Text = currentPage + 1 + " / " + totalPage;
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            Apilogue ap = (Apilogue)sender;

            foreach (Blog item in listBlog)
            {
                if (ap.LblTitle.Text == item.Title || ap.LblBloggerName.Text == item.Bloggername)
                {
                    System.Diagnostics.Process.Start(item.Bloggerlink + "/" + item.Link.Remove(0, item.Link.IndexOf("?") + 24));
                }
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 > -1)
            {
                currentPage -= 1;
                FormApilogue_Load(null, null);
            }
            else
            {
                MessageBox.Show("첫 페이지입니다.");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 < totalPage)
            {
                currentPage += 1;
                FormApilogue_Load(null, null);
            }
            else
            {
                MessageBox.Show("마지막 페이지입니다.");
            }
        }

        /// <summary>
        /// 네이버 블로그api를 이용하여 Json문자열을 반환하는 메서드입니다.
        /// </summary>
        /// <returns></returns>
        private string GetJson(string keyWord)
        {
            string requestUrl = "https://openapi.naver.com/v1/search/blog.json?query=" + keyWord + "&display=8&start=" + (currentPage * 8 + 1);
            string clientId = "CEgB42FcMMsE9do22Tp9";
            string clientSecret = "0Mmepr2xkB";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Headers.Add("X-Naver-Client-Id", clientId);
            request.Headers.Add("X-Naver-Client-Secret", clientSecret);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string jsonString = streamReader.ReadToEnd();

            return jsonString;
        }

        /// <summary>
        /// 문자열을 16진수로 변환합니다.
        /// </summary>
        /// <param name="text">키워드 텍스트입니다.</param>
        /// <returns></returns>
        public string ConvertKeyword(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            foreach (byte item in bytes)
            {
                keyWord += "%" + Convert.ToString(item, 16).ToUpper();
            }

            return keyWord;
        }
    }
}
