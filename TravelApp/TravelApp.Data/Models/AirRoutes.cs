using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class AirRoutes : IEntity
    {
        public int RoutesId { get; set; }
        public int? RoutesFromId { get; set; }
        public int? RoutesToId { get; set; }
        public DateTime? FlyDate { get; set; }
        public bool? IsFull { get; set; }
        public string Airport { get; set; }
        public int Price { get; set; }
        public string Airplane { get; set; }
        public int SeatCount { get; set; }

        public virtual District RoutesFrom { get; set; }
        public virtual District RoutesTo { get; set; }
    }
}
