namespace Properties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(3);
            box.SetHeight(3);
            box.SetWidth(3);
            
            
            box.DisplayInfo();
        }
    }
}