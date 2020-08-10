using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.ViewsModel
{
	public class OtelRooms
	{
        public int RoomId { get; set; }
        public decimal? RoomPrice { get; set; }
        public bool? RoomIsFull { get; set; }
        public int? OteId { get; set; }

        public virtual Otels Ote { get; set; }
    }
}

