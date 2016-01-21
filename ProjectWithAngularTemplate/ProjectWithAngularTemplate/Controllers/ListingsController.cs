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
        private ListingRepository _repo;

        public ListingsController(ListingRepository repo)
        {
            _repo = repo;
        }

        public IList<Listing> Get()
        {
            return _repo.List();
        }

        //Search
        public Listing Get(int id)
        {
            return _repo.Get(id);
        }

        //Create
        public IHttpActionResult Post(Listing newListing)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    _repo.Add(newListing);
                    _repo.SaveChanges();
                    return Created("/api/listing/" + newListing.Id, newListing);
                }
                catch
                {
                    return InternalServerError();
                }
            }
            return BadRequest();

        }


        //Update
        public IHttpActionResult Post(int id, Listing updates)
        {
            if (ModelState.IsValid)
            {
                updates.Id = id;
                if (_repo.Update(updates))
                {
                    return Ok();
                }
                return InternalServerError();
            }

            return BadRequest(ModelState);
        }



        public IHttpActionResult Delete(int id)
        {
            try
            {
                var dbItem = _repo.Get(id);
                if (dbItem != null)
                {
                    _repo.Delete(dbItem);
                    _repo.SaveChanges();
                    return Ok();
                }
                return BadRequest();
            }
            catch
            {
                return InternalServerError();
            }
        }

    }
}
