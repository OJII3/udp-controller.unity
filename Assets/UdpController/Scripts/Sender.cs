using System;
using UnityEngine;
using UdpController;
using UnityEngine.InputSystem;

namespace UdpController.Scripts
{
    public class Sender: MonoBehaviour
    {
        private CustomInputActions _customInputActions;
        private void Awake()
        {
            _customInputActions = new CustomInputActions();
        }

        private void Start()
        {
            _customInputActions.Enable();
            _customInputActions.UI.Submit.started += OnSend;
        }

        private void OnSend(InputAction.CallbackContext context)
        {
            Debug.Log("Hello!");
        }
    }
}