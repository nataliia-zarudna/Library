using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Genre name must not be empty")
            , StringLength(20, MinimumLength=3, ErrorMessage = "Genre name length must be greater then 3 and less than 20")]
        public string Title { get; set; }

        public List<Book> Books { get; set; }

        public Genre() { }

        public Genre(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }
    }
}