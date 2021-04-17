using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Box
    {
        public int Heigth { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public int Surface 
        {
            get
            {
                return this.Heigth * this.Length;
            }
        }

        public void Volume()
        {
            Console.WriteLine($"Height {Heigth}, length {Length}, width {Width}, volume {Heigth * Length * Width}.");
        }
    }
}
