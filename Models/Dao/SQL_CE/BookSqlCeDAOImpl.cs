using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Models.Dao;

namespace Library.Models.Dao.SQL_CE
{
    public class BookSqlCeDAOImpl : SqlCeDAO, BookDAO
    {
        public Book Create(Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            Book createdBook = dbContext.Books.Find(book.Id);

            return createdBook;
        }

        public Book Update(Book book)
        {
            dbContext.Entry(book).State = EntityState.Modified;
            dbContext.SaveChanges();
            return book;
        }

        public void Delete(int id)
        {
            Book book = dbContext.Books.Find(id);
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
        }

        public Book FindByID(int id)
        {
            return dbContext.Books.Include("Author").Single(book => book.Id == id);
        }

        public List<Book> FindByGenreID(int genreID)
        {
            Genre searchedGenre = dbContext.Genres.Include("Books").Single<Genre>(genre => genre.Id == genreID);
            List<Book> books = searchedGenre.Books;

            return books;
        }
    }
}