using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class OtelRooms : IEntity
    {
        public int RoomId { get; set; }
        public decimal? RoomPrice { get; set; }
        public bool? RoomIsFull { get; set; }
        public int? OteId { get; set; }

        public virtual Otels Ote { get; set; }
    }
}
