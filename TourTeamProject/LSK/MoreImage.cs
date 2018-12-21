using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTeamProject
{
    class MoreImage
    {
        private string contentid;
        private string originimgurl;
        private string serialnum;
        private string smallimageurl;

        public string Contentid { get => contentid; set => contentid = value; }
        public string Originimgurl { get => originimgurl; set => originimgurl = value; }
        public string Serialnum { get => serialnum; set => serialnum = value; }
        public string Smallimageurl { get => smallimageurl; set => smallimageurl = value; }
    }
}
