using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

namespace UdpController
{
    public static class NetworkManager
    {
        private static UdpClient _udpClient;

        private static Thread _thread;
        private static bool _isRunning;
        private static string _message;
        private static IPEndPoint _remoteEndPoint;

        public static bool IsConnecting { get; private set; }
        public static string TargetIP { get; private set; }
        public static int TargetPort { get; private set; }
        public static byte[] Data { get; private set; }

        public static void Connect(string targetIP, int targetPort)
        {
            TargetIP = targetIP;
            TargetPort = targetPort;
            _remoteEndPoint = new IPEndPoint(IPAddress.Parse(TargetIP), TargetPort);
            _udpClient = new UdpClient();
            _udpClient.Connect(_remoteEndPoint);
            IsConnecting = true;
            _isRunning = true;
            _thread = new Thread(ReceiveData);
            _thread.Start();
        }

        public static void Close()
        {
            _isRunning = false;
            IsConnecting = false;
            _udpClient.Close();
        }

        public static void Send(string message)
        {
            _message = message;
            Data = Encoding.ASCII.GetBytes(_message);
            _udpClient.Send(Data, Data.Length);
        }

        private static void ReceiveData()
        {
            while (_isRunning)
                try
                {
                    var anyIP = new IPEndPoint(IPAddress.Any, 0);
                    var data = _udpClient.Receive(ref anyIP);
                    var text = Encoding.UTF8.GetString(data);
                    Debug.Log($"Received: {text}");
                }
                catch (Exception e)
                {
                    Debug.Log(e.ToString());
                }
        }
    }
}