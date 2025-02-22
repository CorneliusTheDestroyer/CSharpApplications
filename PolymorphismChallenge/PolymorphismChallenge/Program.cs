using System;
using System.Collections.Generic;

namespace PolymorphismChallenge
{
    public interface IDrawable
    {
        void Draw();
    }

    //public class Shape
    //{
    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("Drawing");
    //    }
    //}

    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    public class Triangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }

    class Program
    {
        static void Main()
        {
            List<IDrawable> shapes = new List<IDrawable>
            {
                new Circle(),
                new Rectangle(),
                new Triangle()
            };

            foreach (IDrawable shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
