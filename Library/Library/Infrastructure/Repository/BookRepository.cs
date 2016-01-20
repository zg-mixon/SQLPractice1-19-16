using CoderCamps.Infrastructure.Repository;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Infrastructure.Repository
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(ApplicationDbContext db) : base(db) { }
    }
}