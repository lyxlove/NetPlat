using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace VehicleForNetSocket
{
    public class SocketHelper
    {
        private static volatile SocketHelper instance = null;

        private static object lockHelper = new object();

        public static readonly string Address = "192.168.1.233";

        public static readonly int Port = 8082;

        private SocketHelper() { }

        //private string Address { get; set; }

        //private int Port { get; set; }

        public bool bConnected { get; set; }

        public Socket socket { get; set; }

        public static SocketHelper GetInstance(string address, int port)
        {
            lock (lockHelper)
            {
                if (instance == null)
                {
                    instance = new SocketHelper();
                    instance.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    instance.socket.Connect(address, port);
                    //instance.Address = address;
                    //instance.Port = port;
                    instance.bConnected = instance.socket.Connected;
                }
                else
                {
                    if (instance.socket.Connected == false)
                    {
                        instance.socket.Connect(address, port);
                        instance.bConnected = instance.socket.Connected;
                    }
                }
            }

            return instance;
        }
    }
}
