using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Post
    {
        private static int postID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Sender { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "First post";
            Sender = "Igor";
            IsPublic = true;
        }

        public Post(string title, string sender, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Sender = sender;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++postID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return $"{this.ID} - {this.Title} by {this.Sender}";
        }
    }
}
