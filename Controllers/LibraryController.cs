using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Library.Models.Dao;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {        
        private BookDAO BookDAO;
        private AuthorDAO AuthorDAO;
        private GenreDAO GenreDAO;

        public LibraryController()
        {
            BookDAO = BookDAOFactory.GetBookDAO();
            AuthorDAO = AuthorDAOFactory.GetAuthorDAO();
            GenreDAO = GenreDAOFactory.GetGenreDAO();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Genres()
        {
            List<Genre> genres = GenreDAO.FindAll();
            return PartialView(genres);
        }

        public ActionResult GenreBooks(int genreID)
        {
            Genre searchedGender = GenreDAO.FindByID(genreID);
            List<Book> books = searchedGender.Books;
            return View(books);
        }

        public ActionResult BookDetails(int id)
        {
            Book searchedBook = BookDAO.FindByID(id);
            return View(searchedBook);
        }

    }
}
