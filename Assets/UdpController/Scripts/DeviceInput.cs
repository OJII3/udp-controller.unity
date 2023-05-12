using System.Text;
using UnityEngine;

namespace UdpController
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
            // check if network is connected
            if (NetworkManager.SendClient == null || NetworkManager.ReceiveClient == null) return;

            // 基本的に、byte (uint8) で送る
            var uint8Arr = new byte[9];
            var dataHead = "J";

            // 押している(true)間はbitを立てて、４つごとに１６進数に変換する(0x0 ~ 0xFとなるので、１文字で表現できる = ４bit)
            // 別に４つじゃなくて2つに分けるのでもいけたはずだけど、これまでに合わせて４つにしておく
            var buttonDataInt1 = 0;
            buttonDataInt1 += _customActions.UI.RightStickPress.inProgress ? 0b0001 : 0x0000;
            buttonDataInt1 += _customActions.UI.LeftStickPress.inProgress ? 0b0010 : 0b0000;
            buttonDataInt1 += _customActions.UI.Select.inProgress ? 0b0100 : 0x0000;
            buttonDataInt1 += _customActions.UI.Start.inProgress ? 0b1000 : 0x0000;

            var buttonDataInt2 = 0;
            buttonDataInt2 += _customActions.UI.R2.inProgress ? 0b0001 : 0b0000;
            buttonDataInt2 += _customActions.UI.L2.inProgress ? 0b0010 : 0b0000;
            buttonDataInt2 += _customActions.UI.R1.inProgress ? 0b0100 : 0b0000;
            buttonDataInt2 += _customActions.UI.L1.inProgress ? 0b1000 : 0b0000;

            var buttonDataInt3 = 0;
            buttonDataInt3 += _customActions.UI.Square.inProgress ? 0b0001 : 0b000;
            buttonDataInt3 += _customActions.UI.Cross.inProgress ? 0b0010 : 0b0000;
            buttonDataInt3 += _customActions.UI.Circle.inProgress ? 0b0100 : 0b0000;
            buttonDataInt3 += _customActions.UI.Triangle.inProgress ? 0b1000 : 0b0000;

            var buttonDataInt4 = 0;
            buttonDataInt4 += _customActions.UI.DPadLeft.inProgress ? 0b0001 : 0b0000;
            buttonDataInt4 += _customActions.UI.DPadDown.inProgress ? 0b0010 : 0b0000;
            buttonDataInt4 += _customActions.UI.DPadRight.inProgress ? 0b0100 : 0b0000;
            buttonDataInt4 += _customActions.UI.DPadUp.inProgress ? 0b1000 : 0b0000;

            // 符号をなくすため、0~100に変換する
            var leftPadX = _customActions.UI.LeftStickX.ReadValue<float>() * 50;
            var leftPadY = _customActions.UI.LeftStickY.ReadValue<float>() * 50;
            var rightPadX = _customActions.UI.RightStickX.ReadValue<float>() * 50;
            var rightPadY = _customActions.UI.RightStickY.ReadValue<float>() * 50;

            uint8Arr[0] = Encoding.UTF8.GetBytes(dataHead)[0];
            uint8Arr[1] = (byte)buttonDataInt1;
            uint8Arr[2] = (byte)buttonDataInt2;
            uint8Arr[3] = (byte)buttonDataInt3;
            uint8Arr[4] = (byte)buttonDataInt4;
            uint8Arr[5] = (byte)leftPadX;
            uint8Arr[6] = (byte)leftPadY;
            uint8Arr[7] = (byte)rightPadX;
            uint8Arr[8] = (byte)rightPadY;

            Debug.Log(
                $"msg: {uint8Arr}: {uint8Arr[0]}, {uint8Arr[1]}, {uint8Arr[2]}, {uint8Arr[3]}, {uint8Arr[4]}, {uint8Arr[5]}, {uint8Arr[6]}, {uint8Arr[7]}, {uint8Arr[8]}");
            NetworkManager.Send(uint8Arr);
        }
    }
}