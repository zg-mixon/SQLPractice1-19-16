using CustomersWithAddresses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomersWithAddresses.Controllers {
    public class CustomersController : ApiController {

        public Customer Get(int id)
        {
            var db = new ApplicationDbContext();

            return (from c in db.Customers
                .Include(c => c.BillingAddress)
                .Include(c => c.ShippingAddress)
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public IHttpActionResult Post(Customer customer) {

            var db = new ApplicationDbContext();

            db.Customers.Add(customer);
            db.SaveChanges();

            return Ok();
        }
        public IHttpActionResult Delete(int id) {
            var db = new ApplicationDbContext();
            var customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return Ok();
        }
    }
}
