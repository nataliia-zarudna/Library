using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models.Dao.SQL_CE
{
    public class GenreSqlCeDAOImpl : SqlCeDAO, GenreDAO
    {
        public Genre Create(Genre genre) 
        {
            dbContext.Genres.Add(genre);
            dbContext.SaveChanges();

            return genre;
        }

        public Genre Update(Genre genre)
        {
            dbContext.Entry(genre).State = EntityState.Modified;
            dbContext.SaveChanges();

            return genre;
        }

        public void Delete(int id)
        {
            Genre genre = FindByID(id);
            dbContext.Genres.Remove(genre);
            dbContext.SaveChanges();
        }

        public Genre FindByID(int id)
        {
            return dbContext.Genres.Include("Books").Single<Genre>(genre => genre.Id == id);
        }

        public List<Genre> FindAll()
        {
            return dbContext.Genres.ToList();
        }
    }
}