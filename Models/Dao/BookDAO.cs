using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Dao
{
    public interface BookDAO
    {
        Book Create(Book book);

        Book Update(Book book);

        void Delete(int id);

        Book FindByID(int id);

        List<Book> FindByGenreID(int genreID);

    }
}
