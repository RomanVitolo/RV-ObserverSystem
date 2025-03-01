using ObserverPackage.Runtime;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace ObserverPackage.Samples.ObserverDemo_02.Runtime
{
    public class HealthUI : MonoBehaviour, IGenericObserver<int>
    {
        [SerializeField] private HealthSystem _healthSystem;
        [SerializeField] private Slider _healthSlider;

        private void Start()
        {
            _healthSystem.AddObserver(this);
            _healthSlider.value = 1; 
        }

        public void OnNotify(int newHealth)
        {
            _healthSlider.value = newHealth / 100f;
        }
        
        private void OnDestroy()
        {
            if (_healthSystem != null)
            {
                _healthSystem.RemoveObserver(this);
            }
        }
        
        public HealthSystem GetHealthSystem => _healthSystem;
    }
}