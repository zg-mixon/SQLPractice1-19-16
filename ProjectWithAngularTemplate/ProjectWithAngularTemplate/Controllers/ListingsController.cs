using ProjectWithAngularTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectWithAngularTemplate.Controllers
{
    public class ListingsController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public List<Listing> Get() {

            //var listings = (from l in _db.Listing
            //                select l).ToList();
            return _db.Listing.ToList();
        }
    }
}
