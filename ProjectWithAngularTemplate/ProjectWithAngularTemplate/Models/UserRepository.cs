using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWithAngularTemplate.Models
{
    public class UserRepository :GenericRepository<User>
    {
        public UserRepository(DbContext db) : base(db)
        { }
        public bool Update(User updates)
        {
            var dbUser = Get(updates.Id);
            if (dbUser != null)
            {
                dbUser.Email = updates.Email;
                dbUser.userListing = updates.userListing;
                try
                {
                    _db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}

        

        
        