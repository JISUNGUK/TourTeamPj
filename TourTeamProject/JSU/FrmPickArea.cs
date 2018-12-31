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
            string mysqlConStr = ConfigurationManager.ConnectionStrings["DBConStr"].ConnectionString;

            //using (SqlConnection con = new SqlConnection(conStr))
            using (MySql.Data.MySqlClient.MySqlConnection mysqlCon = new MySql.Data.MySqlClient.MySqlConnection(mysqlConStr))
            {
                mysqlCon.Open();
                MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                mySqlCommand.Connection = mysqlCon;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "InitialSearch";
                mySqlCommand.Parameters.AddWithValue("one_num", arr[0]);
                mySqlCommand.Parameters.AddWithValue("two_num", arr[1]);

                #region mssql서버부 이제안씀!
                //con.Open();
                //SqlCommand com = new SqlCommand();
                //com.Connection = con;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "InitialSearch";
                //com.Parameters.AddWithValue("@one", arr[0]);
                //com.Parameters.AddWithValue("@two", arr[1]); 
                #endregion

                DataTable table = new DataTable();
                table.Columns.AddRange
                    (new DataColumn[] { new DataColumn("이름"), new DataColumn("사은품"), new DataColumn("맛집"),
                    new DataColumn("숙박"), new DataColumn("여행지혜택")});

                var dr = mySqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = table.NewRow();
                    row["이름"] = dr["name"].ToString();
                    row["사은품"] = dr["gifts"].ToString();
                    row["맛집"] = dr["restaurant"].ToString();
                    row["숙박"] = dr["lodging"].ToString();
                    row["여행지혜택"] = dr["tour"].ToString();

                    table.Rows.Add(row);

                    //Mssql_To_MySql_Convert(mysqlCon, dr);   //  Mysql로 내보냄
                }
                return table;
            }
        }

        /// <summary>
        /// Mssql DB의 내용을 읽어 MySql로 내보낸다.
        /// </summary>
        /// <param name="mysqlCon"></param>
        /// <param name="dr"></param>
        private static void Mssql_To_MySql_Convert(MySql.Data.MySqlClient.MySqlConnection mysqlCon, SqlDataReader dr)
        {
            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand.Connection = mysqlCon;
            mySqlCommand.CommandText = "INSERT INTO `Goodee`.`areas`(`name`,`gifts`,`restaurant`,`tour`,`lodging`)" +
                "VALUES('" + dr["name"].ToString() + "','" + dr["gifts"].ToString() + "','" + dr["restaurant"].ToString() + "','" + dr["tour"].ToString() + "','" + dr["lodging"].ToString() + "');";

            mySqlCommand.ExecuteNonQuery();
        }

        private void btn_ㅎ_Click(object sender, EventArgs e)
        {
            //  1. 폼 사이즈 늘리고
            //  2. 이벤트 sender에서 컨트롤의 이름을 가져옴
            //  3. InitialSearch 로 초성검색해서 데이터테이블 반환
            //  3. 그리드뷰 초기화 하고 다시 데이터소스 넣기~
            
            //gridView.DataSource = DBconnection("ㄱ","ㄴ");

            var clickname = sender.ToString();
            var result = sender.ToString().Replace(" ", "").Substring(clickname.LastIndexOf(":"));  // 버튼의 값을 가져옴
            
            //MessageBox.Show(result.ToString());
            this.Size = new Size(800, 653);

            string[] parArr = new string[2];

            switch (result)
            {
                case "ㄱ":
                    parArr[0] = "가"; parArr[1] = "나";
                    break;
                case "ㄴ":
                    parArr[0] = "나"; parArr[1] = "다";
                    break;
                case "ㄷ":
                    parArr[0] = "다"; parArr[1] = "라";
                    break;
                case "ㄹ":
                    parArr[0] = "라"; parArr[1] = "마";
                    break;
                case "ㅁ":
                    parArr[0] = "마"; parArr[1] = "바";
                    break;
                case "ㅂ":
                    parArr[0] = "바"; parArr[1] = "사";
                    break;                            
                case "ㅅ":                             
                    parArr[0] = "사"; parArr[1] = "아";
                    break;                             
                case "ㅇ":                             
                    parArr[0] = "아"; parArr[1] = "자";
                    break;                             
                case "ㅈ":                             
                    parArr[0] = "자"; parArr[1] = "차";
                    break;                             
                case "ㅊ":                             
                    parArr[0] = "차"; parArr[1] = "카";
                    break;                             
                case "ㅋ":                             
                    parArr[0] = "카"; parArr[1] = "타";
                    break;                             
                case "ㅌ":                             
                    parArr[0] = "타"; parArr[1] = "파";
                    break;                             
                case "ㅍ":                             
                    parArr[0] = "파"; parArr[1] = "하";
                    break;
                case "ㅎ":
                    parArr[0] = "하"; parArr[1] = "하";
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
                return;
            }
        }
    }
}
