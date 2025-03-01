using ObserverPackage.Runtime;
using ObserverPackage.Samples.Runtime.ObserverDemo_02.Interfaces;
using UnityEngine;

namespace ObserverPackage.Samples.ObserverDemo_02.Runtime
{
    public class HealthAudio : MonoBehaviour, IGenericObserver<int>
    {
        [SerializeField] private HealthSystem _healthSystem;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _damageSound;
        [SerializeField] private AudioClip _healSound;

        private int lastHealth;
        
        private void Awake()
        {
            if (_healthSystem == null) return;
            _healthSystem.AddObserver(this);
            lastHealth = _healthSystem.CurrentHealth;
        }

        public void OnNotify(int newHealth)
        {
            if (_audioSource == null) return;
            
            if (newHealth < lastHealth)
            {
                if (_audioSource != null)
                {
                    _audioSource.clip = _damageSound;
                    _audioSource.Play();
                }
            }
            else if (newHealth > lastHealth)
            {
                if (_audioSource != null)
                {
                    _audioSource.clip = _healSound;
                    _audioSource.Play();
                }
            }

            lastHealth = newHealth;
        }
        
        private void OnDestroy()
        {
            if (_healthSystem != null)
            {
                _healthSystem.RemoveObserver(this);
            }
        }
    }
}