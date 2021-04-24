using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class ImgPost : Post
    {
        public string ImgUrl { get; set; }

        public ImgPost() { }

        public ImgPost(string imgUrl, string title, string sender, bool isPublic)
        {
            this.ID = GetNextID();
            this.ImgUrl = imgUrl;
            this.Title = title;
            this.Sender = sender;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {this.ImgUrl}";
        }
    }
}
