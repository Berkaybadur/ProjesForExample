using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class AirSeatType : IEntity
    {
        public AirSeatType()
        {
            AirShipExpedition = new HashSet<AirShipExpedition>();
        }

        public int SeatTypeId { get; set; }
        public string SeatTypeName { get; set; }

        public virtual ICollection<AirShipExpedition> AirShipExpedition { get; set; }
    }
}
