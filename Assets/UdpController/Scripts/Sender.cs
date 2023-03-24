using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace UdpController
{
    public class Sender : MonoBehaviour
    {
        private bool _isConnecting;

        // client
        private static UdpClient _udpClient;

        // io
        private CustomInputActions _customInputActions;

        [SerializeField] private TMP_InputField targetIPField;
        [SerializeField] private TMP_InputField targetPortField;
        [SerializeField] private TMP_InputField messageField;


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

        private void OnConnect(InputAction.CallbackContext context)
        {
            if (_isConnecting)
            {
                Debug.Log($"You are already connected!");
                return;
            };

            _udpClient.Connect(targetIPField.text, int.Parse(targetPortField.text));
            _isConnecting = true;
            
            targetIPField.readOnly = true;
            targetPortField.readOnly = true;

            Debug.Log($"Start connecting");
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

        private void OnDestroy()
        {
            _udpClient.Close();
        }
    }
}