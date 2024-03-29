﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _022_聊天室_Socket编程_TCP服务器端
{
    class Program
    {
        static List<Client> clientList=new List<Client>();
        /// <summary>
        /// 广播消息
        /// </summary>
        /// <param name="message"></param>
        public static void BoradcastMessage(string message)
        {
            var notConnectedList=new List<Client>();
            foreach (var client in clientList)
            {
                if(client.Connected)
                    client.SendMessage(message);
                else
                {
                    notConnectedList.Add(client);
                }
            }

            foreach (var temp in notConnectedList)
            {
                clientList.Remove(temp);
            }
        }
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.9"), 7788));

            tcpServer.Listen(100);
            Console.WriteLine("Server Running......");
            while (true)
            {
                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("a client is connected!");

                Client client =new Client(clientSocket);//把与每个客户端通信的逻辑（收发消息）
                //放到client类中进行处理
                clientList.Add(client);
            }
        }
    }
}
