using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTeamProject
{
    public partial class Apilogue : UserControl
    {
        private List<Blog> listBlog;
        private string link;

        public Apilogue()
        {
            InitializeComponent();
        }

        public Apilogue(List<Blog> listBlog)
        {
            this.listBlog = listBlog;
        }

        public Apilogue(string title, string bloggername)
        {
            InitializeComponent();
            LblTitle.Text = title;
            LblBloggerName.Text = bloggername;
        }

        public Apilogue(string title, string bloggername, string link) : this(title, bloggername)
        {
            this.link = link;
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }

        private void LblBloggerName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
    }
}
