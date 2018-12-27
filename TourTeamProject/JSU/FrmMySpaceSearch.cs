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
    public partial class FrmMySpaceSearch : MetroFramework.Forms.MetroForm
    {
        #region 서버스트링
        string severStr = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/locationBasedList";
        string serviceKey =
            "?ServiceKey=" + "es9jiHOYsOYG9C2%2BzmyeSFxtnzPNcWqLMis2T6Ol2mU1rXVIUntZUjLnFo6W%2B5dKu3den7QwTLrY%2FSTg%2Fa%2F%2BCQ%3D%3D";
        string contentTypeId = "&contentTypeId=";
        string mapX = "&mapX=" + "126.98654497507285";
        string mapY = "&mapY=" + "37.55017931304345";

        string radius = "&radius=" + "2000";
        string listYN = "&listYN=" + "Y";
        string mobileOs = "&MobileOS=" + "ETC";
        string MobileApp = "&MobileApp=" + "TourAPI3.0_Guide";
        string arrang = "&arrange=" + "A";                  //  정렬구분 a:제목순 b:조회순 c:수정일 d:생성일순
        string numOfRows = "&numOfRows" + "15";
        string pageNo = "&pageNo=" + "1";
        string printType = "&_type=json";

        string msg = "";
        string totalCount = "";                 //  최대 아이템갯수
        string viewItem = "";                   //  한화면 보여주는 아이템수
        int pageMax;                            //  최대페이지
        #endregion

        List<SpaceTourInfo> list = new List<SpaceTourInfo>();

        public FrmMySpaceSearch()
        {
            InitializeComponent();
            dv_Place.Enabled = false;
            dv_Place.Visible = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           DisplayResult(txt_Point.Text);
        }

        public void DisplayResult(string position)
        {
            dv_Place.DataSource = null;
            
            list.Clear();
            // 좌표입력이 있다면

            if (position != string.Empty)
            {
                string[] xyCode = XYConvert(position);

                mapX = "&mapX=" + xyCode[1]; mapY = "&mapY=" + xyCode[0]; radius = "&radius=" + txt_Radius.Text;
            }

            ApiParser();
        }

        /// <summary>
        /// 구글 맵으로부터 위경도 좌표를 받아, WGS84로 변환함
        /// </summary>
        /// <param name="test">3도 좌표를 입력받는다.</param>
        /// <returns>3도주소를 WGS84로 변환해 배열로 출력</returns>
        private string[] XYConvert(string test)
        {
            //37°35'28.3"N 126°54'48.7"E
            //string test = "37°35'28.3\"N 126°54'48.7\"E ";

            string[] xyCode = new string[2];
            try
            {
                xyCode[0] = test.Substring(0, test.IndexOf('N')).Replace("°", ",").Replace("'", ",").Replace("\"", "");
                xyCode[1] = test.Substring(test.IndexOf('N') + 2).Replace("°", ",").Replace("'", ",").Replace("\"E", "");
            }
            catch (Exception)
            {
                MessageBox.Show("좌표가 잘못되었습니다");
                return xyCode;
            }

            string[] arrX = xyCode[0].Split(',');
            string[] arrY = xyCode[1].Split(',');


            xyCode[0] = (Convert.ToDouble(arrX[0]) + (Convert.ToDouble(arrX[1]) / 60) + (Convert.ToDouble(arrX[2]) / 3600)).ToString();
            xyCode[1] = (Convert.ToDouble(arrY[0]) + (Convert.ToDouble(arrY[1]) / 60) + (Convert.ToDouble(arrY[2]) / 3600)).ToString();


            MessageBox.Show(xyCode[0]+"\n"+ xyCode[1]);

            //txt_Point.Text = "X 좌표 : " + xyCode[1] + " Y좌표 : " + xyCode[1];
            
            return xyCode;
        }

        private void ApiParser()
        {
            msg = severStr + serviceKey + contentTypeId + mapX + mapY + radius + listYN + mobileOs + MobileApp + arrang + numOfRows + pageNo + printType;

            var json = ReturnJson();
            //MessageBox.Show(json);

            var jObj = JObject.Parse(json);
            jObj = JObject.Parse(jObj["response"].ToString());
            jObj = JObject.Parse(jObj["body"].ToString());
            totalCount = jObj["totalCount"].ToString();                         //  결과 리스트의 갯수
            viewItem = jObj["numOfRows"].ToString();                            //  한화면에 보이는 아이템 갯수

            if (Int32.Parse(totalCount) == 0) 
            {
                MessageBox.Show("검색결과가 없습니다");
                return;
            }

            jObj = JObject.Parse(jObj["items"].ToString());

            var arry = JArray.Parse(jObj["item"].ToString());

            pageMax = PageMaxGet();                                             //  최대 페이지수 반환
            lbl_PageInfo.Text = String.Format("{0} / {1}", pgn, pageMax);
            foreach (var item in arry)
            {
                string createTime = item["createdtime"].ToString();
                string modifyTime = item["modifiedtime"].ToString();

                int[] createArr = SplitTime(createTime);
                int[] modifyArr = SplitTime(modifyTime);
                try
                {
                    SpaceTourInfo info = new SpaceTourInfo
                    {
                        Title = item["title"].ToString(),
                        Mapx = Convert.ToDouble(item["mapx"].ToString()),
                        Mapy = Convert.ToDouble(item["mapy"].ToString())                        
                    };
                    try
                    {
                        info.Sigungucode = Int32.Parse(item["sigungucode"].ToString());
                    }
                    catch (Exception)
                    {
                        info.Sigungucode = 0;
                    }
                    try
                    {
                        info.Areacode = Convert.ToInt32(item["areacode"].ToString());
                    }
                    catch (Exception)
                    {
                        info.Areacode = 0;
                    }
                    try
                    {
                        info.Modifiedtime = new DateTime(modifyArr[0], modifyArr[1], modifyArr[2]);
                    }
                    catch (Exception)
                    {
                        info.Modifiedtime = new DateTime(9999, 99, 99);
                    }
                    try
                    {
                        info.Createdtime = new DateTime(createArr[0], createArr[1], createArr[2]);
                    }
                    catch (Exception)
                    {
                        info.Createdtime = new DateTime(9999, 99, 99);
                    }
                    try
                    {
                        info.Distance = item["dist"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Distance = "없음";
                    }
                    try
                    {
                        info.Contentid = item["contentid"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Contentid = "없음";
                    }
                    try
                    {
                        info.Addr1 = item["addr1"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Addr1 = "없음";
                    }
                    try
                    {
                        info.Cat1 = item["cat1"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Cat1 = "없음";
                    }
                    try
                    {
                        info.Cat2 = item["cat2"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Cat2 = "없음";
                    }
                    try
                    {
                        info.Cat3 = item["cat3"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Cat3 = "없음";
                    }
                    try
                    {
                        info.Tel = item["tel"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Tel = "없음";
                    }
                    try
                    {
                        info.Addr2 = item["addr2"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Addr2 = "값이없음";
                    }
                    try
                    {
                        info.Firstimage = item["firstimage"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Firstimage = "http://mplaza.co.kr/images/no_photo/car.gif";
                    }
                    try
                    {
                        info.Firstimage2 = item["firstimage2"].ToString();
                    }
                    catch (Exception)
                    {
                        info.Firstimage2 = "없음2";
                    }

                    list.Add(info);
                }
                catch (Exception x)
                {
                    MessageBox.Show("마지막페이지입니다\n"+x.StackTrace);
                    return;
                }
            }
            //DataTable dt = CreateDataTable(list);
            
            //dv_Place.DataSource = null;
            //dv_Place.DataSource = CreateDataTable(list);


            ListViewItem[] items = ListItemsMakes(list);
            listview_Show.View = View.LargeIcon;
            listview_Show.Items.AddRange(items);

            //dv_Place.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dv_Place.AutoResizeRows();
        }

        private ListViewItem[] ListItemsMakes(List<SpaceTourInfo> list)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            listview_Show.Items.Clear();
            ImageList image = new ImageList();
            image.ImageSize = new Size(180, 118);
            image.ColorDepth = ColorDepth.Depth32Bit;

            foreach (var item in list)
            {
                ListViewItem example = new ListViewItem(item.Title,item.Title);
                listViewItems.Add(example);


                image.Images.Add(item.Title, Image.FromStream(GetImage(item.Firstimage)));
            }

            listview_Show.LargeImageList = image;
            return listViewItems.ToArray();
        }

        private Stream GetImage(string imageString)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageString);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();

            return stream;
        }

        /// <summary>
        /// 데이터 테이블을 생성함
        /// </summary>
        /// <param name="list">검색 결과 리스트</param>
        /// <returns></returns>
        private DataTable CreateDataTable(List<SpaceTourInfo> list)
        {
            DataTable table = new DataTable("MySpaceTable");
            table.Columns.Add(new DataColumn("이름"));
            table.Columns.Add(new DataColumn("주소"));
            //table.Columns.Add(new DataColumn("등록일"));
            //table.Columns.Add(new DataColumn("수정일"));
            table.Columns.Add(new DataColumn("거리"));
            //table.Columns.Add(new DataColumn("X좌표"));
            //table.Columns.Add(new DataColumn("Y좌표"));
            //table.Columns.Add(new DataColumn("이미지", System.Type.GetType("string", true, true)));
            table.Columns.Add(new DataColumn("이미지", Type.GetType("System.Byte[]")));
            
            
            foreach (var item in list)
            {
                DataRow row = table.NewRow();
                row["이름"] = item.Title;
                row["주소"] = item.Addr1;
                //row["등록일"] = item.Createdtime;
                //row["수정일"] = item.Modifiedtime;
                row["거리"] = item.Distance+" M";
                //row["X좌표"] = item.Mapx;
                //row["Y좌표"] = item.Mapy;
                if (item.Firstimage != "없음")
                {
                    row["이미지"] = ImgResize(GetImgByte(item.Firstimage));
                }
                else
                {
                    row["이미지"] = null;
                }
                //row["이미지"] = GetImgByte(item.Firstimage);

                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// Img Str을 매개변수로 받아 이미지의 바이트를 반환함
        /// </summary>
        /// <param name="path">Img String</param>
        /// <returns>이미지의 Byte[]</returns>
        private Byte[] GetImgByte(string path)
        {
            Byte[] imgByte = new byte[16 * 1024];               //  이미지의 크기
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();
            MemoryStream memory = new MemoryStream();
            
            int read;
            while ((read = stream.Read(imgByte, 0, imgByte.Length)) > 0)
            {
                memory.Write(imgByte, 0, read);
            }

            imgByte = memory.ToArray();

            memory.Dispose();
            stream.Dispose();

            return imgByte;
        }
       
        /// <summary>
        /// Img Byte배열을 받아 사이즈를 240*240으로 리사이즈한다.
        /// </summary>
        /// <param name="path">Img Byte[]</param>
        /// <returns>Resize img Byte[]</returns>
        private Byte[] ImgResize(Byte[] path)
        {
            MemoryStream myMemStream = new MemoryStream(path);
            Image fullsizeImage = Image.FromStream(myMemStream);
            Image newImage = fullsizeImage.GetThumbnailImage(250, 250, null, IntPtr.Zero);
            MemoryStream myResult = new MemoryStream();
            newImage.Save(myResult, System.Drawing.Imaging.ImageFormat.Jpeg);  //   이미지 변경
            return myResult.ToArray();  // 리사이즈된 이미지 바이트배열 반환
        }

        /// <summary>
        /// 최대 페이지수를 반환합니다.
        /// </summary>
        /// <returns></returns>
        private int PageMaxGet()
        {
            int temp = Convert.ToInt32(totalCount) / Convert.ToInt32(viewItem);
            float tmp = temp;

            if (tmp % 2.0 == 0)
            {
                temp += 1;
            }

            return temp;
        }

        /// <summary>
        /// Json반환함
        /// </summary>
        /// <returns></returns>
        private string ReturnJson()
        {
            var json = "";
            WebRequest request = (WebRequest)HttpWebRequest.Create(msg);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                json = sr.ReadToEnd();
            }
            else
                json = "json Not found";

            return json;            
        }

        /// <summary>
        /// 시간 스트링을 배열로 잘라준다.
        /// </summary>
        /// <param name="timeStr">시간 스트링 배열 </param>
        /// <returns> 0 년도 1 월 2 일 3 시 4 분 5 초</returns>
        private int[] SplitTime(string timeStr)
        {
            //Createdtime = Convert.ToDateTime(new DateTime(timeStr.))
            //2007 11 06 01 34 53

            int[] arr =
                {
                Int32.Parse( timeStr.Substring(0,4).Replace(" ","")),Int32.Parse( timeStr.Substring(4,2).Replace(" ","")), Int32.Parse( timeStr.Substring(6, 2).Replace(" ","")),Int32.Parse( timeStr.Substring(8, 2).Replace(" ","")), Int32.Parse( timeStr.Substring(10, 2).Replace(" ","")), Int32.Parse( timeStr.Substring(12, 2).Replace(" ",""))
            };

            return arr;
        }

        private void FrmMySpaceSearch_Load(object sender, EventArgs e)
        {
            //list
        }
        int pgn = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (pgn==pageMax)
            {
                MessageBox.Show("마지막페이지입니다.");
                return;
            }
            list.Clear();
            pageNo = "&pageNo=" + ++pgn;
            ApiParser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pgn == 1)
            {
                MessageBox.Show("첫페이지입니다");
                return;
            }
            list.Clear();
            pageNo = "&pageNo=" + --pgn;
            ApiParser();
        }

        
    }
}
