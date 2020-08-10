using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.ViewsModel
{
	public class AirSeatType
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

