using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWithAngularTemplate.Models
{
    public class ListingRepository : GenericRepository<Listing>
    {


        public ListingRepository(DbContext db) : base(db) {

        }
        public bool Update(Listing updates)
        {
            var dbItem = Get(updates.Id);
            if (dbItem != null) {
                dbItem.Description = updates.Description;
                dbItem.Category = updates.Category;
                dbItem.Owner = updates.Owner;
                dbItem.Picture = updates.Picture;
                dbItem.Title = updates.Title;
                

                try
                {
                    _db.SaveChanges();
                    return true;
                }
                catch {
                    return false;
                }
            }
            return false;
        }
    }
}
        




        


        


        