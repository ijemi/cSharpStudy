using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _025_udpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udpclient，绑定ip地址和短号
            UdpClient udpclient=new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.0.9"),7788 ));

            while (true)
            {
                //接收数据
                IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpclient.Receive(ref point);//通过point确定数据来自哪个ip和短号，返回值是一个字节数组，就是我们的数据

                string message = Encoding.UTF8.GetString(data);
                Console.WriteLine("收到了数据：" + message);

            }
            udpclient.Close();
            Console.ReadKey();
        }
    }
}
