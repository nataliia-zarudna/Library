using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Dao.SQL_CE
{
    public class AuthorSqlCeDAOImpl : SqlCeDAO, AuthorDAO
    {
        public Author Create(Author author)
        {
            return null;
        }

        public Author Update(Author author)
        {
            return null;
        }

        public void Delete(int id)
        {
          
        }

        public List<Author> FindAll()
        {
            return dbContext.Authors.ToList();
        }
    }
}