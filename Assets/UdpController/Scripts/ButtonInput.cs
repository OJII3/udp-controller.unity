using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UdpController
{
    public class ButtonInput : MonoBehaviour
    {
        [SerializeField] private Button[] poleButtons;
        [SerializeField] private TMP_InputField targetIPField;
        [SerializeField] private Button connectButton;
        private CustomInputActions _customInputActions;

        private void Start()
        {
            _customInputActions = new CustomInputActions();
            _customInputActions.Enable();

            poleButtons.ToList()
                .ForEach(button => button.onClick.AddListener(() => { OnClickPole(int.Parse(button.name)); }));
            connectButton.onClick.AddListener(OnClickConnect);
        }

        private void OnDestroy()
        {
            _customInputActions.Disable();
            NetworkManager.Close();
        }

        private void OnClickConnect()
        {
            if (NetworkManager.IsConnecting)
            {
                Debug.Log("You are already connected!");
                return;
            }

            NetworkManager.Connect(targetIPField.text, 8888);
        }

        private void OnClickPole(int poleNum)
        {
            if (!NetworkManager.IsConnecting)
            {
                Debug.Log("You are not connected!");
                return;
            }

            Debug.Log($"Pole {poleNum} clicked!");
            NetworkManager.Send($"{poleNum}");
        }
    }
}