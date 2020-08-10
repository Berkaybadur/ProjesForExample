using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class Airports : IEntity
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public int? DiscId { get; set; }

        public virtual District Disc { get; set; }
    }
}
