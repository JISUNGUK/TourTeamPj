using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTeamProject
{
    public class Blog
    {
        private string title;
        private string link;
        private string description;
        private string bloggername;
        private string bloggerlink;
        private DateTime postdate;

        public string Title { get => title; set => title = value; }
        public string Link { get => link; set => link = value; }
        public string Description { get => description; set => description = value; }
        public string Bloggername { get => bloggername; set => bloggername = value; }
        public string Bloggerlink { get => bloggerlink; set => bloggerlink = value; }
        public DateTime Postdate { get => postdate; set => postdate = value; }
    }
}
