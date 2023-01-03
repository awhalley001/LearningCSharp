using System;

namespace Properties
{
    public class Box
    {
        // member variable
        private int length;
        private int height;
        private int width;
        private int volume;

        public void SetLength(int length)
        {
            if (length < 0)
                throw new Exception("Length should be higher than 0!");
            this.length = length;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int CalculateVolume()
        {
           return GetLength() * GetWidth() * GetHeight();
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length} and height {height} and width is {width} so the volume is {CalculateVolume()}");
            
        }
    }
}