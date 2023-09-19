using System;
using my_syntax_learn_app;

namespace HelloWorldApp
{
    class Helloworld
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Accpetdetails();
            r.Display();
            /*
            float i = (float)123;
            bool b = Convert.ToBoolean(i);
            Console.WriteLine(b); 
            Console.WriteLine(i);
            */
            string dateString = "2022-07-31";
            Console.WriteLine(dateString); // 输出：2022/7/31 00:00:00
            Console.WriteLine("Hello world");
            Console.ReadKey();  
        }
    }
}