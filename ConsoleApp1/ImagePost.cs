using System;
namespace CSharpMasterClass
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, bool isPublic, string sendByUsername, string imageURL)
        {
            ID = GetNextID();
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;

            // property of ImagePost
            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", ID, Title, ImageURL, SendByUsername);
        }
    }
}

