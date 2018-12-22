using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTeamProject
{
    class TourSearchResult
    {
        private string title, address, contentid, contenttypeid, mapx, mapy;//제목,주소,해당콘텐츠 검색을 위한 id들,위도,경도
        private string tel = "없음", sigungucode, areacode = "없음", imageurl = "없음", imageurl2 = "없음";
        private string homepage = "없음", zipcode = "없음";

        public string Title { get => title; set => title = value; }
        public string Address { get => address; set => address = value; }
        public string Contentid { get => contentid; set => contentid = value; }
        public string Contenttypeid { get => contenttypeid; set => contenttypeid = value; }
        public string Mapx { get => mapx; set => mapx = value; }
        public string Mapy { get => mapy; set => mapy = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Sigungucode { get => sigungucode; set => sigungucode = value; }
        public string Areacode { get => areacode; set => areacode = value; }
        public string Imageurl { get => imageurl; set => imageurl = value; }
        public string Imageurl2 { get => imageurl2; set => imageurl2 = value; }
        public string Homepage { get => homepage; set => homepage = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
    }
}
