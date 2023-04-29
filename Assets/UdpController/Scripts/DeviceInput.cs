using UnityEngine;

namespace UdpController.Script
{
    public class DeviceInput : MonoBehaviour
    {
        private CustomActions _customActions;

        private void Awake()
        {
            _customActions = new CustomActions();
            _customActions.Enable();
        }

        private void FixedUpdate()
        {
            if (_customActions.UI.LeftStickDown.inProgress) NetworkManager.Send("LeftStickDown");
            if (_customActions.UI.LeftStickUp.inProgress) NetworkManager.Send("LeftStickUp");
            if (_customActions.UI.LeftStickLeft.inProgress) NetworkManager.Send("LeftStickLeft");
            if (_customActions.UI.LeftStickRight.inProgress) NetworkManager.Send("LeftStickRight");
            if (_customActions.UI.LeftStickPress.inProgress) NetworkManager.Send("LeftStickPress");
            if (_customActions.UI.RightStickDown.inProgress) NetworkManager.Send("RightStickDown");
            if (_customActions.UI.RightStickUp.inProgress) NetworkManager.Send("RightStickUp");
            if (_customActions.UI.RightStickLeft.inProgress) NetworkManager.Send("RightStickLeft");
            if (_customActions.UI.RightStickRight.inProgress) NetworkManager.Send("RightStickRight");
            if (_customActions.UI.RightStickPress.inProgress) NetworkManager.Send("RightStickPress");
            if (_customActions.UI.DPadDown.inProgress) NetworkManager.Send("DPadDown");
            if (_customActions.UI.DPadUp.inProgress) NetworkManager.Send("DPadUp");
            if (_customActions.UI.DPadLeft.inProgress) NetworkManager.Send("DPadLeft");
            if (_customActions.UI.DPadRight.inProgress) NetworkManager.Send("DPadRight");
            if (_customActions.UI.L1.inProgress) NetworkManager.Send("L1");
            if (_customActions.UI.L2.inProgress) NetworkManager.Send("L2");
            if (_customActions.UI.R1.inProgress) NetworkManager.Send("R1");
            if (_customActions.UI.R2.inProgress) NetworkManager.Send("R2");
            if (_customActions.UI.Triangle.inProgress) NetworkManager.Send("Triangle");
            if (_customActions.UI.Circle.inProgress) NetworkManager.Send("Circle");
            if (_customActions.UI.Cross.inProgress) NetworkManager.Send("Cross");
            if (_customActions.UI.Square.inProgress) NetworkManager.Send("Square");
            if (_customActions.UI.Select.inProgress) NetworkManager.Send("Select");
            if (_customActions.UI.Start.inProgress) NetworkManager.Send("Start");
        }
    }
}