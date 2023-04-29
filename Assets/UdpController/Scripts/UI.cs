using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UdpController
{
    public class UI : MonoBehaviour
    {
        [SerializeField] private Button[] poleButtons;
        [SerializeField] private TMP_InputField targetIPField;
        [SerializeField] private TMP_InputField targetPortField;
        [SerializeField] private Button connectButton;
        [SerializeField] private Button closeButton;
        [SerializeField] private TMP_InputField logField;

        private void Start()
        {
            poleButtons.ToList()
                .ForEach(button => button.onClick.AddListener(() => { OnClickPole(int.Parse(button.name)); }));
            connectButton.onClick.AddListener(OnClickConnect);
            closeButton.onClick.AddListener(OnClickClose);
        }

        private void Update()
        {
            logField.text = NetworkManager.Log;
        }

        private void OnDestroy()
        {
        }

        private void OnClickConnect()
        {
            NetworkManager.Connect(targetIPField.text, int.Parse(targetPortField.text));
        }

        private void OnClickClose()
        {
        }

        private void OnClickPole(int poleNum)
        {
            NetworkManager.Send($"{poleNum}");
        }
    }
}