namespace ObserverPackage.Runtime
{
    public interface ISubject<T>
    {
        void AddObserver(IGenericObserver<T> genericObserver);
        void RemoveObserver(IGenericObserver<T> genericObserver);
        void NotifyObservers(T data);
    }
}