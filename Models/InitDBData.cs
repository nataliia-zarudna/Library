using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    public class InitDBData : DropCreateDatabaseIfModelChanges<LibraryEntities>
    {
        protected override void Seed(LibraryEntities context)
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author(1, "Joan", "Rowling"));
            authors.Add(new Author(2, "Agatha", "Christie"));
            authors.Add(new Author(3, "John Ronald Reuel", "Tolkien"));
            authors.ForEach(author => context.Authors.Add(author));
            context.SaveChanges();

            List<Genre> genres = new List<Genre>();
            genres.Add(new Genre(1, "Fantasy"));
            genres.Add(new Genre(2, "Detective"));
            genres.ForEach(genre => context.Genres.Add(genre));
            context.SaveChanges();

            List<Book> books = new List<Book>();
            books.Add(new Book(1, 1, "Harry Potter and the Philosopher's Stone", 1, "J_K_Rowling_Harry_Potter_and_the_Sorcerers_Stone.pdf"));
            books.Add(new Book(2, 1, "Lord of the Ring: The Fellowship of the Ring", 3, "Tolkien_Lord_of_the_Rings_The_Fellowship_of_The_Ring.pdf"));
            books.Add(new Book(3, 2, "The Murder of Roger Ackroyd", 2, "Agatha_Christie_The_Murder_of_Roger_Ackroyd.pdf"));
            books.Add(new Book(4, 2, "The A.B.C. Murders", 2, "Agatha_Christie_The_ABC_Murders.pdf"));
            books.ForEach(book => context.Books.Add(book));
            context.SaveChanges();
        }

    }
}