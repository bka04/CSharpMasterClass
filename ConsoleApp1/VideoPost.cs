using System;
using System.Threading;
namespace CSharpMasterClass
{
    public class VideoPost : Post
    {

        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() {}
        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
            VideoURL = videoURL;
            Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}",
                ID, Title, VideoURL, Length, SendByUsername);
        }

    }
}

