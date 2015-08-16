using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models.Dao.SQL_CE;

namespace Library.Models.Dao
{
    public class AuthorDAOFactory
    {
        private static AuthorDAO AuthorDAO;

        private AuthorDAOFactory() { }

        public static AuthorDAO GetAuthorDAO()
        {
            if (AuthorDAO == null)
            {
                AuthorSqlCeDAOImpl authorDAOImpl = new AuthorSqlCeDAOImpl();
                authorDAOImpl.dbContext = DBContextProvider.getDBContext();

                AuthorDAO = authorDAOImpl;
            }

            return AuthorDAO;
        }
    }
}