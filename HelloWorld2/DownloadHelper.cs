using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class DownloadHelper
    {
        public event EventHandler<EventArgs> FileDownload;

        protected virtual void OnFileDownload()
        {
            if (FileDownload != null)
            {
                FileDownload(this, EventArgs.Empty);
            }
        }

        public void Download(string file)
        {
            Console.WriteLine($"Downloading {file}...");
            Thread.Sleep(4000);
            OnFileDownload();
        }
    }
}
