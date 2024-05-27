using BookTemplate;

namespace FantasyBookTemplate
{
    public class FantasyBook(string title, string author) : Book(title, author)
    {
        public override string GetGenre()
        {
            return "Fantasy Book";
        }
        public override void BorrowBook()
        {
            Console.WriteLine($"El libro '{title}' de fantasia ha sido prestado.");
        }
    }
}