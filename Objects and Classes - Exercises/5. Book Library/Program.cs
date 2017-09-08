using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; } //dd.MM.yyyy
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Library library = new Library {Name = "FirstLibrary", Books =  new List<Book>()};
            for (int i = 0; i < n; i++)
            {
                ReadBook(library);
            }
            
            SortedDictionary<string, decimal> authorsPrices = new SortedDictionary<string, decimal>();
            FillAuthorsPrices(library, authorsPrices);
            PrintAuthorPrices(authorsPrices);
        }

        private static void PrintAuthorPrices(SortedDictionary<string, decimal> authorsPrices)
        {
            var sortedByPrice = authorsPrices.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var author in sortedByPrice)
            {
                var authorName = author.Key;
                var price = author.Value;
                Console.WriteLine($"{authorName} -> {price:F2}");
            }
        }

        private static void FillAuthorsPrices(Library library, SortedDictionary<string, decimal> authorsPrices)
        {
            foreach (var book in library.Books)
            {
                if (!authorsPrices.ContainsKey(book.Author))
                {
                        authorsPrices.Add(book.Author, book.Price);
                }
                else
                {
                    authorsPrices[book.Author] += book.Price;
                }
            }
        }

        private static void ReadBook(Library library)
        {
            Book currentBook = new Book();
            var tokens = Console.ReadLine().Split();
            currentBook.Title = tokens[0];
            currentBook.Author = tokens[1];
            currentBook.Publisher = tokens[2];
            currentBook.ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            currentBook.Isbn = tokens[4];
            currentBook.Price = decimal.Parse(tokens[5]);
            library.Books.Add(currentBook);
        }
    }
}
