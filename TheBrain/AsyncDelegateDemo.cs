using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace TheBrain
{
    public delegate String MyDelegate(String param);
    /**************************
     * 
     * 
     * 参考：http://www.cnblogs.com/inforasc/archive/2009/10/21/1587756.html
     * 
     *************************/
    class AsyncDelegateDemo
    {
        private static int num = 0;

        private MyDelegate m_mydelegate;
        private IAsyncResult m_res;

        public void Start()
        {
            Console.WriteLine("测试异步委托");
            m_mydelegate = new MyDelegate(TestMethod);
            m_res = m_mydelegate.BeginInvoke("AsyncDelegate: Thread Param", TestCallback, "AsyncDelegate: Callback Param");
            
        }

        public void Stop()
        {
            String res = m_mydelegate.EndInvoke(m_res);
            Console.WriteLine("Stop(): {0}", res);
        }

        public Boolean IsOver()
        {
            return m_res.IsCompleted;
        }

        //线程函数
        public static string TestMethod(object data)
        {
            string datastr = data as string;
            Console.WriteLine(datastr);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("AsyncDelegate: work");
                Thread.Sleep(50);
            }

            num++;
            datastr = "Thread terminated...";
            //返回线程执行结果
            return datastr;
        }

        //执行完异步回调函数
        public static void TestCallback(IAsyncResult data)
        {
            Console.WriteLine("Callback: {0}", num);

            AsyncResult ar = (AsyncResult)data;
            MyDelegate del = (MyDelegate)ar.AsyncDelegate;
            String res = del.EndInvoke(data);

            Console.WriteLine("{0}, result is {1}", ar.AsyncState, res);
        }
    }
}
