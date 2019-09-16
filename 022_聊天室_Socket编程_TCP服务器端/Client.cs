using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _022_聊天室_Socket编程_TCP服务器端
{
    /// <summary>
    /// 用来跟客户端做通信
    /// </summary>
    class Client
    {
        private Socket clientSocket;
        private Thread t;
        private byte[] data=new byte[1024];//这是一个数组容器
        public Client(Socket s)
        {
            clientSocket = s;
            //穷的那个一个线程处理客户端的接收
            t=new Thread(ReceiveMessage);
            t.Start();
        }

        private void ReceiveMessage()
        {
            //一直接收客户端的数据
            while (true)
            {
                //在接收数据之前，判断一下Socket连接是否打开
                //if (clientSocket.Connected == false)
                if(clientSocket.Poll(10,SelectMode.SelectRead))
                {
                    clientSocket.Close();
                    break;//跳出循环，终止线程
                }
                int length = clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                //服务端接收到数据时，要把这个数据分发到客户端
                //广播这个消息
                Program.BoradcastMessage(message);
                Console.WriteLine("接收到了：" + message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
        }

        public bool Connected
        {
            get { return clientSocket.Connected; }
        }
    }
}
