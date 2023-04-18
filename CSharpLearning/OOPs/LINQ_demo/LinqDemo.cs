using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearning.OOPs.LINQ_demo;

class Book
{
    public string Text { get; set; }
    public double Price { get; set; }
}

class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>()
        {
            new Book() { Text = "C#", Price = 90 },
            new Book() { Text = "Java", Price = 60 },
            new Book() { Text = "C++", Price = 80 },
            new Book() { Text = "Python", Price = 40 },
            new Book() { Text = "PHP", Price = 50 },
            new Book() { Text = "Rust", Price = 100 },
        };
    }
}

public class LinqDemo
{
    public static void Run()
    {
        var bookRepository = new BookRepository();
        var books = bookRepository.GetBooks();

        
        
        
        // Skip first 2 and take last 3 objects
        var lastThreeBooks = books.Skip(2).Take(3);
        
        
        
        // some other LINQ methods
        /*******************************************************************************************
        books.Max(book => book.Price);
        books.Min(book => book.Price);
        books.Sum(book => book.Price);
        books.Average(book => book.Price);
        books.Any();
        books.All();
        books.Contains("C++");
        books.Count();
        books.Distinct();
        books.ElementAt(2);
        books.First();
        books.FirstOrDefault();
        books.Last();
        books.LastOrDefault();
        books.Single();
        books.SingleOrDefault();
        books.ToList();
        books.ToArray();
        books.ToDictionary();
        books.ToList();
        books.ToArray();
        */
        
        
        
        // This is how LINQ works
        // Here OrderBy(), Where, etc are some LINQ methods.
        var sortedBooks = books.OrderBy(book => book.Price).ToList();
        var filteredBooks = books.Where(book => book.Price < 70);
        

        
        
        
        // First() or FirstOrDefault()
        var firstBook1 = books.First();
        var firstBook2 = books.First(b => b.Text.Equals("abc"));
        
        var firstBookOrDefault1 = books.FirstOrDefault();
        var firstBookOrDefault2 = books.FirstOrDefault(b => b.Text.Equals("abc"));
        
        
        
        
        // Last or LastOrDefault
        
        var lastBook1 = books.Last();
        var lastBook2 = books.Last(b => b.Text.Equals("abc"));
        
        var lastBookOrDefault1 = books.LastOrDefault();
        var lastBookOrDefault2 = books.LastOrDefault(b => b.Text.Equals("abc"));
        
        
        
        
        // get only one book otherwise it throws exception
        Book singleBook = books.Single(book => book.Text.Equals("C++*")); 
        
        // get only one book otherwise get a default value.
        Book singleBookOrDefault = books.SingleOrDefault(book => book.Text.Equals("C++*"), new Book());  
        
        Console.WriteLine($"{singleBook.Text} & {singleBook.Price}");
        
        

        
        // This is short form of LINQ queries. Here, in the last "select" keyword is for projection.
        var mySelectedBook = from book in books where book.Price < 70 orderby book.Text select book;
        var onlyBookNames = from book in books where book.Price < 70 orderby book.Text select book.Text;

        
        
        
        // printing books
        foreach (var book in mySelectedBook)
        {
            Console.WriteLine($"Book: {book.Text} & Price: {book.Price}");
        }
    }
}