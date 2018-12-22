using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TourTeamProject
{
    public partial class IntegratedSearch : MetroForm
    {
        private List<TourSearchResult> tourList = new List<TourSearchResult>();
        HttpWebRequest hw=null;
        HttpWebResponse hr = null;
        StreamReader sr = null;
        string apiurl = "http://api.visitkorea.or.kr/openapi/service/rest/";
        string language = "KorService";
        string languageAfter="/searchKeyword?ServiceKey=7V8bwwI0r4itRyj%2BK9kCFfFaFV5sv7alU9slMR%2FGEbZBiRwf1lkOkEq%2Fn0eR%2FXwckcRZq2xCyV4nnbYzzaGYRg%3D%3D&keyword=";
        string afterurl = "&areaCode=&sigunguCode=&cat1=&cat2=&cat3=&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&arrange=O&_type=json&numOfRows=";
        string pagenum = "&pageNo=";
        int pageCount = 1;//현재페이지
        int numofRows = 10;//한 페이지당 출력될 검색건수
        int totalCount = 0;//총 검색검수
        int totalPageNum = 0;//총 페이지수

        internal List<TourSearchResult> TourList { get => tourList; set => tourList = value; }
        public int TotalCount { get => totalCount; set => totalCount = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public int TotalPageNum { get => totalPageNum; set => totalPageNum = value; }
        public int NumofRows { get => numofRows; set => numofRows = value; }
        public string Language { get => language; set => language = value; }

        //반드시 대표 이미지 있는것만 출력하게함
        public IntegratedSearch()
        {
            InitializeComponent();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          

           
        }

        private void IntegratedSearch_Load(object sender, EventArgs e)
        {
           


        }

        private void cat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PageCount = 1;
            string json=jsonParse(searchKeyword.Text);
            DisplayResult(tourGridview,json);
        }
        /// <summary>
        /// json출력결과를 받아서 해당 데이터로 된 데이터테이블을 반환시켜줌
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public DataTable GetTourTable(string word)
        {
            JObject jo = JObject.Parse(word);
            
            JObject JR = JObject.Parse(jo["response"].ToString());
            if (JR["body"] != null)
            {
                JObject JB = JObject.Parse(JR["body"].ToString());
                totalCount = Int32.Parse(JB["totalCount"].ToString());
                if (totalCount % NumofRows != 0)
                    totalPageNum = (totalCount / NumofRows) + 1;
                else
                    totalPageNum = (totalCount / NumofRows);
                currentPage.Text = "현재 쪽:" + PageCount;
                totalpgNum.Text = "전체 쪽수:" + totalPageNum;

                string noimageUrl = "http://sign.kedui.net/rtimages/n_sub/no_detail_img.gif";

                if (totalCount > 0)
                {
                    TourList.Clear();
                    tourGridview.DataSource = null;
                    JObject jr = JObject.Parse(JB["items"].ToString());

                    if (totalCount != 1)
                    {
                        JArray JA = JArray.Parse(jr["item"].ToString());
                        foreach (var item in JA)
                        {

                            TourSearchResult tr = new TourSearchResult();
                            if (item["title"] != null)
                                tr.Title = item["title"].ToString();
                            if (item["addr1"] != null)
                                tr.Address = item["addr1"].ToString();
                            if (item["mapx"] != null)
                            {
                                tr.Mapx = item["mapx"].ToString();

                                tr.Mapy = item["mapy"].ToString();
                            }

                            if (item["tel"] != null)
                                tr.Tel = item["tel"].ToString();

                            tr.Contentid = item["contentid"].ToString();
                            tr.Contenttypeid = item["contenttypeid"].ToString();
                            if (item["areacode"] != null)
                                tr.Areacode = item["areacode"].ToString();
                            if (item["sigungucode"] != null)
                                tr.Sigungucode = item["sigungucode"].ToString();
                            if (item["firstimage"] != null)
                                tr.Imageurl = item["firstimage"].ToString();
                            else
                            {
                                tr.Imageurl = noimageUrl;
                            }
                            if (item["firstimage2"] != null)
                                tr.Imageurl2 = item["firstimage2"].ToString();
                            else
                            {
                                tr.Imageurl2 = noimageUrl;
                            }
                            tourList.Add(tr);
                            
                        }
                    }
                    else
                    {
                        JObject jitem = JObject.Parse(jr["item"].ToString());
                        TourSearchResult tr = new TourSearchResult();
                        tr.Title = jitem["title"].ToString();
                        tr.Contentid = jitem["contentid"].ToString();
                        tr.Contenttypeid = jitem["contenttypeid"].ToString();
                        if (jitem["addr1"] != null)
                            tr.Address = jitem["addr1"].ToString();
                        tr.Mapx = jitem["mapx"].ToString();
                        tr.Mapy = jitem["mapy"].ToString();
                        if (jitem["firstimage"] != null)
                            tr.Imageurl = jitem["firstimage"].ToString();
                        else
                            tr.Imageurl = noimageUrl;
                        if (jitem["firstimage2"] != null)
                            tr.Imageurl = jitem["firstimage2"].ToString();
                        else
                            tr.Imageurl2 = noimageUrl;
                        TourList.Add(tr);
                    }

                    DataTable dt = new DataTable("tourPlace");
                    DataColumn dTitle = new DataColumn("제목");
                    DataColumn dAddress = new DataColumn("주소");
                    DataColumn dxPosition = new DataColumn("위도");
                    DataColumn dyPosition = new DataColumn("경도");
                    DataColumn dTel = new DataColumn("번호");
                    DataColumn dZip = new DataColumn("우편번호");
                    DataColumn dHomepage = new DataColumn("홈페이지");


                    dt.Columns.Add(dTitle);
                    dt.Columns.Add(dAddress);
                    dt.Columns.Add(dxPosition);
                    dt.Columns.Add(dyPosition);
                    dt.Columns.Add(dTel);
                    dt.Columns.Add(new DataColumn("이미지", System.Type.GetType("System.Byte[]", true, true)));
                    int nullcount = 0;
                    foreach (var v in TourList)
                    {

                        DataRow dr = dt.NewRow();
                        dr[0] = v.Title;
                        dr[1] = v.Address;
                        dr[2] = v.Mapx;
                        dr[3] = v.Mapy;                        
                        dr[4] = v.Tel;
                        dr[5] = displayImage(v.Imageurl);


                        dt.Rows.Add(dr);
                        nullcount++;
                    }
                    if (nullcount == 0)
                        dt = null;


                    return dt;
                }
                else
                {
                    DataTable dt = null;
                    MessageBox.Show("찾으시는 결과가 없습니다");
                    return dt;
                }


            }
            else
                return null;
        }
        /// <summary>
        /// 검색받은 결과를 데이터 그리드뷰에 출력해줌
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="word"></param>
        /// 
        public void DisplayResult(DataGridView dgv, string searchword)
        {
            dgv.DataSource = GetTourTable(searchword);
            if (dgv.DataSource != null)
            {
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv.AutoSize = true;               
                    
            }
        }
        /// <summary>
        /// 검색어를 등록받아 json결과물을 출력해줌
        /// </summary>
        /// <param name="searchword"></param>
        /// <returns></returns>
        private string jsonParse(string searchword)
        {
            string keyword = WebUtility.UrlEncode(searchword);
            string url = apiurl +Language + languageAfter+keyword + afterurl + NumofRows + pagenum + PageCount;
            hw = (HttpWebRequest)WebRequest.Create(url);
            hr = (HttpWebResponse)hw.GetResponse();
            sr = new StreamReader(hr.GetResponseStream());
            
            string result = sr.ReadToEnd();
            JObject jo = JObject.Parse(result);
            JObject JR = JObject.Parse(jo["response"].ToString());
            if(JR["body"]!=null)
            { 
            JObject JB = JObject.Parse(JR["body"].ToString());
            TotalCount = Int32.Parse(JB["totalCount"].ToString());
            if (TotalCount % NumofRows != 0)
                TotalPageNum = (TotalCount / NumofRows) + 1;
            else
                TotalPageNum = (TotalCount / NumofRows);
            resultLbl.Text = "검색건수:"+ TotalCount;
            }
            return result;
        }
        /// <summary>
        /// 해당 이미지의 사이트경로를 따라가서 해당 이미지를 바이트배열로 반환함
        /// </summary>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public static Byte[] displayImage(string imagepath)
        {
            
            int i = 0;
            byte[] imageByte;
            HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(imagepath);
            HttpWebResponse hrs = (HttpWebResponse)hr.GetResponse();
            Stream sr = hrs.GetResponseStream();
            MemoryStream ms = new MemoryStream();
            CopyStream(sr,ms);
            imageByte = ms.ToArray();

           
            return imageByte; 
        }
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[16 * 1024];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        private void tourGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string contentid=TourList[tourGridview.CurrentRow.Index].Contentid;
            string contentpid = TourList[tourGridview.CurrentRow.Index].Contenttypeid;
            string address= TourList[tourGridview.CurrentRow.Index].Address;
            DetailTour dt = new DetailTour();
            dt.Contentid = contentid;
            dt.Contentpid = contentpid;
            dt.Address = address;
            dt.Show();
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void tourGridview_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if(RowNum.SelectedIndex>-1)
            {
                NumofRows =Int32.Parse(RowNum.SelectedItem.ToString());
            }
        }

        private void splitContainer1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PageCount = 1;
            string json = jsonParse(searchKeyword.Text);
            DisplayResult(tourGridview, json);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(PageCount>1)
            {
                PageCount--;
                DisplayResult(tourGridview, jsonParse(searchKeyword.Text));
            }
            else
                MessageBox.Show("첫번째 페이지입니다");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PageCount != TotalPageNum)
            {
                PageCount++;
                DisplayResult(tourGridview, jsonParse(searchKeyword.Text));
            }
            else
                MessageBox.Show("마지막 페이지입니다");


        }

       

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void searchKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                PageCount = 1;
                string json = jsonParse(searchKeyword.Text);
                DisplayResult(tourGridview, json);

            }
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            if(PageCount != TotalPageNum)
            { 
            PageCount = TotalPageNum;
            string json = jsonParse(searchKeyword.Text);
            DisplayResult(tourGridview, json);
            }
            else
                MessageBox.Show("마지막 페이지입니다");

        }
    }
}
