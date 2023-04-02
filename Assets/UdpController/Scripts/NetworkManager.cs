using System;
using System.Collection;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UdpController {
    public class NetworkManager : MonoBehaviour
    {
        private static UdpClient _udpClient;
        
        private static Thread _thread;
        private static bool _isRunning;
        private static string _message;
        private static string _targetIP;
        private static int _targetPort;
        private static byte[] _data;
        private static IPEndPoint _remoteEndPoint;
        private bool _isConnecting;
        public bool IsConnecting {
            get => _isConnecting;
        }
        
        public static void Connect(string targetIP, int targetPort)
        {
            _targetIP = targetIP;
            _targetPort = targetPort;
            _remoteEndPoint = new IPEndPoint(IPAddress.Parse(_targetIP), _targetPort);
            _udpClient = new UdpClient();
            _udpClient.Connect(_remoteEndPoint);
            _isConnecting = true;
            _isRunning = true;
            _thread = new Thread(new ThreadStart(ReceiveData));
            _thread.Start();
        }
        
        public static void Close()
        {
            _isRunning = false;
            _isConnecting = false;
            _udpClient.Close();
        }
        
        public static void Send(string message)
        {
            _message = message;
            _data = Encoding.ASCII.GetBytes(_message);
            _udpClient.Send(_data, _data.Length);
        }
        
        private static void ReceiveData()
        {
            while (_isRunning)
            {
                try
                {
                    IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = _udpClient.Receive(ref anyIP);
                    string text = Encoding.UTF8.GetString(data);
                    Debug.Log($"Received: {text}");
                }
                catch (Exception e)
                {
                    Debug.Log(e.ToString());
                }
            }
        }
    }
}
