using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            var downloadHelper = new DownloadHelper();
            downloadHelper.FileDownload += OnFileDownload;
            downloadHelper.Download("dx");
            
            Console.ReadKey();
        }

        public static void OnFileDownload(object source, EventArgs e)
        {
            Console.WriteLine("Unpacking...");
            Thread.Sleep(3000);
            Console.WriteLine("Done nx.");
        }
    }
}
