using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class Provinces : IEntity
    {
        public Provinces()
        {
            District = new HashSet<District>();
        }

        public int ProvinceId { get; set; }
        public string ProvName { get; set; }
        public int? ContId { get; set; }

        public virtual Countries Cont { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
