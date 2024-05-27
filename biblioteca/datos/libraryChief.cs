using UserTemplate;
using BookTemplate;
using UserObserverInterface;

namespace LibraryChiefTemplate
{
    public class LibraryChief(string name, string role) : User(name, role), IUserObserver
    {
        public void AuthorizationSystem()
        {
            Console.WriteLine("Acceso al sistema de la Biblioteca");
        }

        public void Update(Book book)
        {
            Console.WriteLine($"Jefe de biblioteca {name} ha recibido una notificación sobre el libro '{book.GetTitle()}'");
        }
    }
}