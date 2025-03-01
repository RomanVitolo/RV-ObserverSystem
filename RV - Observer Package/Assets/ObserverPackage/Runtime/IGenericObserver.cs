namespace ObserverPackage.Runtime
{
    public interface IGenericObserver<in T>    
    {
        void OnNotify(T data); 
    }
}