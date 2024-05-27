using System;
using BookFactoryMethod;
using BookTemplate;
using LibraryChiefTemplate;
using LibraryManagerClass;
using LibraryManagerInterface;
using LibraryPanel;
using LibraryPanelView;
using StudentTemplate;
using UserManagerClass;
using UserManagerInterface;


namespace Library
{

    public class Library
    {
        static void Main(string[] args)
        {
            // Demostracion del patron 'Factory Method'
            Console.WriteLine("Demostracion del patron Factory Method");
            BookFactory factory = new();

            Book sciFiBook = factory.ProvideBook("La Mosca", "George Langelaan", "scifi");
            Book fantasyBook = factory.ProvideBook("Harry Potter", "JK Rowling", "fantasy");
            Book horrorBook = factory.ProvideBook("IT", "Stephen King", "horror");

            Console.WriteLine("Sci-Fi Book:");
            Console.WriteLine("Title: " + sciFiBook.GetTitle());
            Console.WriteLine("Author: " + sciFiBook.GetAuthor());
            Console.WriteLine("Genre: " + sciFiBook.GetGenre());
            Console.WriteLine("");
            Console.WriteLine("Fantasy Book:");
            Console.WriteLine("Title: " + fantasyBook.GetTitle());
            Console.WriteLine("Author: " + fantasyBook.GetAuthor());
            Console.WriteLine("Genre: " + fantasyBook.GetGenre());
            Console.WriteLine("");
            Console.WriteLine("Horror Book:");
            Console.WriteLine("Title: " + horrorBook.GetTitle());
            Console.WriteLine("Author: " + horrorBook.GetAuthor());
            Console.WriteLine("Genre: " + horrorBook.GetGenre());
            Console.WriteLine("");

            // Desmostracion del patron "Adapter"
            // Crear instancias de las clases relevantes
            Console.WriteLine("Demostracion del patron Adapter");
            IUserManager userManager = new UserManager();
            ILibraryManager libraryManager = new LibraryManager();

            // Crear instancias de los adaptadores
            ILibraryPanel libraryPanel = new LibraryPanelAdapter(libraryManager, userManager);

            // Ejemplo de uso del sistema de autenticación y préstamo de libro
            Console.WriteLine("Bienvenido a la biblioteca:");
            libraryPanel.UserAuthentication(); // Autenticar usuario
            libraryPanel.BorrowBook(); // Pedir prestado un libro
            libraryPanel.UserLogout(); // Cerrar sesión

            // Demostracion del patron "Observer"
            // Crear usuarios (observadores)
            Console.WriteLine("Demostracion del patron Observer");
            Student student = new Student("Jose", "Student");
            LibraryChief libraryChief = new LibraryChief("Raul", "Library Chief");

            // Registrar los usuarios como observadores del libro
            sciFiBook.RegisterObserver(student);
            sciFiBook.RegisterObserver(libraryChief);

            // El estudiante pide prestado el libro
            Console.WriteLine($"Estudiante {student.GetName()} pidió prestado el libro '{sciFiBook.GetTitle()}'");
            // Cambiar el estado del libro y notificar a los observadores
            sciFiBook.BorrowBook();
            sciFiBook.NotifyObservers();

            // Esto imprimirá un mensaje para cada observador indicando que el libro ha sido prestado
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
