using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWithAngularTemplate.Models
{
    public class ApplicationDbContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Listing> Listing { get; set; }
        public IDbSet<Category> Category { get; set; }
    }
}