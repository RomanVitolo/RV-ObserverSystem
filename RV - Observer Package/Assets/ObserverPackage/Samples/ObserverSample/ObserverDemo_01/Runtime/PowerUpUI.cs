using System.Collections.Generic;
using ObserverPackage.Runtime;
using TMPro;
using UnityEngine;

namespace ObserverPackage.Samples.Runtime.ObserverDemo_01
{
    public class PowerUpUI : MonoBehaviour, IGenericObserver<PowerUpData>
    {
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private TextMeshProUGUI _speedText;
        [SerializeField] private TextMeshProUGUI _shieldText;

        private Dictionary<PowerUpType, TextMeshProUGUI> _powerUpTextMap;

        private void Start()
        {
            _powerUpTextMap = new Dictionary<PowerUpType, TextMeshProUGUI>
            {
                { PowerUpType.Health, _healthText },
                { PowerUpType.Speed, _speedText },
                { PowerUpType.Shield, _shieldText }
            };

            PowerUpController.Instance.AddObserver(this);
            
            foreach (var type in _powerUpTextMap.Keys)
                UpdateUI(new PowerUpData(type, PowerUpController.Instance.GetPowerUpCount(type)));
        }

        public void OnNotify(PowerUpData data) => UpdateUI(data);
        private void UpdateUI(PowerUpData data)
        {
            if (_powerUpTextMap.TryGetValue(data.Type, out TextMeshProUGUI textElement))
                textElement.text = $"{data.Type}: {data.Count}";
        }
        private void OnDestroy() => PowerUpController.Instance.RemoveObserver(this);
    }
}