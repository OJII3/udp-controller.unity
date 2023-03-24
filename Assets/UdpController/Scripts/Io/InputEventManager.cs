using UnityEngine;
using System;
using UnityEngine.InputSystem;

namespace UdpController
{
    public class InputEventManager : MonoBehaviour
    {
        public void OnSubmit(InputAction.CallbackContext context)
        {
            Debug.Log("Hello!");
        }
    }
}