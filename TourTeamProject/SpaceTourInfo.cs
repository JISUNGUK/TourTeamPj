using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTeamProject
{
    class SpaceTourInfo
    {
        private string addr1;                       //  주소1
        private string addr2;                       //  주소2
        private int areacode;                       //  지역코드
        private int booktour;                       //  교과서속 여행지 여부 1= 여행지 0= 아님
        private string cat1;                        //  대분류
        private string cat2;                        //  중분류
        private string cat3;                        //  소분류
        private string contentid;                   //  콘텐츠 ID
        private int contenttypeid;                  //  콘텐츠 Type Id
        private DateTime createdtime;               //  등록일
        private string distance;                    //  코스 총 거리
        private string firstimage;                  //  대표이미지
        private string firstimage2;                 //  썸네일
        private double mapx;                        //  x좌표
        private double mapy;                        //  y좌표
        private int mlevel;                         //  맵레벨 응답
        private DateTime modifiedtime;              //  콘텐츠 수정일
        private int readcount;                      //  조회수
        private int sigungucode;                    //  시군구 코드
        private string title;                       //  제목
        private string tel;                          //  전화번호

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string Addr2 { get => addr2; set => addr2 = value; }
        public int Areacode { get => areacode; set => areacode = value; }
        public int Booktour { get => booktour; set => booktour = value; }
        public string Cat1 { get => cat1; set => cat1 = value; }
        public string Cat2 { get => cat2; set => cat2 = value; }
        public string Cat3 { get => cat3; set => cat3 = value; }
        public string Contentid { get => contentid; set => contentid = value; }
        public int Contenttypeid { get => contenttypeid; set => contenttypeid = value; }
        public DateTime Createdtime { get => createdtime; set => createdtime = value; }
        public string Distance { get => distance; set => distance = value; }
        public string Firstimage { get => firstimage; set => firstimage = value; }
        public string Firstimage2 { get => firstimage2; set => firstimage2 = value; }
        public double Mapx { get => mapx; set => mapx = value; }
        public double Mapy { get => mapy; set => mapy = value; }
        public int Mlevel { get => mlevel; set => mlevel = value; }
        public DateTime Modifiedtime { get => modifiedtime; set => modifiedtime = value; }
        public int Readcount { get => readcount; set => readcount = value; }
        public int Sigungucode { get => sigungucode; set => sigungucode = value; }
        public string Title { get => title; set => title = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
