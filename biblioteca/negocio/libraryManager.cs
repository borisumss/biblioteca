using LibraryManagerInterface;

namespace LibraryManagerClass
{
    public class LibraryManager : ILibraryManager
    {
        public void AddBook()
        {
            Console.WriteLine("Libro Añadido");
        }
        public void SaveBook()
        {
            Console.WriteLine("Libro Guardado");
        }

        public void BorrowBook()
        {
            Console.WriteLine("Libro Prestado");
        }

        public void ReturnBook()
        {
            Console.WriteLine("Libro Devuelto");
        }
    }
}