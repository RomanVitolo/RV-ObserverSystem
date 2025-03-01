using System.Collections.Generic;

namespace ObserverPackage.Runtime
{
    public class Subject<T> : ISubject<T>
    {
        private readonly List<IGenericObserver<T>> _observers = new();
        
        public void AddObserver(IGenericObserver<T> genericObserver)
        {
            if (!_observers.Contains(genericObserver))
                _observers.Add(genericObserver);
        }

        public void RemoveObserver(IGenericObserver<T> genericObserver)
        {
            if (_observers.Contains(genericObserver))
                _observers.Remove(genericObserver);
        }

        public void NotifyObservers(T data)
        {
            foreach (var observer in _observers)
                observer.OnNotify(data);
        }
    }
}