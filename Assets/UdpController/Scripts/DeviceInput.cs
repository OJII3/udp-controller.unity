using UnityEngine;

namespace UdpController.Script
{
    public class DeviceInput : MonoBehaviour
    {
        private void FixedUpdate()
        {
            var lStickX = Input.GetAxis("X axis");
            var lStickY = Input.GetAxis("Y axis");
            var rStickX = Input.GetAxis("3rd axis");
            var rStickY = Input.GetAxis("3rd axis");
            Debug.Log("lStickX: " + lStickX + ", lStickY: " + lStickY + ", rStickX: " + rStickX + ", rStickY: " +
                      rStickY);
        }
    }
}