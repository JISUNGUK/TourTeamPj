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
        DataTable blogTable;
        int currentPage = 0;
        int totalPage = 0;

        public FormApilogue()
        {
            InitializeComponent();
        }

        private void FormApilogue_Load(object sender, EventArgs e)
        {
            listBlog.Clear();

            keyWord = String.Empty;
            keyWord = ConvertKeyword("내일로여행후기");
            string jsonStr = GetJson(keyWord);
            JObject jObject = JObject.Parse(jsonStr);
            
            if ((Int32.Parse(jObject["total"].ToString()) % 12) != 0)
            {
                totalPage = Int32.Parse(jObject["total"].ToString()) / 12 + 1;
            }
            else
            {
                totalPage = Int32.Parse(jObject["total"].ToString()) / 12;
            }
            
            JArray jArray = JArray.Parse(jObject["items"].ToString());

            blogTable = new DataTable();
            DataColumn titleColumn = new DataColumn("제목", Type.GetType("System.String"));
            blogTable.Columns.Add(titleColumn);
            DataColumn bloggerNameColumn = new DataColumn("블로거", Type.GetType("System.String"));
            blogTable.Columns.Add(bloggerNameColumn);

            foreach (JObject item in jArray)
            {
                DataRow blogRow = blogTable.NewRow();

                Blog blog = new Blog
                {
                    Title = item["title"].ToString().Replace("<b>", "").Replace("</b>", ""),
                    Link = item["link"].ToString(),
                    Description = item["description"].ToString().Replace("<b>", "").Replace("</b>", ""),
                    Bloggername = item["bloggername"].ToString(),
                    Bloggerlink = item["bloggerlink"].ToString(),
                    Postdate = new DateTime(Int32.Parse(item["postdate"].ToString().Remove(4)), Int32.Parse(item["postdate"].ToString().Remove(0,4).Remove(2)), Int32.Parse(item["postdate"].ToString().Remove(0,6)))
                };

                blogRow["제목"] = item["title"].ToString().Replace("<b>", "").Replace("</b>", "");
                blogRow["블로거"] = item["bloggername"].ToString();

                blogTable.Rows.Add(blogRow);
                listBlog.Add(blog);
            }

            label1.Text = currentPage + 1 + " / " + totalPage;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = blogTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage -1 > -1)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Blog item in listBlog)
            {
                if (item.Title == listBlog[e.RowIndex].Title || item.Bloggername == listBlog[e.RowIndex].Bloggername)
                {
                   System.Diagnostics.Process.Start(item.Bloggerlink + "/" + item.Link.Remove(0, item.Link.IndexOf("?") + 24));  
                }
            }
        }

        /// <summary>
        /// 네이버 블로그api를 이용하여 Json문자열을 반환하는 메서드입니다.
        /// </summary>
        /// <returns></returns>
        private string GetJson(string keyWord)
        {
            string requestUrl = "https://openapi.naver.com/v1/search/blog.json?query=" + keyWord + "&display=12&start=" + (currentPage * 12 + 1);
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
