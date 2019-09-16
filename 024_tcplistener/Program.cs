using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _024_tcplistener
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.TcpListener对Socket进行了一层封装，这个类里面自己会去创建socket对象
            TcpListener listener =new TcpListener(IPAddress.Parse("192.168.0.9"),7788);

            //2.开始进行监听
            listener.Start();

            //3.等待客户端连接进来
            TcpClient client= listener.AcceptTcpClient();

            //4.取得客户端发送过来的数据
            NetworkStream stream= client.GetStream();//得到一个网络刘，从这个网络流中可用取得客户端发过来的数据

            byte[] data=new byte[1024];//创建一个数据的容器，用来承接数据
            while (true)
            {
                //0表示从数组的哪个索引开始存放数据
                //1024表示最大读取的字节数
                int length = stream.Read(data, 0, 1024);//读取数据
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("收到了消息：" + message);

            }

            stream.Close();
            client.Close();
            listener.Stop();//停止监听

            Console.ReadKey();
        }
    }
}
