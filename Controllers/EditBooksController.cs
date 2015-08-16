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
    public class EditBooksController : Controller
    {
        private BookDAO BookDAO;
        private AuthorDAO AuthorDAO;
        private GenreDAO GenreDAO;

        public EditBooksController()
        {
            BookDAO = BookDAOFactory.GetBookDAO();
            AuthorDAO = AuthorDAOFactory.GetAuthorDAO();
            GenreDAO = GenreDAOFactory.GetGenreDAO();
        }

        public ActionResult Create(int genreID)
        {
            ViewBag.AuthorID = new SelectList(AuthorDAO.FindAll(), "Id", "LastName");
            ViewBag.GenreID = new SelectList(GenreDAO.FindAll(), "Id", "Title", genreID);

            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                BookDAO.Create(book);
                return RedirectToAction("GenreBooks", "EditGenres", new { genreID = book.GenreID });

            }
            else
            {
                ViewBag.AuthorID = new SelectList(AuthorDAO.FindAll(), "Id", "LastName");
                ViewBag.GenreID = new SelectList(GenreDAO.FindAll(), "Id", "Title", book.GenreID);

                return View(book);
            }           
        }

        public ActionResult Edit(int id)
        {
            Book book = BookDAO.FindByID(id);

            ViewBag.AuthorID = new SelectList(AuthorDAO.FindAll(), "Id", "LastName", book.AuthorID);
            ViewBag.GenreID = new SelectList(GenreDAO.FindAll(), "Id", "Title", book.GenreID);

            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                BookDAO.Update(book);
                return RedirectToAction("GenreBooks", "EditGenres", new { genreID = book.GenreID });
            }
            else
            {
                return Edit(book.Id);
            }
        }

        public ActionResult Delete(int id)
        {
            int genderID = BookDAO.FindByID(id).GenreID;

            BookDAO.Delete(id);

            return RedirectToAction("GenreBooks", "EditGenres", new { genreID = genderID });
        }

    }
}
