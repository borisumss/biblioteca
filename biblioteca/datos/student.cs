using UserTemplate;
using BookTemplate;
using UserObserverInterface;

namespace StudentTemplate
{
    public class Student(string name, string role) : User(name, role), IUserObserver
    {
        public void GetBorrowBook()
        {
            Console.WriteLine("Pedir libro prestado");
        }

        public void Update(Book book)
        {
            Console.WriteLine($"Estudiante {name} ha recibido una notificación sobre el libro '{book.GetTitle()}'");
        }
    }
}