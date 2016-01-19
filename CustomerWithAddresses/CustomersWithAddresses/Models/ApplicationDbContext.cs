﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomersWithAddresses.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public IDbSet<Customer> Customers { get; set; }

        public IDbSet<Address> Adresses { get; set; }
    }
}