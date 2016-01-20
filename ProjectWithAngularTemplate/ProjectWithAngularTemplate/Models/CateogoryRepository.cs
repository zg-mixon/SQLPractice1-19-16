using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWithAngularTemplate.Models
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(DbContext db) : base(db) {

        }

        
        public bool Update(Category updates)
        {
            var dbCategory = Get(updates.Id);
            if (dbCategory != null)
            {
                dbCategory.Name = updates.Name;
                dbCategory.Listing = updates.Listing;
                
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