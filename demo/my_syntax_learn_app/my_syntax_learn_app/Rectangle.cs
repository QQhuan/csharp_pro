using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_syntax_learn_app
{
    internal class Rectangle
    {
        double length;
        double width;
        public void Accpetdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("area: {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Accpetdetails();
            r.Display();
            Console.WriteLine("hello world");
        }
    }
}
