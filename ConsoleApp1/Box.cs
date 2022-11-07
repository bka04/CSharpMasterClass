using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Box
    {
        private int length;
        // public int width;
        private int height;
        // private int volume;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    this.height = -value;
                } else
                {
                    this.height = value;
                }
            }
        }  
        
        public int Volume
        {
            get { return this.length * this.Width * this.Height; }
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be greater than 0");
            }
            this.length = length;
        }        

        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length: {0}, width: {1}, height: {2}. Volume = {3}", length, Width, Height, Volume);
        }
    }
}
