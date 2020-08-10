using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class Customers : IEntity
    {
        public Customers()
        {
            AirShipTickets = new HashSet<AirShipTickets>();
        }

        public int CustomerId { get; set; }
        public string CustomerUserName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }

        public virtual ICollection<AirShipTickets> AirShipTickets { get; set; }
    }
}
