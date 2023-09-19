using System;
using System.Collections;
using System.Threading;

namespace hhhh 
{
   class StringPlay
    {
        static void Main(String[] args)
        {
            /*
            string a = "could u speak english ?";
            string b = a.Replace(' ', '*');
            int[] arr = new int[]{1, 2, 3, 4, 5};
            ArrayList list = new ArrayList(arr);
            list.Add(6);
            list.Insert(0, 0);
            int index = list.IndexOf(1);
            Console.WriteLine(index);
            Console.WriteLine(list.Contains(6));
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(b);

            Hashtable mySet = new Hashtable();
            mySet.Add("name", "qiuhuan");
            mySet.Add("age", "25");
            Console.WriteLine(mySet);
            foreach(DictionaryEntry dicRntry in mySet)
            {
                Console.WriteLine("key:{0}, value:{1}", dicRntry.Key, dicRntry.Value);
            }
            */
            string info = string.Empty;
            Thread myThread = new Thread(new ThreadStart(threadOut));
            myThread.Start();
            info = "id:" + myThread.ManagedThreadId
                + "\n name:" + myThread.Name
                + "\n state:" + myThread.ThreadState.ToString()
                + "\n priority:" + myThread.Priority.ToString()
                + "\n isBackground: " + myThread.IsBackground;
            Thread.Sleep(1000);
            myThread.Interrupt(); // 中断
            myThread.Join();
            Console.WriteLine("thread end");
            Console.WriteLine(info);

        }
        public static void threadOut()
        {
            Console.WriteLine("thread start");
        }
    }


    public interface MyInterface
    {
        public int GetUserMessage();
    }

    public interface SecondInterface
    {
        public string GetUserName(int i);
    }

    public interface GetAll : MyInterface, SecondInterface
    {
        public int GetCount();
    }
    public class MyInterface2 : GetAll
    {
        public int GetUserMessage()
        {
            return 0;
        }
        public int GetCount()
        {
            return 100;
        }

        public string GetUserName()
        {
            return "nothing";
        }

        public string GetUserName(int s)
        {
            return s+"name";
        }
    }
}
