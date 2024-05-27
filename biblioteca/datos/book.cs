using BookObservableInterface;
using UserObserverInterface;

namespace BookTemplate
{
    public abstract class Book(string title, string author) : IBookObservable
    {
        private List<IUserObserver> observers = new List<IUserObserver>();
        public string title = title;
        public string author = author;

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public abstract string GetGenre();
        public abstract void BorrowBook();

        // Implementa métodos para registrar, desregistrar y notificar observadores
        public void RegisterObserver(IUserObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IUserObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}