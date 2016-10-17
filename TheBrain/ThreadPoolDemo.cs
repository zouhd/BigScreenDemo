using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheBrain
{
    class ThreadPoolDemo
    {
        public void StartThread()
        {
            Console.WriteLine("测试线程池... ...");
            ThreadPool.QueueUserWorkItem(TestMethod, "test threadpool");

        }

        public static void TestMethod(object data)
        {
            string datastr = data as string;
            Console.WriteLine(datastr);
        }
    }
}
