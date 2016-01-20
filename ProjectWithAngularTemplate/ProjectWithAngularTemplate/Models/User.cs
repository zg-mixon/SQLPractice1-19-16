using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectWithAngularTemplate.Models
{
    public class User : IDbEntity, IActivatable
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public IList<Listing> userListing { get; set; }

        public bool Active { get; set; } = true;
    }
}