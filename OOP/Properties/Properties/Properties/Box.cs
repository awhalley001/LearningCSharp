using System;
using System.Data.SqlClient;

namespace Properties
{
    public class Box
    {
        // member variable
        private int length;
        private int height;
        // private int width;
        private int volume;
        private int frontSurface;
        public int Width { get; set; }

        public int Height { get; set; }
        
        public Box(int length, int height, int width)
        {
            this.length = length;
            Height = height;
            Width = width;
        }
        public void SetLength(int length)
        {
            if (length < 0)
                throw new Exception("Length should be higher than 0!");
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        
        public int CalculateVolume()
        {
           return GetLength() * Width * Height;
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                this.volume = value;
            }
        }

        public int FrontSurface
        {
            get
            {
                return Height * length;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length} and height {Height} and width is {Width} so the volume is {CalculateVolume()}");
            
        }
    }
}