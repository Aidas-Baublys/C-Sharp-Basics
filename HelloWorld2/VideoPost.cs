using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class VideoPost : Post
    {
        public string VideoUrl { get; set; }
        public int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string videoUrl, string title, string sender, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.VideoUrl = videoUrl;
            this.Title = title;
            this.Sender = sender;
            this.Length = length;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {this.VideoUrl} - {this.Length}";
        }

        // Kitą kartą naudoti System.Threading Timer, kad paprasčiau ir gražiau daryti callback.
        Timer timer = new Timer(1000);

        public void Play()
        {
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public static int s = 0;

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"Video is playing. Current duration: {s}s");
            s++;
        }

        public void Stop()
        {
            if (Console.ReadKey() != null)
            {
                timer.Enabled = false;
                Console.WriteLine($"Video is stopped at {s}s");
            }
        }
    }
}
