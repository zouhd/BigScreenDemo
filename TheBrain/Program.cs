using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheBrain
{
    class Program
    {
        /***
         * 参考文献：http://www.cnblogs.com/luxiaoxun/p/3280146.html
         * 多线程实现方法：Thread，ThreadPool，Task以及异步调用
         * 
         ***/
        static void Main(string[] args)
        {
            ThreadDemo th = new ThreadDemo();
            th.StartNonParamThread();
            th.StartParamThread();

            ThreadPoolDemo tp = new ThreadPoolDemo();
            tp.StartThread();

            AsyncDelegateDemo del = new AsyncDelegateDemo();
            del.Start();
            Thread.Sleep(10);
            if (del.IsOver())
                Console.WriteLine("异步执行结束...");
            else
                Console.WriteLine("异步执行还没结束...");
            //del.Stop();

            /*
             * 
            AsyncTcpServer server = new AsyncTcpServer("127.0.0.1", 8700);
            server.DoBeginAccept();
            Console.WriteLine("非阻塞监听，才会显示");
             *
             */
            Console.ReadLine();
        }

    }
}
