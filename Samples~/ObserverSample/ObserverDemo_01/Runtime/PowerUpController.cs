using System.Collections.Generic;
using ObserverPackage.Runtime;
using UnityEngine;

namespace ObserverPackage.Samples.Runtime.ObserverDemo_01
{
    public class PowerUpController : MonoBehaviour
    {
        public static PowerUpController Instance;

        private readonly Dictionary<PowerUpType, int> _powerUpCounts = new Dictionary<PowerUpType, int>();
        private readonly ISubject<PowerUpData> _subject = new Subject<PowerUpData>();

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
            {
                Destroy(gameObject);
                return;
            }
           
            foreach (PowerUpType type in System.Enum.GetValues(typeof(PowerUpType)))
                _powerUpCounts[type] = 0;
        }

        public void CollectPowerUp(PowerUpType type)
        {
            _powerUpCounts[type]++;
            _subject.NotifyObservers(new PowerUpData(type, _powerUpCounts[type]));
        }

        public int GetPowerUpCount(PowerUpType type) => _powerUpCounts[type];
        public void AddObserver(IGenericObserver<PowerUpData> genericObserver) 
            => _subject.AddObserver(genericObserver);
        
        public void RemoveObserver(IGenericObserver<PowerUpData> genericObserver) 
            => _subject.RemoveObserver(genericObserver);
    }
}