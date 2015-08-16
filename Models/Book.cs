using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int GenreID { get; set; }

        [Required(ErrorMessage = "Book name must not be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author must not be empty")]
        public int AuthorID { get; set; }

        [FileExtensions(Extensions = "pdf", ErrorMessage = "Please, choose PDF file")]
        public string Filepath { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }

        public Book() { }

        public Book(int id, int genreID, string title, int authorID, string filepath)
        {
            this.Id = id;
            this.GenreID = genreID;
            this.Title = title;
            this.AuthorID = authorID;
            this.Filepath = filepath;
        }
    }
}