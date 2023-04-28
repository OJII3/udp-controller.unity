using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

namespace UdpController
{
    public static class NetworkManager
    {
        private static Thread _thread;
        private static string _message;
        private static IPEndPoint _remoteEndPoint;
        public static UdpClient SendClient { get; private set; }
        public static UdpClient ReceiveClient { get; private set; }
        public static string Log { get; private set; }
        public static string TargetIP { get; private set; }
        public static int TargetPort { get; private set; }

        public static void Connect(string targetIP, int targetPort)
        {
            if (SendClient != null)
            {
                SendClient.Close();
                SendClient = null;
            }

            if (ReceiveClient != null)
            {
                ReceiveClient.Close();
                ReceiveClient = null;
            }

            if (_thread != null)
            {
                _thread.Abort();
                _thread = null;
            }

            TargetIP = targetIP;
            TargetPort = targetPort;
            _remoteEndPoint = new IPEndPoint(IPAddress.Parse(TargetIP), TargetPort);
            SendClient = new UdpClient();
            ReceiveClient = new UdpClient(8888);
            SendClient.Connect(_remoteEndPoint);
            _thread = new Thread(StartReceiving);
            _thread.Start();

            Debug.Log("Successfully connected!");
            AppendLog("Successfully connected!");
        }

        public static void Send(string message)
        {
            try
            {
                var data = Encoding.ASCII.GetBytes(message);
                SendClient.Send(data, data.Length);
            }
            catch (SocketException e)
            {
                Debug.Log("Not Connected!");
                AppendLog($"Received: {e.Message}");
            }
        }

        private static void StartReceiving()
        {
            while (true)
                try
                {
                    IPEndPoint ep = null;
                    var receivedMessage = Encoding.UTF8.GetString(ReceiveClient.Receive(ref ep));
                    if (receivedMessage != string.Empty)
                    {
                        Debug.Log($"Received: {receivedMessage}");
                        AppendLog($"Received: {receivedMessage}");
                    }
                }
                catch (SocketException e)
                {
                    Debug.Log(e.Message);
                    AppendLog($"Received: {e.Message}");
                }
        }

        private static void AppendLog(string log)
        {
            if (Log is { Length: > 1000 }) Log = Log.Substring(0, 1000);
            Log = $"{log}\n{Log}";
        }
    }
}