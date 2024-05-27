using BookTemplate;

namespace HorrorBookTemplate
{
    public class HorrorBook(string title, string author) : Book(title, author)
    {
        public override string GetGenre()
        {
            return "Horror Book";
        }
        public override void BorrowBook()
        {
            Console.WriteLine($"El libro '{title}' de horror ha sido prestado.");
        }
    }
}