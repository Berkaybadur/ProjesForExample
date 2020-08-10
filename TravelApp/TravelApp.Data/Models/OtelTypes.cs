using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class OtelTypes : IEntity
    {
        public OtelTypes()
        {
            Otels = new HashSet<Otels>();
        }

        public int TypesId { get; set; }
        public string TypesDescription { get; set; }

        public virtual ICollection<Otels> Otels { get; set; }
    }
}
