using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Library.Models;
using Library.Models.Dao;

namespace Library.Controllers
{
    public class EditGenresController : Controller
    {
        private BookDAO BookDAO;
        private AuthorDAO AuthorDAO;
        private GenreDAO GenreDAO;

        public EditGenresController()
        {
            BookDAO = BookDAOFactory.GetBookDAO();
            AuthorDAO = AuthorDAOFactory.GetAuthorDAO();
            GenreDAO = GenreDAOFactory.GetGenreDAO();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditGenres()
        {
            List<Genre> genres = GenreDAO.FindAll();
            return View(genres);
        }

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            GenreDAO.Create(genre);

            return RedirectToAction("Index");
        }

        public ActionResult GenreBooks(int genreID)
        {
            Genre searchedGenre = GenreDAO.FindByID(genreID);
            ViewBag.Genre = searchedGenre;

            List<Book> books = searchedGenre.Books;

            return View(books);
        }

        public ActionResult Update(Genre genre)
        {
            GenreDAO.Update(genre);
            return RedirectToAction("GenreBooks", new { genreID = genre.Id });
        }

        public ActionResult Delete(int id)
        {
            GenreDAO.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
