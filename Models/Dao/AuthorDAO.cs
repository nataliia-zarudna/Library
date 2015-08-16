using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Dao
{
    public interface AuthorDAO
    {
        Author Create(Author author);

        Author Update(Author author);

        void Delete(int id);

        List<Author> FindAll();

    }
}