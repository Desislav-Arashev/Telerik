using System;

namespace Task1.ClassSizeInCSharp
{
    public class StartUp
    {
        public static void Main()
        {
            var size = new Size(22, 11);
            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);
            Console.WriteLine();

            var rotatedSize = Size.GetRotatedSize(size, 45);

            Console.WriteLine(rotatedSize.Width);
            Console.WriteLine(rotatedSize.Height);
        } 
    }
}
