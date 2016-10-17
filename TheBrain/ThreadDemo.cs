using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheBrain
{
    class ThreadDemo
    {
        private Thread m_th1;
        private Thread m_th2;

        public void StartNonParamThread()
        {
            m_th1 = new Thread(new ThreadStart(TestMethod));
            m_th1.IsBackground = true;
            m_th1.Start();
            m_th1.Join();

        }


        public void StartParamThread()
        {
            m_th2 = new Thread(new ParameterizedThreadStart(TestMethod));
            m_th2.IsBackground = true;
            m_th2.Start("param1: the brain");
        }


        public static void TestMethod()
        {
            Console.WriteLine("不带参数的线程函数");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("seq{0}", i);
                Thread.Sleep(50);
            }
        }

        public static void TestMethod(object data)
        {
            string datastr = data as string;
            Console.WriteLine("带参数的线程函数，参数为：{0}", datastr);
        }
    }


            
        

        
    
}
