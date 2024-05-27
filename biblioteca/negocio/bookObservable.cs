using UserObserverInterface;

namespace BookObservableInterface
{
    public interface IBookObservable
    {
        void RegisterObserver(IUserObserver observer);
        void RemoveObserver(IUserObserver observer);
        void NotifyObservers();
    }
}