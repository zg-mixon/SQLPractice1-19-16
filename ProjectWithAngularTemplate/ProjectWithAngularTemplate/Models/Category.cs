using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWithAngularTemplate.Models
{
    public class Category : IActivatable, IDbEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Listing> Listing { get; set; }
        public bool Active { get; set; } = true;
    }
}