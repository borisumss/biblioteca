using BookTemplate;

namespace SciFiBookTemplate
{
    public class SciFiBook(string title, string author) : Book(title, author)
    {
        public override string GetGenre()
        {
            return "Science Fiction Book";
        }
        public override void BorrowBook()
        {
            Console.WriteLine($"El libro '{title}' de ciencia ficcion ha sido prestado.");
        }
    }    
}