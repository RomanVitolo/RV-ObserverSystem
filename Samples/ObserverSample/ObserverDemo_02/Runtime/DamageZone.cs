using ObserverPackage.Samples.Runtime.ObserverDemo_02.Interfaces;
using UnityEngine;

namespace ObserverPackage.Samples.ObserverDemo_02.Runtime
{
    public class DamageZone : MonoBehaviour
    {
        [SerializeField] private int _damageAmount = 20;
        [SerializeField] private bool _destroyAfterDamage;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IHealthSystem healthSystem))
            {
                healthSystem.TakeDamage(_damageAmount);
                Debug.Log($"{gameObject.name} dealt {_damageAmount} damage to {other.gameObject.name}");

                if (_destroyAfterDamage)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}