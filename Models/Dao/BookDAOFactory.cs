using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models.Dao.SQL_CE;

namespace Library.Models.Dao
{
    public class BookDAOFactory
    {
        private static BookDAO BookDAO;

        private BookDAOFactory() { }

        public static BookDAO GetBookDAO()
        {
            if (BookDAO == null)
            {
                BookSqlCeDAOImpl bookDAOImpl = new BookSqlCeDAOImpl();
                bookDAOImpl.dbContext = DBContextProvider.getDBContext();

                BookDAO = bookDAOImpl;
            }

            return BookDAO;
        }
    }
}