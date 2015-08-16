using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models.Dao.SQL_CE
{
    public abstract class SqlCeDAO
    {
        public LibraryEntities dbContext { get; set; }
    }
}