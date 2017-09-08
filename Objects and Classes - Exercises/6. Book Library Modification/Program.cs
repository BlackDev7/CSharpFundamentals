using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Book_Library_Modification
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
            Library library = new Library { Name = "FirstLibrary", Books = new List<Book>() };
            for (int i = 0; i < n; i++)
            {
                ReadBook(library);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, DateTime> sortedDict = new Dictionary<string, DateTime>();
            var sortedByTime = FilterAndSortBooks(givenDate, library, sortedDict);
            PrintBooks(library, sortedByTime);
        }

        private static void PrintBooks(Library library, Dictionary<string, DateTime> sortedByTime)
        {
            foreach (var book in sortedByTime)
            {
                var title = book.Key;
                var date = book.Value;

                Console.WriteLine($"{title} -> {date:dd.MM.yyyy}");
            }
        }

        private static Dictionary<string, DateTime> FilterAndSortBooks(DateTime givenDate, Library library, Dictionary<string, DateTime> sortedDict)
        {
            foreach (var book in library.Books)
            {
                if (book.ReleaseDate > givenDate)
                {
                    sortedDict.Add(book.Title, book.ReleaseDate);
                }
            }
            return sortedDict.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
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
