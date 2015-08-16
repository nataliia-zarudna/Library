using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models.Dao.SQL_CE;

namespace Library.Models.Dao
{
    public class GenreDAOFactory
    {
        private static GenreDAO GenreDAO;

        private GenreDAOFactory() { }

        public static GenreDAO GetGenreDAO()
        {
            if (GenreDAO == null)
            {
                GenreSqlCeDAOImpl genreDAOImpl = new GenreSqlCeDAOImpl();
                genreDAOImpl.dbContext = DBContextProvider.getDBContext();

                GenreDAO = genreDAOImpl;
            }

            return GenreDAO;
        }
    }
}