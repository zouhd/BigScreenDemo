using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TheBrain
{
    class AsyncTcpServer
    {
        //服务器监听对象
        public TcpListener listener;

        //客户端列表
        public static TcpClient[] client_list = new TcpClient[5];

        //已连接客户端数量
        private int client_num = 0;

        //构造方法
        public AsyncTcpServer(String ip, int port)
        {
            this.listener = new TcpListener(new IPEndPoint(IPAddress.Parse(ip), port));
            listener.Start();
        }

        //异步监听
        public void DoBeginAccept()
        {
            //开始从客户端监听连接
            Console.WriteLine("等待连接... ...");
            //接收连接
            //开始准备接入新的连接，一旦有新连接调用回调函数DoAcceptTcpClient
            listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClient), listener);
        }

        //处理客户端的连接
        public void DoAcceptTcpClient(IAsyncResult iar)
        {
            //还原原始的TcpListener对象
            this.listener = (TcpListener)iar.AsyncState;
            //完成连接的动作，并返回新的TcpClient
            TcpClient client = this.listener.EndAcceptTcpClient(iar);
            Console.WriteLine(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() +":" 
                + ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString() + "连接成功");

            //更新接入的客户端数量
            client_list[client_num++] = client;
            //获取输入输出流
            NetworkStream net_stream = client.GetStream();
            //返回hello world
            String info = "hello world";
            byte[] infobyte = new byte[info.Length];
            for (int i = 0; i < infobyte.Length; i++)
            {
                infobyte[i] = Convert.ToByte(info[i]);
            }
            net_stream.Write(infobyte, 0, infobyte.Length);

        }
    }
}
