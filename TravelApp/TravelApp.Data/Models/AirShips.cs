using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class AirShips:IEntity
    {
        public AirShips()
        {
            AirShipExpedition = new HashSet<AirShipExpedition>();
        }

        public int AirShipsId { get; set; }
        public DateTime? FlyDate { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string CardNumber { get; set; }
        public string CardCvv { get; set; }
        public string CardExpirationDate { get; set; }
        public string Airport { get; set; }
        public int Price { get; set; }

        public virtual ICollection<AirShipExpedition> AirShipExpedition { get; set; }
    }
}
