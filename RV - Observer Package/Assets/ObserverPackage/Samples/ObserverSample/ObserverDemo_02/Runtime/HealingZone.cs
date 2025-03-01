using ObserverPackage.Samples.Runtime.ObserverDemo_02.Interfaces;
using UnityEngine;

namespace ObserverPackage.Samples.ObserverDemo_02.Runtime
{
    public class HealingZone : MonoBehaviour
    {
        [SerializeField] private int _healAmount = 10;
        [SerializeField] private bool _destroyAfterHeal;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IHealthSystem healthSystem))
            {
                healthSystem.Heal(_healAmount);
                Debug.Log($"{gameObject.name} healed {_healAmount} HP for {other.gameObject.name}");

                if (_destroyAfterHeal)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}