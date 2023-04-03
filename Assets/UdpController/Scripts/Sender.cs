using System.Net.Sockets;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UdpController
{
    public class Sender : MonoBehaviour
    {
        // client
        private static UdpClient _udpClient;

        [SerializeField] private TMP_InputField targetIPField;
        [SerializeField] private TMP_InputField targetPortField;
        [SerializeField] private TMP_InputField messageField;

        // io
        private CustomInputActions _customInputActions;
        private bool _isConnecting;


        private void Start()
        {
            _udpClient = new UdpClient();
            _isConnecting = false;

            _customInputActions = new CustomInputActions();
            _customInputActions.Enable();
            _customInputActions.UI.Connect.started += OnConnect;
            _customInputActions.UI.Close.started += OnClose;
            _customInputActions.UI.Submit.started += OnSubmit;

            Debug.Log("Started!");
        }

        private void OnDestroy()
        {
            _udpClient.Close();
        }

        private void OnConnect(InputAction.CallbackContext context)
        {
            if (_isConnecting)
            {
                Debug.Log("You are already connected!");
                return;
            }

            ;

            _udpClient.Connect(targetIPField.text, int.Parse(targetPortField.text));
            _isConnecting = true;

            targetIPField.readOnly = true;
            targetPortField.readOnly = true;

            Debug.Log("Start connecting");
        }

        private void OnClose(InputAction.CallbackContext context)
        {
            if (!_isConnecting) return;
            _isConnecting = false;
            _udpClient.Close();

            targetIPField.readOnly = false;
            targetPortField.readOnly = false;

            Debug.Log("Closed!");
        }

        private void OnSubmit(InputAction.CallbackContext context)
        {
            if (!_isConnecting) return;
            var dgram = Encoding.UTF8.GetBytes(messageField.text);
            _udpClient.Send(dgram, dgram.Length);
            Debug.Log("Message Sent!");
        }
    }
}