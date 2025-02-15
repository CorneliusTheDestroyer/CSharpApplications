using System;

namespace OperatorOverloadExample
{
    class Program
    {
        public class Rectangle
        {
            public int Width = 0;
            public int Height = 0;

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;

            }
            public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
            {
                Rectangle rectResult = new Rectangle(rect1.Width + rect2.Width, rect1.Height + rect2.Height);

                return rectResult;

            }
        }

        static void Main()
        {
            Rectangle rect1 = new Rectangle(12, 10);
            Rectangle rect2 = new Rectangle(5, 2);

            Rectangle rectResult = rect1 + rect2;

            Console.WriteLine($"'rect1(12,10)' + 'rect2(5,2)' = 'rectResult({rectResult.Width},{rectResult.Height})'");

            Console.ReadKey();
        }
    }
}
