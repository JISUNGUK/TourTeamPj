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
    public partial class FormTouristInformationByRegion : MetroFramework.Forms.MetroForm
    {
        private string authenticationKey = "70i7ZBjwMhQcgYsy9HnYEEXv%2FXQ5MxlEHeHcsNd17WY8r%2Fl57uRYryqyC93hdqLDj5WgQ5GwgvA0pgV9sCKcAQ%3D%3D"; // 인증키입니다.
        private string tourType = String.Empty; // 관광타입입니다.
        private string service1 = String.Empty; // 서비스분류1입니다.
        private string service2 = String.Empty; // 서비스분류2입니다.
        private string service3 = String.Empty; // 서비스분류3입니다.
        private string areaCode = String.Empty; // 지역입니다.

        private List<TourSk> listTourSk;

        string jsonString = String.Empty;

        private int currentPage = 1; // 현재 페이지 번호입니다.
        private int totalPage = 0; // 전체 페이지 수입니다.

        public FormTouristInformationByRegion()
        {
            InitializeComponent();
        }

        private void FormTouristInformationByRegion_Load(object sender, EventArgs e)
        {
            listTourSk = new List<TourSk>();

            CmbService1.Items.Add("대분류");
            CmbService2.Items.Add("중분류");
            CmbService3.Items.Add("소분류");
            CmbRegion2.Items.Add("지역선택");

            CmbType.SelectedIndex = 0;
            CmbService1.SelectedIndex = 0;
            CmbService2.SelectedIndex = 0;
            CmbService3.SelectedIndex = 0;
            CmbRegion1.SelectedIndex = 0;
            CmbRegion2.SelectedIndex = 0;
        }

        /// <summary>
        /// 콤보박스의 아이템이 선택에 따라 바뀝니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;

            if (CmbType.Text == "타입선택")
            {
                tourType = "";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("자연");
                CmbService1.Items.Add("인문(문화/예술/역사)");
                CmbService1.Items.Add("레포츠");
                CmbService1.Items.Add("쇼핑");
                CmbService1.Items.Add("음식");
                CmbService1.Items.Add("숙박");
                CmbService1.Items.Add("추천코스");
            }
            if (CmbType.Text == "관광지")
            {
                tourType = "12";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("자연");
                CmbService1.Items.Add("인문(문화/예술/역사)");
            }
            if (CmbType.Text == "문화시설")
            {
                tourType = "14";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("인문(문화/예술/역사)");
            }
            if (CmbType.Text == "축제공연행사")
            {
                tourType = "15";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("인문(문화/예술/역사)");
            }
            if (CmbType.Text == "여행코스")
            {
                tourType = "25";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("추천코스");
            }
            if (CmbType.Text == "레포츠")
            {
                tourType = "28";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("레포츠");
            }
            if (CmbType.Text == "숙박")
            {
                tourType = "32";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("숙박");
            }
            if (CmbType.Text == "쇼핑")
            {
                tourType = "38";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("쇼핑");
            }
            if (CmbType.Text == "음식점")
            {
                tourType = "39";

                CmbService1.Items.Clear();
                CmbService1.Items.Add("대분류");
                CmbService1.Items.Add("음식");
            }

            CmbService1.SelectedIndex = 0;
        }

        private void CmbService1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            CmbService2.Enabled = true;

            if (CmbService1.Text == "대분류")
            {
                service1 = "";
                CmbService2.Enabled = false;
            }
            if (CmbService1.Text == "자연")
            {
                service1 = "A01";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("자연관광지");
                CmbService2.Items.Add("관광자원");
            }
            if (CmbService1.Text == "인문(문화/예술/역사)")
            {
                service1 = "A02";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("역사관광지");
                CmbService2.Items.Add("휴양관광지");
                CmbService2.Items.Add("체험관광지");
                CmbService2.Items.Add("산업관광지");
                CmbService2.Items.Add("건축/조형물");
                CmbService2.Items.Add("문화시설");
                CmbService2.Items.Add("축제");
                CmbService2.Items.Add("공연/행사");
            }
            if (CmbService1.Text == "레포츠")
            {
                service1 = "A03";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("레포츠소개");
                CmbService2.Items.Add("육상 레포츠");
                CmbService2.Items.Add("수상 레포츠");
                CmbService2.Items.Add("항공 레포츠");
                CmbService2.Items.Add("복합 레포츠");
            }
            if (CmbService1.Text == "쇼핑")
            {
                service1 = "A04";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("쇼핑");
            }
            if (CmbService1.Text == "음식")
            {
                service1 = "A05";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("음식점");
            }
            if (CmbService1.Text == "숙박")
            {
                service1 = "B02";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("숙박시설");
            }
            if (CmbService1.Text == "추천코스")
            {
                service1 = "C01";

                CmbService2.Items.Clear();
                CmbService2.Items.Add("중분류");
                CmbService2.Items.Add("가족코스");
                CmbService2.Items.Add("나홀로코스");
                CmbService2.Items.Add("힐링코스");
                CmbService2.Items.Add("도보코스");
                CmbService2.Items.Add("캠핑코스");
                CmbService2.Items.Add("맛코스");
            }

            CmbService2.SelectedIndex = 0;
        }

        private void CmbService2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbService3.Enabled = true;

            if (CmbService2.Text == "중분류")
            {
                service2 = "";
                CmbService3.Enabled = false;
            }
            if (CmbService2.Text == "자연관광지")
            {
                service2 = "A0101";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("국립공원");
                CmbService3.Items.Add("도립공원");
                CmbService3.Items.Add("군립공원");
                CmbService3.Items.Add("산");
                CmbService3.Items.Add("자연생태관광지");
                CmbService3.Items.Add("자연휴양림");
                CmbService3.Items.Add("수목원");
                CmbService3.Items.Add("폭포");
                CmbService3.Items.Add("계곡");
                CmbService3.Items.Add("약수터");
                CmbService3.Items.Add("해안절경");
                CmbService3.Items.Add("해수욕장");
                CmbService3.Items.Add("섬");
                CmbService3.Items.Add("항구/포구");
                CmbService3.Items.Add("어촌");
                CmbService3.Items.Add("등대");
                CmbService3.Items.Add("호수");
                CmbService3.Items.Add("강");
                CmbService3.Items.Add("동굴");
            }
            if (CmbService2.Text == "관광자원")
            {
                service2 = "A0102";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("희귀동. 식물");
                CmbService3.Items.Add("기암괴석");
            }
            if (CmbService2.Text == "역사관광지")
            {
                service2 = "A0201";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("고궁");
                CmbService3.Items.Add("성");
                CmbService3.Items.Add("문");
                CmbService3.Items.Add("고택");
                CmbService3.Items.Add("생가");
                CmbService3.Items.Add("민속마을");
                CmbService3.Items.Add("유적지/사적지");
                CmbService3.Items.Add("사찰");
                CmbService3.Items.Add("종교성지");
                CmbService3.Items.Add("안보관광");
            }
            if (CmbService2.Text == "휴양관광지")
            {
                service2 = "A0202";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("유원지");
                CmbService3.Items.Add("관광단지");
                CmbService3.Items.Add("온천/욕장/스파");
                CmbService3.Items.Add("이색찜질방");
                CmbService3.Items.Add("헬스투어");
                CmbService3.Items.Add("테마공원");
                CmbService3.Items.Add("공원");
                CmbService3.Items.Add("유람선/잠수함관광");
            }
            if (CmbService2.Text == "체험관광지")
            {
                service2 = "A0203";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("농. 산. 어촌 체험");
                CmbService3.Items.Add("전통체험");
                CmbService3.Items.Add("산사체험");
                CmbService3.Items.Add("이색체험");
                CmbService3.Items.Add("관광농원");
                CmbService3.Items.Add("이색거리");
            }
            if (CmbService2.Text == "산업관광지")
            {
                service2 = "A0204";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("제철소");
                CmbService3.Items.Add("조선소");
                CmbService3.Items.Add("공단");
                CmbService3.Items.Add("발전소");
                CmbService3.Items.Add("광산");
                CmbService3.Items.Add("식음료");
                CmbService3.Items.Add("화학/금속");
                CmbService3.Items.Add("기타");
                CmbService3.Items.Add("전자/반도체");
                CmbService3.Items.Add("자동차");
            }
            if (CmbService2.Text == "건축/조형물")
            {
                service2 = "A0205";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("다리/대교");
                CmbService3.Items.Add("기념탑/기념비/전망대");
                CmbService3.Items.Add("분수");
                CmbService3.Items.Add("동상");
                CmbService3.Items.Add("터널");
                CmbService3.Items.Add("유명건물");
            }
            if (CmbService2.Text == "문화시설")
            {
                service2 = "A0206";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("박물관");
                CmbService3.Items.Add("기념관");
                CmbService3.Items.Add("전시관");
                CmbService3.Items.Add("컨벤션센터");
                CmbService3.Items.Add("미술관/화랑");
                CmbService3.Items.Add("공연장");
                CmbService3.Items.Add("문화원");
                CmbService3.Items.Add("외국문화원");
                CmbService3.Items.Add("도서관");
                CmbService3.Items.Add("대형서점");
                CmbService3.Items.Add("문화전수시설");
                CmbService3.Items.Add("영화관");
                CmbService3.Items.Add("어학당");
                CmbService3.Items.Add("학교");
            }
            if (CmbService2.Text == "축제")
            {
                service2 = "A0207";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("문화관광축제");
                CmbService3.Items.Add("일반축제");
            }
            if (CmbService2.Text == "공연/행사")
            {
                service2 = "A0208";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("전통공연");
                CmbService3.Items.Add("연극");
                CmbService3.Items.Add("뮤지컬");
                CmbService3.Items.Add("오페라");
                CmbService3.Items.Add("전시회");
                CmbService3.Items.Add("박람회");
                CmbService3.Items.Add("컨벤션");
                CmbService3.Items.Add("무용");
                CmbService3.Items.Add("클래식음악회");
                CmbService3.Items.Add("대중콘서트");
                CmbService3.Items.Add("영화");
                CmbService3.Items.Add("스포츠경기");
                CmbService3.Items.Add("기타행사");
            }
            if (CmbService2.Text == "레포츠소개")
            {
                service2 = "A0301";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("육상레포츠");
                CmbService3.Items.Add("수상레포츠");
                CmbService3.Items.Add("항공레포츠");
            }
            if (CmbService2.Text == "육상 레포츠")
            {
                service2 = "A0302";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("스포츠센터");
                CmbService3.Items.Add("수련시설");
                CmbService3.Items.Add("경기장");
                CmbService3.Items.Add("인라인(실내 인라인 포함)");
                CmbService3.Items.Add("자전거하이킹");
                CmbService3.Items.Add("카트");
                CmbService3.Items.Add("골프");
                CmbService3.Items.Add("경마");
                CmbService3.Items.Add("경륜");
                CmbService3.Items.Add("카지노");
                CmbService3.Items.Add("승마");
                CmbService3.Items.Add("스키/스노보드");
                CmbService3.Items.Add("스케이트");
                CmbService3.Items.Add("썰매장");
                CmbService3.Items.Add("수렵장");
                CmbService3.Items.Add("사격장");
                CmbService3.Items.Add("야영장,오토캠핑장");
                CmbService3.Items.Add("암벽등반");
                CmbService3.Items.Add("빙벽등반");
                CmbService3.Items.Add("서바이벌게임");
                CmbService3.Items.Add("ATV");
                CmbService3.Items.Add("MTB");
                CmbService3.Items.Add("오프로드");
                CmbService3.Items.Add("번지점프");
                CmbService3.Items.Add("자동차경주");
                CmbService3.Items.Add("스키(보드) 렌탈샵");
                CmbService3.Items.Add("트래킹");
            }
            if (CmbService2.Text == "수상 레포츠")
            {
                service2 = "A0303";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("윈드서핑/제트스키");
                CmbService3.Items.Add("카약/카누");
                CmbService3.Items.Add("요트");
                CmbService3.Items.Add("스노쿨링/스킨스쿠버다이빙");
                CmbService3.Items.Add("민물낚시");
                CmbService3.Items.Add("바다낚시");
                CmbService3.Items.Add("수영");
                CmbService3.Items.Add("래프팅");
            }
            if (CmbService2.Text == "항공 레포츠")
            {
                service2 = "A0304";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("스카이다이빙");
                CmbService3.Items.Add("초경량비행");
                CmbService3.Items.Add("헹글라이딩/패러글라이딩");
                CmbService3.Items.Add("열기구");
            }
            if (CmbService2.Text == "복합 레포츠")
            {
                service2 = "A0305";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("복합 레포츠");
            }
            if (CmbService2.Text == "쇼핑")
            {
                service2 = "A0401";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("5일장");
                CmbService3.Items.Add("상설시장");
                CmbService3.Items.Add("백화점");
                CmbService3.Items.Add("면세점");
                CmbService3.Items.Add("할인매장");
                CmbService3.Items.Add("전문상가");
                CmbService3.Items.Add("공예,공방");
                CmbService3.Items.Add("관광기념품점");
                CmbService3.Items.Add("특산물판매점");
            }
            if (CmbService2.Text == "음식점")
            {
                service2 = "A0502";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("한식");
                CmbService3.Items.Add("서양식");
                CmbService3.Items.Add("일식");
                CmbService3.Items.Add("중식");
                CmbService3.Items.Add("아시아식");
                CmbService3.Items.Add("패밀리레스토랑");
                CmbService3.Items.Add("이색음식점");
                CmbService3.Items.Add("채식전문점");
                CmbService3.Items.Add("바/까페");
                CmbService3.Items.Add("클럽");
            }
            if (CmbService2.Text == "숙박시설")
            {
                service2 = "B0201";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("관광호텔");
                CmbService3.Items.Add("수상관광호텔");
                CmbService3.Items.Add("전통호텔");
                CmbService3.Items.Add("가족호텔");
                CmbService3.Items.Add("콘도미니엄");
                CmbService3.Items.Add("유스호스텔");
                CmbService3.Items.Add("펜션");
                CmbService3.Items.Add("여관");
                CmbService3.Items.Add("모텔");
                CmbService3.Items.Add("민박");
                CmbService3.Items.Add("게스트하우스");
                CmbService3.Items.Add("홈스테이");
                CmbService3.Items.Add("서비스드레지던스");
                CmbService3.Items.Add("의료관광호텔");
                CmbService3.Items.Add("소형호텔");
                CmbService3.Items.Add("한옥스테이");
            }
            if (CmbService2.Text == "가족코스")
            {
                service2 = "C0112";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("가족코스");
            }
            if (CmbService2.Text == "나홀로코스")
            {
                service2 = "C0113";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("나홀로코스");
            }
            if (CmbService2.Text == "힐링코스")
            {
                service2 = "C0114";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("힐링코스");
            }
            if (CmbService2.Text == "도보코스")
            {
                service2 = "C0115";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("도보코스");
            }
            if (CmbService2.Text == "캠핑코스")
            {
                service2 = "C0116";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("캠핑코스");
            }
            if (CmbService2.Text == "맛코스")
            {
                service2 = "C0117";

                CmbService3.Items.Clear();
                CmbService3.Items.Add("소분류");
                CmbService3.Items.Add("맛코스");
            }

            CmbService3.SelectedIndex = 0;
        }

        private void CmbService3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbService3.Text == "소분류")
            {
                service3 = "";
            }
            if (CmbService3.Text == "국립공원")
            {
                service3 = "A01010100";
            }
            if (CmbService3.Text == "도립공원")
            {
                service3 = "A01010200";
            }
            if (CmbService3.Text == "군립공원")
            {
                service3 = "A01010300";
            }
            if (CmbService3.Text == "산")
            {
                service3 = "A01010400";
            }
            if (CmbService3.Text == "자연생태관광지")
            {
                service3 = "A01010500";
            }
            if (CmbService3.Text == "자연휴양림")
            {
                service3 = "A01010600";
            }
            if (CmbService3.Text == "수목원")
            {
                service3 = "A01010700";
            }
            if (CmbService3.Text == "폭포")
            {
                service3 = "A01010800";
            }
            if (CmbService3.Text == "계곡")
            {
                service3 = "A01010900";
            }
            if (CmbService3.Text == "약수터")
            {
                service3 = "A01011000";
            }
            if (CmbService3.Text == "해안절경")
            {
                service3 = "A01011100";
            }
            if (CmbService3.Text == "해수욕장")
            {
                service3 = "A01011200";
            }
            if (CmbService3.Text == "섬")
            {
                service3 = "A01011300";
            }
            if (CmbService3.Text == "항구/포구")
            {
                service3 = "A01011400";
            }
            if (CmbService3.Text == "어촌")
            {
                service3 = "A01011500";
            }
            if (CmbService3.Text == "등대")
            {
                service3 = "A01011600";
            }
            if (CmbService3.Text == "호수")
            {
                service3 = "A01011700";
            }
            if (CmbService3.Text == "강")
            {
                service3 = "A01011800";
            }
            if (CmbService3.Text == "동굴")
            {
                service3 = "A01011900";
            }
            if (CmbService3.Text == "희귀동. 식물")
            {
                service3 = "A01020100";
            }
            if (CmbService3.Text == "기암괴석")
            {
                service3 = "A01020200";
            }
            if (CmbService3.Text == "고궁")
            {
                service3 = "A02010100";
            }
            if (CmbService3.Text == "성")
            {
                service3 = "A02010200";
            }
            if (CmbService3.Text == "문")
            {
                service3 = "A02010300";
            }
            if (CmbService3.Text == "고택")
            {
                service3 = "A02010400";
            }
            if (CmbService3.Text == "생가")
            {
                service3 = "A02010500";
            }
            if (CmbService3.Text == "민속마을")
            {
                service3 = "A02010600";
            }
            if (CmbService3.Text == "유적지/사적지")
            {
                service3 = "A02010700";
            }
            if (CmbService3.Text == "사찰")
            {
                service3 = "A02010800";
            }
            if (CmbService3.Text == "종교성지")
            {
                service3 = "A02010900";
            }
            if (CmbService3.Text == "안보관광")
            {
                service3 = "A02011000";
            }
            if (CmbService3.Text == "유원지")
            {
                service3 = "A02020100";
            }
            if (CmbService3.Text == "관광단지")
            {
                service3 = "A02020200";
            }
            if (CmbService3.Text == "온천/욕장/스파")
            {
                service3 = "A02020300";
            }
            if (CmbService3.Text == "이색찜질방")
            {
                service3 = "A02020400";
            }
            if (CmbService3.Text == "헬스투어")
            {
                service3 = "A02020500";
            }
            if (CmbService3.Text == "테마공원")
            {
                service3 = "A02020600";
            }
            if (CmbService3.Text == "공원")
            {
                service3 = "A02020700";
            }
            if (CmbService3.Text == "유람선/잠수함관광")
            {
                service3 = "A02020800";
            }
            if (CmbService3.Text == "농. 산. 어촌 체험")
            {
                service3 = "A02030100";
            }
            if (CmbService3.Text == "전통체험")
            {
                service3 = "A02030200";
            }
            if (CmbService3.Text == "산사체험")
            {
                service3 = "A02030300";
            }
            if (CmbService3.Text == "이색체험")
            {
                service3 = "A02030400";
            }
            if (CmbService3.Text == "관광농원")
            {
                service3 = "A02030500";
            }
            if (CmbService3.Text == "이색거리")
            {
                service3 = "A02030600";
            }
            if (CmbService3.Text == "제철소")
            {
                service3 = "A02040100";
            }
            if (CmbService3.Text == "조선소")
            {
                service3 = "A02040200";
            }
            if (CmbService3.Text == "공단")
            {
                service3 = "A02040300";
            }
            if (CmbService3.Text == "발전소")
            {
                service3 = "A02040400";
            }
            if (CmbService3.Text == "광산")
            {
                service3 = "A02040500";
            }
            if (CmbService3.Text == "식음료")
            {
                service3 = "A02040600";
            }
            if (CmbService3.Text == "화학/금속")
            {
                service3 = "A02040700";
            }
            if (CmbService3.Text == "기타")
            {
                service3 = "A02040800";
            }
            if (CmbService3.Text == "전자/반도체")
            {
                service3 = "A02040900";
            }
            if (CmbService3.Text == "자동차")
            {
                service3 = "A02041000";
            }
            if (CmbService3.Text == "다리/대교")
            {
                service3 = "A02050100";
            }
            if (CmbService3.Text == "기념탑/기념비/전망대")
            {
                service3 = "A02050200";
            }
            if (CmbService3.Text == "분수")
            {
                service3 = "A02050300";
            }
            if (CmbService3.Text == "동상")
            {
                service3 = "A02050400";
            }
            if (CmbService3.Text == "터널")
            {
                service3 = "A02050500";
            }
            if (CmbService3.Text == "유명건물")
            {
                service3 = "A02050600";
            }
            if (CmbService3.Text == "박물관")
            {
                service3 = "A02060100";
            }
            if (CmbService3.Text == "기념관")
            {
                service3 = "A02060200";
            }
            if (CmbService3.Text == "전시관")
            {
                service3 = "A02060300";
            }
            if (CmbService3.Text == "컨벤션센터")
            {
                service3 = "A02060400";
            }
            if (CmbService3.Text == "미술관/화랑")
            {
                service3 = "A02060500";
            }
            if (CmbService3.Text == "공연장")
            {
                service3 = "A02060600";
            }
            if (CmbService3.Text == "문화원")
            {
                service3 = "A02060700";
            }
            if (CmbService3.Text == "외국문화원")
            {
                service3 = "A02060800";
            }
            if (CmbService3.Text == "도서관")
            {
                service3 = "A02060900";
            }
            if (CmbService3.Text == "대형서점")
            {
                service3 = "A02061000";
            }
            if (CmbService3.Text == "문화전수시설")
            {
                service3 = "A02061100";
            }
            if (CmbService3.Text == "영화관")
            {
                service3 = "A02061200";
            }
            if (CmbService3.Text == "어학당")
            {
                service3 = "A02061300";
            }
            if (CmbService3.Text == "학교")
            {
                service3 = "A02061400";
            }
            if (CmbService3.Text == "문화관광축제")
            {
                service3 = "A02070100";
            }
            if (CmbService3.Text == "일반축제")
            {
                service3 = "A02070200";
            }
            if (CmbService3.Text == "전통공연")
            {
                service3 = "A02080100";
            }
            if (CmbService3.Text == "연극")
            {
                service3 = "A02080200";
            }
            if (CmbService3.Text == "뮤지컬")
            {
                service3 = "A02080300";
            }
            if (CmbService3.Text == "오페라")
            {
                service3 = "A02080400";
            }
            if (CmbService3.Text == "전시회")
            {
                service3 = "A02080500";
            }
            if (CmbService3.Text == "박람회")
            {
                service3 = "A02080600";
            }
            if (CmbService3.Text == "컨벤션")
            {
                service3 = "A02080700";
            }
            if (CmbService3.Text == "무용")
            {
                service3 = "A02080800";
            }
            if (CmbService3.Text == "클래식음악회")
            {
                service3 = "A02080900";
            }
            if (CmbService3.Text == "대중콘서트")
            {
                service3 = "A02081000";
            }
            if (CmbService3.Text == "영화")
            {
                service3 = "A02081100";
            }
            if (CmbService3.Text == "스포츠경기")
            {
                service3 = "A02081200";
            }
            if (CmbService3.Text == "기타행사")
            {
                service3 = "A02081300";
            }
            if (CmbService3.Text == "육상레포츠")
            {
                service3 = "A03010100";
            }
            if (CmbService3.Text == "수상레포츠")
            {
                service3 = "A03010200";
            }
            if (CmbService3.Text == "항공레포츠")
            {
                service3 = "A03010300";
            }
            if (CmbService3.Text == "스포츠센터")
            {
                service3 = "A03020100";
            }
            if (CmbService3.Text == "수련시설")
            {
                service3 = "A03020200";
            }
            if (CmbService3.Text == "경기장")
            {
                service3 = "A03020300";
            }
            if (CmbService3.Text == "인라인(실내 인라인 포함)")
            {
                service3 = "A03020400";
            }
            if (CmbService3.Text == "자전거하이킹")
            {
                service3 = "A03020500";
            }
            if (CmbService3.Text == "카트")
            {
                service3 = "A03020600";
            }
            if (CmbService3.Text == "골프")
            {
                service3 = "A03020700";
            }
            if (CmbService3.Text == "경마")
            {
                service3 = "A03020800";
            }
            if (CmbService3.Text == "경륜")
            {
                service3 = "A03020900";
            }
            if (CmbService3.Text == "카지노")
            {
                service3 = "A03021000";
            }
            if (CmbService3.Text == "승마")
            {
                service3 = "A03021100";
            }
            if (CmbService3.Text == "스키/스노보드")
            {
                service3 = "A03021200";
            }
            if (CmbService3.Text == "스케이트")
            {
                service3 = "A03021300";
            }
            if (CmbService3.Text == "썰매장")
            {
                service3 = "A03021400";
            }
            if (CmbService3.Text == "수렵장")
            {
                service3 = "A03021500";
            }
            if (CmbService3.Text == "사격장")
            {
                service3 = "A03021600";
            }
            if (CmbService3.Text == "야영장,오토캠핑장")
            {
                service3 = "A03021700";
            }
            if (CmbService3.Text == "암벽등반")
            {
                service3 = "A03021800";
            }
            if (CmbService3.Text == "빙벽등반")
            {
                service3 = "A03021900";
            }
            if (CmbService3.Text == "서바이벌게임")
            {
                service3 = "A03022000";
            }
            if (CmbService3.Text == "ATV")
            {
                service3 = "A03022100";
            }
            if (CmbService3.Text == "MTB")
            {
                service3 = "A03022200";
            }
            if (CmbService3.Text == "오프로드")
            {
                service3 = "A03022300";
            }
            if (CmbService3.Text == "번지점프")
            {
                service3 = "A03022400";
            }
            if (CmbService3.Text == "자동차경주")
            {
                service3 = "A03022500";
            }
            if (CmbService3.Text == "스키(보드) 렌탈샵")
            {
                service3 = "A03022600";
            }
            if (CmbService3.Text == "트래킹")
            {
                service3 = "A03022700";
            }
            if (CmbService3.Text == "윈드서핑/제트스키")
            {
                service3 = "A03030100";
            }
            if (CmbService3.Text == "카약/카누")
            {
                service3 = "A03030200";
            }
            if (CmbService3.Text == "요트")
            {
                service3 = "A03030300";
            }
            if (CmbService3.Text == "스노쿨링/스킨스쿠버다이빙")
            {
                service3 = "A03030400";
            }
            if (CmbService3.Text == "민물낚시")
            {
                service3 = "A03030500";
            }
            if (CmbService3.Text == "바다낚시")
            {
                service3 = "A03030600";
            }
            if (CmbService3.Text == "수영")
            {
                service3 = "A03030700";
            }
            if (CmbService3.Text == "래프팅")
            {
                service3 = "A03030800";
            }
            if (CmbService3.Text == "스카이다이빙")
            {
                service3 = "A03040100";
            }
            if (CmbService3.Text == "초경량비행")
            {
                service3 = "A03040200";
            }
            if (CmbService3.Text == "헹글라이딩/패러글라이딩")
            {
                service3 = "A03040300";
            }
            if (CmbService3.Text == "열기구")
            {
                service3 = "A03040400";
            }
            if (CmbService3.Text == "복합 레포츠")
            {
                service3 = "A03050100";
            }
            if (CmbService3.Text == "5일장")
            {
                service3 = "A04010100";
            }
            if (CmbService3.Text == "상설시장")
            {
                service3 = "A04010200";
            }
            if (CmbService3.Text == "백화점")
            {
                service3 = "A04010300";
            }
            if (CmbService3.Text == "면세점")
            {
                service3 = "A04010400";
            }
            if (CmbService3.Text == "할인매장")
            {
                service3 = "A04010500";
            }
            if (CmbService3.Text == "전문상가")
            {
                service3 = "A04010600";
            }
            if (CmbService3.Text == "공예,공방")
            {
                service3 = "A04010700";
            }
            if (CmbService3.Text == "관광기념품점")
            {
                service3 = "A04010800";
            }
            if (CmbService3.Text == "특산물판매점")
            {
                service3 = "A04010900";
            }
            if (CmbService3.Text == "한식")
            {
                service3 = "A05020100";
            }
            if (CmbService3.Text == "서양식")
            {
                service3 = "A05020200";
            }
            if (CmbService3.Text == "일식")
            {
                service3 = "A05020300";
            }
            if (CmbService3.Text == "중식")
            {
                service3 = "A05020400";
            }
            if (CmbService3.Text == "아시아식")
            {
                service3 = "A05020500";
            }
            if (CmbService3.Text == "패밀리레스토랑")
            {
                service3 = "A05020600";
            }
            if (CmbService3.Text == "이색음식점")
            {
                service3 = "A05020700";
            }
            if (CmbService3.Text == "채식전문점")
            {
                service3 = "A05020800";
            }
            if (CmbService3.Text == "바/까페")
            {
                service3 = "A05020900";
            }
            if (CmbService3.Text == "클럽")
            {
                service3 = "A05021000";
            }
            if (CmbService3.Text == "관광호텔")
            {
                service3 = "B02010100";
            }
            if (CmbService3.Text == "수상관광호텔")
            {
                service3 = "B02010200";
            }
            if (CmbService3.Text == "전통호텔")
            {
                service3 = "B02010300";
            }
            if (CmbService3.Text == "가족호텔")
            {
                service3 = "B02010400";
            }
            if (CmbService3.Text == "콘도미니엄")
            {
                service3 = "B02010500";
            }
            if (CmbService3.Text == "유스호스텔")
            {
                service3 = "B02010600";
            }
            if (CmbService3.Text == "펜션")
            {
                service3 = "B02010700";
            }
            if (CmbService3.Text == "여관")
            {
                service3 = "B02010800";
            }
            if (CmbService3.Text == "모텔")
            {
                service3 = "B02010900";
            }
            if (CmbService3.Text == "민박")
            {
                service3 = "B02011000";
            }
            if (CmbService3.Text == "게스트하우스")
            {
                service3 = "B02011100";
            }
            if (CmbService3.Text == "홈스테이")
            {
                service3 = "B02011200";
            }
            if (CmbService3.Text == "서비스드레지던스")
            {
                service3 = "B02011300";
            }
            if (CmbService3.Text == "의료관광호텔")
            {
                service3 = "B02011400";
            }
            if (CmbService3.Text == "소형호텔")
            {
                service3 = "B02011500";
            }
            if (CmbService3.Text == "한옥스테이")
            {
                service3 = "B02011600";
            }
            if (CmbService3.Text == "가족코스")
            {
                service3 = "C01120001";
            }
            if (CmbService3.Text == "나홀로코스")
            {
                service3 = "C01130001";
            }
            if (CmbService3.Text == "힐링코스")
            {
                service3 = "C01140001";
            }
            if (CmbService3.Text == "도보코스")
            {
                service3 = "C01150001";
            }
            if (CmbService3.Text == "캠핑코스")
            {
                service3 = "C01160001";
            }
            if (CmbService3.Text == "맛코스")
            {
                service3 = "C01170001";
            }
        }

        private void CmbRegion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            //CmbRegion2.Enabled = true;

            if (CmbRegion1.Text == "지역선택")
            {
                areaCode = "";
                CmbRegion2.Enabled = false;

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
            }
            if (CmbRegion1.Text == "서울")
            {
                areaCode = "1";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("강남구");
                CmbRegion2.Items.Add("강동구");
                CmbRegion2.Items.Add("강북구");
                CmbRegion2.Items.Add("강서구");
                CmbRegion2.Items.Add("관악구");
                CmbRegion2.Items.Add("광진구");
                CmbRegion2.Items.Add("구로구");
                CmbRegion2.Items.Add("금천구");
                CmbRegion2.Items.Add("노원구");
                CmbRegion2.Items.Add("도봉구");
                CmbRegion2.Items.Add("동대문구");
                CmbRegion2.Items.Add("동작구");
                CmbRegion2.Items.Add("마포구");
                CmbRegion2.Items.Add("서대문구");
                CmbRegion2.Items.Add("서초구");
                CmbRegion2.Items.Add("성동구");
                CmbRegion2.Items.Add("성북구");
                CmbRegion2.Items.Add("송파구");
                CmbRegion2.Items.Add("양천구");
                CmbRegion2.Items.Add("영등포구");
                CmbRegion2.Items.Add("용산구");
                CmbRegion2.Items.Add("은평구");
                CmbRegion2.Items.Add("종로구");
                CmbRegion2.Items.Add("중구");
                CmbRegion2.Items.Add("중랑구");
            }
            if (CmbRegion1.Text == "인천")
            {
                areaCode = "2";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("강화군");
                CmbRegion2.Items.Add("계양구");
                CmbRegion2.Items.Add("남구");
                CmbRegion2.Items.Add("남동구");
                CmbRegion2.Items.Add("동구");
                CmbRegion2.Items.Add("부평구");
                CmbRegion2.Items.Add("서구");
                CmbRegion2.Items.Add("연수구");
                CmbRegion2.Items.Add("옹진군");
                CmbRegion2.Items.Add("중구");
            }
            if (CmbRegion1.Text == "대전")
            {
                areaCode = "3";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("대덕구");
                CmbRegion2.Items.Add("동구");
                CmbRegion2.Items.Add("서구");
                CmbRegion2.Items.Add("유성구");
                CmbRegion2.Items.Add("중구");
            }
            if (CmbRegion1.Text == "대구")
            {
                areaCode = "4";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("남구");
                CmbRegion2.Items.Add("달서구");
                CmbRegion2.Items.Add("달성군");
                CmbRegion2.Items.Add("동구");
                CmbRegion2.Items.Add("북구");
                CmbRegion2.Items.Add("서구");
                CmbRegion2.Items.Add("수성구");
                CmbRegion2.Items.Add("중구");
            }
            if (CmbRegion1.Text == "광주")
            {
                areaCode = "5";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("광산구");
                CmbRegion2.Items.Add("남구");
                CmbRegion2.Items.Add("동구");
                CmbRegion2.Items.Add("북구");
                CmbRegion2.Items.Add("서구");
            }
            if (CmbRegion1.Text == "부산")
            {
                areaCode = "6";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("강서구");
                CmbRegion2.Items.Add("금정구");
                CmbRegion2.Items.Add("기장군");
                CmbRegion2.Items.Add("남구");
                CmbRegion2.Items.Add("동구");
                CmbRegion2.Items.Add("동래구");
                CmbRegion2.Items.Add("부산진구");
                CmbRegion2.Items.Add("북구");
                CmbRegion2.Items.Add("사상구");
                CmbRegion2.Items.Add("사하구");
                CmbRegion2.Items.Add("서구");
                CmbRegion2.Items.Add("수영구");
                CmbRegion2.Items.Add("연제구");
                CmbRegion2.Items.Add("영도구");
                CmbRegion2.Items.Add("중구");
                CmbRegion2.Items.Add("해운대구");
            }
            if (CmbRegion1.Text == "울산")
            {
                areaCode = "7";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("중구");
                CmbRegion2.Items.Add("남구");
                CmbRegion2.Items.Add("동구");
                CmbRegion2.Items.Add("북구");
                CmbRegion2.Items.Add("울주군");
            }
            if (CmbRegion1.Text == "세종특별자치시")
            {
                areaCode = "8";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("세종특별자치시");
            }
            if (CmbRegion1.Text == "경기도")
            {
                areaCode = "31";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("가평군");
                CmbRegion2.Items.Add("고양시");
                CmbRegion2.Items.Add("과천시");
                CmbRegion2.Items.Add("광명시");
                CmbRegion2.Items.Add("광주시");
                CmbRegion2.Items.Add("구리시");
                CmbRegion2.Items.Add("군포시");
                CmbRegion2.Items.Add("김포시");
                CmbRegion2.Items.Add("남양주시");
                CmbRegion2.Items.Add("동두천시");
                CmbRegion2.Items.Add("부천시");
                CmbRegion2.Items.Add("성남시");
                CmbRegion2.Items.Add("수원시");
                CmbRegion2.Items.Add("시흥시");
                CmbRegion2.Items.Add("안산시");
                CmbRegion2.Items.Add("안성시");
                CmbRegion2.Items.Add("안양시");
                CmbRegion2.Items.Add("양주시");
                CmbRegion2.Items.Add("양평군");
                CmbRegion2.Items.Add("여주시");
                CmbRegion2.Items.Add("연천군");
                CmbRegion2.Items.Add("오산시");
                CmbRegion2.Items.Add("용인시");
                CmbRegion2.Items.Add("의왕시");
                CmbRegion2.Items.Add("의정부시");
                CmbRegion2.Items.Add("이천시");
                CmbRegion2.Items.Add("파주시");
                CmbRegion2.Items.Add("평택시");
                CmbRegion2.Items.Add("포천시");
                CmbRegion2.Items.Add("하남시");
                CmbRegion2.Items.Add("화성시");
            }
            if (CmbRegion1.Text == "강원도")
            {
                areaCode = "32";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("강릉시");
                CmbRegion2.Items.Add("고성군");
                CmbRegion2.Items.Add("동해시");
                CmbRegion2.Items.Add("삼척시");
                CmbRegion2.Items.Add("속초시");
                CmbRegion2.Items.Add("양구군");
                CmbRegion2.Items.Add("양양군");
                CmbRegion2.Items.Add("영월군");
                CmbRegion2.Items.Add("원주시");
                CmbRegion2.Items.Add("인제군");
                CmbRegion2.Items.Add("정선군");
                CmbRegion2.Items.Add("철원군");
                CmbRegion2.Items.Add("춘천시");
                CmbRegion2.Items.Add("태백시");
                CmbRegion2.Items.Add("평창군");
                CmbRegion2.Items.Add("홍천군");
                CmbRegion2.Items.Add("화천군");
                CmbRegion2.Items.Add("횡성군");
            }
            if (CmbRegion1.Text == "충청북도")
            {
                areaCode = "33";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("괴산군");
                CmbRegion2.Items.Add("단양군");
                CmbRegion2.Items.Add("보은군");
                CmbRegion2.Items.Add("영동군");
                CmbRegion2.Items.Add("옥천군");
                CmbRegion2.Items.Add("음성군");
                CmbRegion2.Items.Add("제천시");
                CmbRegion2.Items.Add("진천군");
                CmbRegion2.Items.Add("청원군");
                CmbRegion2.Items.Add("청주시");
                CmbRegion2.Items.Add("충주시");
                CmbRegion2.Items.Add("증평군");
            }
            if (CmbRegion1.Text == "충청남도")
            {
                areaCode = "34";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("공주시");
                CmbRegion2.Items.Add("금산군");
                CmbRegion2.Items.Add("논산시");
                CmbRegion2.Items.Add("당진시");
                CmbRegion2.Items.Add("보령시");
                CmbRegion2.Items.Add("부여군");
                CmbRegion2.Items.Add("서산시");
                CmbRegion2.Items.Add("서천군");
                CmbRegion2.Items.Add("아산시");
                CmbRegion2.Items.Add("예산군");
                CmbRegion2.Items.Add("천안시");
                CmbRegion2.Items.Add("청양군");
                CmbRegion2.Items.Add("태안군");
                CmbRegion2.Items.Add("홍성군");
                CmbRegion2.Items.Add("계룡시");
            }
            if (CmbRegion1.Text == "경상북도")
            {
                areaCode = "35";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("경산시");
                CmbRegion2.Items.Add("경주시");
                CmbRegion2.Items.Add("고령군");
                CmbRegion2.Items.Add("구미시");
                CmbRegion2.Items.Add("군위군");
                CmbRegion2.Items.Add("김천시");
                CmbRegion2.Items.Add("문경시");
                CmbRegion2.Items.Add("봉화군");
                CmbRegion2.Items.Add("상주시");
                CmbRegion2.Items.Add("성주군");
                CmbRegion2.Items.Add("안동시");
                CmbRegion2.Items.Add("영덕군");
                CmbRegion2.Items.Add("영양군");
                CmbRegion2.Items.Add("영주시");
                CmbRegion2.Items.Add("영천시");
                CmbRegion2.Items.Add("예천군");
                CmbRegion2.Items.Add("울릉군");
                CmbRegion2.Items.Add("울진군");
                CmbRegion2.Items.Add("의성군");
                CmbRegion2.Items.Add("청도군");
                CmbRegion2.Items.Add("청송군");
                CmbRegion2.Items.Add("칠곡군");
                CmbRegion2.Items.Add("포항시");
            }
            if (CmbRegion1.Text == "경상남도")
            {
                areaCode = "36";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("거제시");
                CmbRegion2.Items.Add("거창군");
                CmbRegion2.Items.Add("고성군");
                CmbRegion2.Items.Add("김해시");
                CmbRegion2.Items.Add("남해군");
                CmbRegion2.Items.Add("마산시");
                CmbRegion2.Items.Add("밀양시");
                CmbRegion2.Items.Add("사천시");
                CmbRegion2.Items.Add("산청군");
                CmbRegion2.Items.Add("양산시");
                CmbRegion2.Items.Add("의령군");
                CmbRegion2.Items.Add("진주시");
                CmbRegion2.Items.Add("진해시");
                CmbRegion2.Items.Add("창녕군");
                CmbRegion2.Items.Add("창원시");
                CmbRegion2.Items.Add("통영시");
                CmbRegion2.Items.Add("하동군");
                CmbRegion2.Items.Add("함안군");
                CmbRegion2.Items.Add("함양군");
                CmbRegion2.Items.Add("합천군");
            }
            if (CmbRegion1.Text == "전라북도")
            {
                areaCode = "37";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("고창군");
                CmbRegion2.Items.Add("군산시");
                CmbRegion2.Items.Add("김제시");
                CmbRegion2.Items.Add("남원시");
                CmbRegion2.Items.Add("무주군");
                CmbRegion2.Items.Add("부안군");
                CmbRegion2.Items.Add("순창군");
                CmbRegion2.Items.Add("완주군");
                CmbRegion2.Items.Add("익산시");
                CmbRegion2.Items.Add("임실군");
                CmbRegion2.Items.Add("장수군");
                CmbRegion2.Items.Add("전주시");
                CmbRegion2.Items.Add("정읍시");
                CmbRegion2.Items.Add("진안군");
            }
            if (CmbRegion1.Text == "전라남도")
            {
                areaCode = "38";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("강진군");
                CmbRegion2.Items.Add("고흥군");
                CmbRegion2.Items.Add("곡성군");
                CmbRegion2.Items.Add("광양시");
                CmbRegion2.Items.Add("구례군");
                CmbRegion2.Items.Add("나주시");
                CmbRegion2.Items.Add("담양군");
                CmbRegion2.Items.Add("목포시");
                CmbRegion2.Items.Add("무안군");
                CmbRegion2.Items.Add("보성군");
                CmbRegion2.Items.Add("순천시");
                CmbRegion2.Items.Add("신안군");
                CmbRegion2.Items.Add("여수시");
                CmbRegion2.Items.Add("영관군");
                CmbRegion2.Items.Add("영암군");
                CmbRegion2.Items.Add("완도군");
                CmbRegion2.Items.Add("장성군");
                CmbRegion2.Items.Add("장흥군");
                CmbRegion2.Items.Add("진도군");
                CmbRegion2.Items.Add("함평군");
                CmbRegion2.Items.Add("해남군");
                CmbRegion2.Items.Add("화순군");
            }
            if (CmbRegion1.Text == "제주도")
            {
                areaCode = "39";

                CmbRegion2.Items.Clear();
                CmbRegion2.Items.Add("시군구 선택");
                CmbRegion2.Items.Add("남제주군");
                CmbRegion2.Items.Add("북제주군");
                CmbRegion2.Items.Add("서귀포시");
                CmbRegion2.Items.Add("제주시");
            }

            CmbRegion2.SelectedIndex = 0;
        }

        private void CmbRegion2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listTourSk.Clear();
            listView1.View = View.LargeIcon;

            int index = 0;

            //인증키 : 70i7ZBjwMhQcgYsy9HnYEEXv%2FXQ5MxlEHeHcsNd17WY8r%2Fl57uRYryqyC93hdqLDj5WgQ5GwgvA0pgV9sCKcAQ%3D%3D
            string requestUrl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey=" + authenticationKey + "&contentTypeId=" + tourType + "&areaCode=" + areaCode + "&sigunguCode=&cat1=" + service1 + "&cat2=" + service2 + "&cat3=" + service3 + "&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&arrange=A&numOfRows=12&pageNo=" + currentPage + "&_type=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
            jsonString = streamReader.ReadToEnd();

            JObject jsonObject = JObject.Parse(jsonString);
            jsonObject = JObject.Parse(jsonObject["response"].ToString());
            jsonObject = JObject.Parse(jsonObject["body"].ToString());

            if ((Int32.Parse(jsonObject["totalCount"].ToString()) % 12) != 0)
            {
                totalPage = Int32.Parse(jsonObject["totalCount"].ToString()) / 12 + 1;
            }
            else
            {
                totalPage = Int32.Parse(jsonObject["totalCount"].ToString()) / 12;
            }

            if (Int32.Parse(jsonObject["totalCount"].ToString()) < 1)
            {
                MessageBox.Show("정보가 존재하지 않습니다.");
            }
            else if (Int32.Parse(jsonObject["totalCount"].ToString()) == 1)
            {
                jsonObject = JObject.Parse(jsonObject["items"].ToString());
                jsonObject = JObject.Parse(jsonObject["item"].ToString());

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(180, 118);
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                listView1.LargeImageList = imageList;

                TourSk TourSk = new TourSk();
                Image preview;

                if (jsonObject["addr1"] != null)
                {
                    TourSk.Addr1 = jsonObject["addr1"].ToString();
                }
                if (jsonObject["addr2"] != null)
                {
                    TourSk.Addr2 = jsonObject["addr2"].ToString();
                }
                if (jsonObject["areacode"] != null)
                {
                    TourSk.Areacode = Int32.Parse(jsonObject["areacode"].ToString());
                }
                if (jsonObject["cat1"] != null)
                {
                    TourSk.Cat1 = jsonObject["cat1"].ToString();
                }
                if (jsonObject["cat2"] != null)
                {
                    TourSk.Cat2 = jsonObject["cat2"].ToString();
                }
                if (jsonObject["cat3"] != null)
                {
                    TourSk.Cat3 = jsonObject["cat3"].ToString();
                }
                if (jsonObject["contentid"] != null)
                {
                    TourSk.Contentid = jsonObject["contentid"].ToString();
                }
                if (jsonObject["contenttypeid"] != null)
                {
                    TourSk.Contenttypeid = Int32.Parse(jsonObject["contenttypeid"].ToString());
                }
                if (jsonObject["createdtime"] != null)
                {
                    TourSk.Createdtime = new DateTime(Int32.Parse(jsonObject["createdtime"].ToString().Remove(4)), Int32.Parse(jsonObject["createdtime"].ToString().Remove(0, 4).Remove(2)), Int32.Parse(jsonObject["createdtime"].ToString().Remove(0, 6).Remove(2)));
                }
                if (jsonObject["firstimage"] != null)
                {
                    TourSk.Firstimage = jsonObject["firstimage"].ToString();
                }
                if (jsonObject["firstimage2"] != null)
                {
                    TourSk.Firstimage2 = jsonObject["firstimage2"].ToString();
                    preview = Image.FromStream(GetImage(jsonObject["firstimage2"].ToString()));
                }
                else
                {
                    preview = Image.FromStream(GetImage("http://mplaza.co.kr/images/no_photo/car.gif"));
                }
                if (jsonObject["mapx"] != null)
                {
                    TourSk.Mapx = Double.Parse(jsonObject["mapx"].ToString());
                }
                if (jsonObject["mapy"] != null)
                {
                    TourSk.Mapy = Double.Parse(jsonObject["mapy"].ToString());
                }
                if (jsonObject["mlevel"] != null)
                {
                    TourSk.Mlevel = Int32.Parse(jsonObject["mlevel"].ToString());
                }
                if (jsonObject["modifiedtime"] != null)
                {
                    TourSk.Modifiedtime = new DateTime(Int32.Parse(jsonObject["modifiedtime"].ToString().Remove(4)), Int32.Parse(jsonObject["modifiedtime"].ToString().Remove(0, 4).Remove(2)), Int32.Parse(jsonObject["modifiedtime"].ToString().Remove(0, 6).Remove(2)));
                }
                if (jsonObject["readcount"] != null)
                {
                    TourSk.Readcount = Int32.Parse(jsonObject["readcount"].ToString());
                }
                if (jsonObject["sigungucode"] != null)
                {
                    TourSk.Sigungucode = Int32.Parse(jsonObject["sigungucode"].ToString());
                }
                if (jsonObject["tel"] != null)
                {
                    TourSk.Tel = jsonObject["tel"].ToString();
                }
                if (jsonObject["title"] != null)
                {
                    TourSk.Title = jsonObject["title"].ToString();
                }
                if (jsonObject["zipcode"] != null)
                {
                    TourSk.Zipcode = jsonObject["zipcode"].ToString();
                }

                imageList.Images.Add(preview);

                ListViewItem viewItem = new ListViewItem(jsonObject["title"].ToString());
                viewItem.ImageIndex = index;
                listView1.Items.Add(viewItem);

                listTourSk.Add(TourSk);

                index++;
            }
            else
            {
                jsonObject = JObject.Parse(jsonObject["items"].ToString());

                JArray jsonArray = JArray.Parse(jsonObject["item"].ToString());

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(180, 118);
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                listView1.LargeImageList = imageList;

                foreach (var item in jsonArray)
                {
                    TourSk TourSk = new TourSk();
                    Image preview;

                    if (item["addr1"] != null)
                    {
                        TourSk.Addr1 = item["addr1"].ToString();
                    }
                    if (item["addr2"] != null)
                    {
                        TourSk.Addr2 = item["addr2"].ToString();
                    }
                    if (item["areacode"] != null)
                    {
                        TourSk.Areacode = Int32.Parse(item["areacode"].ToString());
                    }
                    if (item["cat1"] != null)
                    {
                        TourSk.Cat1 = item["cat1"].ToString();
                    }
                    if (item["cat2"] != null)
                    {
                        TourSk.Cat2 = item["cat2"].ToString();
                    }
                    if (item["cat3"] != null)
                    {
                        TourSk.Cat3 = item["cat3"].ToString();
                    }
                    if (item["contentid"] != null)
                    {
                        TourSk.Contentid = item["contentid"].ToString();
                    }
                    if (item["contenttypeid"] != null)
                    {
                        TourSk.Contenttypeid = Int32.Parse(item["contenttypeid"].ToString());
                    }
                    if (item["createdtime"] != null)
                    {
                        TourSk.Createdtime = new DateTime(Int32.Parse(item["createdtime"].ToString().Remove(4)), Int32.Parse(item["createdtime"].ToString().Remove(0, 4).Remove(2)), Int32.Parse(item["createdtime"].ToString().Remove(0, 6).Remove(2)));
                    }
                    if (item["firstimage"] != null)
                    {
                        TourSk.Firstimage = item["firstimage"].ToString();
                    }
                    if (item["firstimage2"] != null)
                    {
                        TourSk.Firstimage2 = item["firstimage2"].ToString();
                        preview = Image.FromStream(GetImage(item["firstimage2"].ToString()));
                    }
                    else
                    {
                        preview = Image.FromStream(GetImage("http://mplaza.co.kr/images/no_photo/car.gif"));
                    }
                    if (item["mapx"] != null)
                    {
                        TourSk.Mapx = Double.Parse(item["mapx"].ToString());
                    }
                    if (item["mapy"] != null)
                    {
                        TourSk.Mapy = Double.Parse(item["mapy"].ToString());
                    }
                    if (item["mlevel"] != null)
                    {
                        TourSk.Mlevel = Int32.Parse(item["mlevel"].ToString());
                    }
                    if (item["modifiedtime"] != null)
                    {
                        TourSk.Modifiedtime = new DateTime(Int32.Parse(item["modifiedtime"].ToString().Remove(4)), Int32.Parse(item["modifiedtime"].ToString().Remove(0, 4).Remove(2)), Int32.Parse(item["modifiedtime"].ToString().Remove(0, 6).Remove(2)));
                    }
                    if (item["readcount"] != null)
                    {
                        TourSk.Readcount = Int32.Parse(item["readcount"].ToString());
                    }
                    if (item["sigungucode"] != null)
                    {
                        TourSk.Sigungucode = Int32.Parse(item["sigungucode"].ToString());
                    }
                    if (item["tel"] != null)
                    {
                        TourSk.Tel = item["tel"].ToString();
                    }
                    if (item["title"] != null)
                    {
                        TourSk.Title = item["title"].ToString();
                    }
                    if (item["zipcode"] != null)
                    {
                        TourSk.Zipcode = item["zipcode"].ToString();
                    }

                    imageList.Images.Add(preview);

                    ListViewItem viewItem = new ListViewItem(item["title"].ToString());
                    viewItem.ImageIndex = index;
                    listView1.Items.Add(viewItem);

                    listTourSk.Add(TourSk);

                    index++;
                }
            }
            label5.Text = currentPage + " / " + totalPage;
        }
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 > 0)
            {
                currentPage -= 1;
                BtnSearch_Click(null, null);
            }
            else
            {
                MessageBox.Show("첫 페이지입니다.");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= totalPage)
            {
                currentPage += 1;
                BtnSearch_Click(null, null);
            }
            else
            {
                MessageBox.Show("마지막 페이지입니다.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (TourSk item in listTourSk)
                {
                    if (item.Title == listView1.SelectedItems[0].Text)
                    {
                        FormDetailItem fdi = new FormDetailItem(item);
                        fdi.Text = item.Title;
                        fdi.ShowDialog();

                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 이미지 관련 문자열을 받아 image로 변환합니다.(지성욱 제공)
        /// </summary>
        /// <param name="imageString">이미지 관련 문자열입니다.</param>
        /// <returns></returns>
        private Byte[] GetImgByte(string imageString)
        {
            Byte[] imgByte = new byte[16 * 1024];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageString);
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
