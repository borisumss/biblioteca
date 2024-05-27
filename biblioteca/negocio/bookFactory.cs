using BookTemplate;
using FantasyBookTemplate;
using SciFiBookTemplate;
using HorrorBookTemplate;

namespace BookFactoryMethod
{
    public class BookFactory
    {
        public Book ProvideBook(string title, string author, string genre)
        {
            switch (genre.ToLower())
            {
                case "fantasy":
                    return new FantasyBook(title, author);
                case "scifi":
                    return new SciFiBook(title, author);
                case "horror":
                    return new HorrorBook(title, author);
                default:
                    throw new ArgumentException("This genre doesn't exist in the Library");
            }
        }
    }
}