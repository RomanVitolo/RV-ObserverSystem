using ObserverPackage.Runtime;

namespace ObserverPackage.Samples.Runtime.ObserverDemo_02.Interfaces
{
    public interface IHealthSystem
    {
        int CurrentHealth { get; }
        void TakeDamage(int damage);
        void Heal(int amount);
        void AddObserver(IGenericObserver<int> observer);
        void RemoveObserver(IGenericObserver<int> observer);
    }
}