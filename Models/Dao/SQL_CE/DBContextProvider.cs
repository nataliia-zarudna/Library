using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Dao.SQL_CE
{
    public class DBContextProvider
    {
        private static LibraryEntities dbContext;

        public static LibraryEntities getDBContext()
        {
            if (dbContext == null)
            {
                dbContext = new LibraryEntities();
            }
            return dbContext;
        }

    }
}