using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSkins.Models
{
    public class Skin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gun { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public Skin()
        {

        }
        public Skin(int id, string name, string gun, string description, string imageUrl)
        {
            Id = id;
            Name = name;
            Gun = gun;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}