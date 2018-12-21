using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTeamProject
{
    public partial class FrmPickArea : MetroFramework.Forms.MetroForm
    {
        SqlDataAdapter ad;

        public delegate void SendDelegate(string[] url);
        public event SendDelegate send;


        public FrmPickArea()
        {
            InitializeComponent();
        }

        void Display(DataTable dt)
        {
            gridView.DataSource = null;
            gridView.DataSource = dt;
            gridView.AutoResizeColumns();
            gridView.AutoResizeRows();
        }

        DataTable DBconnection(string[] arr)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "InitialSearch";
                com.Parameters.AddWithValue("@one", arr[0]);
                com.Parameters.AddWithValue("@two", arr[1]);

                DataTable table = new DataTable();
                table.Columns.AddRange
                    (new DataColumn[] { new DataColumn("이름"), new DataColumn("사은품"), new DataColumn("맛집"),
                    new DataColumn("숙박"), new DataColumn("여행지혜택")});

                var dr = com.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = table.NewRow();
                    row["이름"] = dr["name"].ToString();
                    row["사은품"] = dr["gifts"].ToString();
                    row["맛집"] = dr["restaurant"].ToString();
                    row["숙박"] = dr["lodging"].ToString();
                    row["여행지혜택"] = dr["tour"].ToString();
                    
                    table.Rows.Add(row);
                }
                return table;
            }
        }

        private void btn_ㅎ_Click(object sender, EventArgs e)
        {
            //  1. 폼 사이즈 늘리고
            //  2. 이벤트 sender에서 컨트롤의 이름을 가져옴
            //  3. InitialSearch 로 초성검색해서 데이터테이블 반환
            //  3. 그리드뷰 초기화 하고 다시 데이터소스 넣기~
            
            //gridView.DataSource = DBconnection("ㄱ","ㄴ");

            var clickname = sender.ToString();
            var result = sender.ToString().Replace(" ", "").Substring(clickname.LastIndexOf(":"));
            
            //MessageBox.Show(result.ToString());
            this.Size = new Size(800, 653);

            string[] parArr = new string[2];

            switch (result)
            {
                case "ㄱ":
                    parArr[0] = result; parArr[1] = "ㄴ";
                    break;
                case "ㄴ":
                    parArr[0] = result; parArr[1] = "ㄷ";
                    break;
                case "ㄷ":
                    parArr[0] = result; parArr[1] = "ㄹ";
                    break;
                case "ㄹ":
                    parArr[0] = result; parArr[1] = "ㅁ";
                    break;
                case "ㅁ":
                    parArr[0] = result; parArr[1] = "ㅂ";
                    break;
                case "ㅂ":
                    parArr[0] = result; parArr[1] = "ㅅ";
                    break;                            
                case "ㅅ":                             
                    parArr[0] = result; parArr[1] = "ㅇ";
                    break;                             
                case "ㅇ":                             
                    parArr[0] = result; parArr[1] = "ㅈ";
                    break;                             
                case "ㅈ":                             
                    parArr[0] = result; parArr[1] = "ㅊ";
                    break;                             
                case "ㅊ":                             
                    parArr[0] = result; parArr[1] = "ㅋ";
                    break;                             
                case "ㅋ":                             
                    parArr[0] = result; parArr[1] = "ㅌ";
                    break;                             
                case "ㅌ":                             
                    parArr[0] = result; parArr[1] = "ㅍ";
                    break;                             
                case "ㅍ":                             
                    parArr[0] = result; parArr[1] = "ㅎ";
                    break;
                case "ㅎ":
                    parArr[0] = result; parArr[1] = "ㅎ";
                    break;
                default:
                    break;
            }

            DataTable table = DBconnection(parArr);
            Display(table);
        }

        private void btn_Pick_Click(object sender, EventArgs e)
        {
            try
            {
                var name = gridView.SelectedRows[0].Cells["이름"].Value.ToString();
                var gifts = gridView.SelectedRows[0].Cells["사은품"].Value.ToString();
                var restaurant = gridView.SelectedRows[0].Cells["맛집"].Value.ToString();
                var lodging = gridView.SelectedRows[0].Cells["숙박"].Value.ToString();
                var tour = gridView.SelectedRows[0].Cells["여행지혜택"].Value.ToString();

                string[] str = { name, gifts, restaurant,lodging };
                send(str);
                Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("지역을 선택해주셔야 합니다.");
                //MessageBox.Show(x.StackTrace +"\n"+x.Message);
                return;
            }
        }

        private void FrmPickArea_MouseLeave(object sender, EventArgs e)
        {
            //this.Size = new Size(800, 286);
            
        }


    }
}
