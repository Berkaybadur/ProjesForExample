using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class Countries : IEntity
    {
        public Countries()
        {
            Provinces = new HashSet<Provinces>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryPopulation { get; set; }
        public string CountryDesc { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Provinces> Provinces { get; set; }
    }
}
