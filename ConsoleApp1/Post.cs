using System;
namespace CSharpMasterClass
{
    public class Post
    {
        private static int currentPostId;

        // protected - only useable by this class and derived classes
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Denis Panjuta";
        }

        //
        public Post(string title, bool isPublic, string sendByUsername)
        {
            ID = GetNextID();
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", ID, Title, SendByUsername);
        }
    }
}

