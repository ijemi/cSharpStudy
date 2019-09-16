using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _021_Socket编程_TCP协议
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建Socket
            Socket tcpServer=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);//内网
            //2.绑定ip和端口号 192.168.0.9
            IPAddress ipAddress =new IPAddress(new  byte[]{192,168,0,9});
            EndPoint point=new IPEndPoint(ipAddress,7788);//是对ip+端口号做了一层封装的类
            tcpServer.Bind(point);//向操作系统申请一个可用的ip跟端口号用来做通信
            //开始监听（等待客户端连接）
            tcpServer.Listen(100);//参数是最大连接数
            Console.WriteLine("开始监听");

            Socket clientSocket = tcpServer.Accept();//暂停当前线程，直到有一个客户端链接过来，之后进行下面的代码
            //使用返回的Socket跟客户端做通信
            Console.WriteLine("一个客户端连接进来了 ");
            string message = "Hello 欢迎你";
            byte[] data= Encoding.UTF8.GetBytes(message);//对字符串做编码，得到一个字符串的字节数组
            clientSocket.Send(data);
            Console.WriteLine("向客户端发送了一条数据");


            byte[] data2 = new byte[1024];//创建一个字节数组用来当容器，去承接客户端发送过来的数据
            int length = clientSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);//把字节数据转化成一个字符串
            Console.WriteLine("接收到了一条从客户端发送过来的消息："+ message2);


            Console.ReadKey();
        } 
    }
}
