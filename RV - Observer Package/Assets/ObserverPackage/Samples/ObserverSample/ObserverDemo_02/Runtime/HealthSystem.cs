using ObserverPackage.Runtime;
using ObserverPackage.Samples.Runtime.ObserverDemo_02.Interfaces;
using UnityEngine;

namespace ObserverPackage.Samples.ObserverDemo_02.Runtime
{
    public class HealthSystem : MonoBehaviour, IHealthSystem
    {
        private readonly ISubject<int> healthChanged = new Subject<int>();

        public int CurrentHealth { get; private set; } = 100;

        public void TakeDamage(int damage)
        {
            CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);
            healthChanged.NotifyObservers(CurrentHealth);
        
            if (CurrentHealth == 0)
            {
                Debug.Log("Player Died!");
            }
        }

        public void Heal(int amount)
        {
            CurrentHealth = Mathf.Min(CurrentHealth + amount, 100);
            healthChanged.NotifyObservers(CurrentHealth);
        }

        public void AddObserver(IGenericObserver<int> observer) => healthChanged.AddObserver(observer);
        public void RemoveObserver(IGenericObserver<int> observer) => healthChanged.RemoveObserver(observer);
    }
}