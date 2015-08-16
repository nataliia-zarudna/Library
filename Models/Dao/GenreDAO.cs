using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Dao
{
    public interface GenreDAO
    {
        Genre Create(Genre genre);

        Genre Update(Genre genre);

        void Delete(int id);

        Genre FindByID(int id);

        List<Genre> FindAll();
    }
}