using ObserverPackage.Samples.Runtime.ObserverDemo_01.Interfaces;
using UnityEngine;

namespace ObserverPackage.Samples.Runtime.ObserverDemo_01
{
    public class PowerUp : MonoBehaviour, ICollectible
    {
        [SerializeField] private PowerUpType _type;

        public PowerUpType Type => _type;

        private void OnTriggerEnter(Collider other)
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            if (player != null)
                Collect();
        }

        public void Collect()
        {
            PowerUpController.Instance.CollectPowerUp(_type);
            Destroy(gameObject); 
        }
    }
}