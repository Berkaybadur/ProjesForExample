using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class AirShipTickets : IEntity
    {
        public int TicketId { get; set; }
        public int? ExpeditionId { get; set; }
        public int? CustomerNumb { get; set; }

        public virtual Customers CustomerNumbNavigation { get; set; }
        public virtual AirShipExpedition Expedition { get; set; }
    }
}
