using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.ViewsModel
{
	public class Otels
	{
        public Otels()
        {
            OtelRooms = new HashSet<OtelRooms>();
        }
        public int OtelId { get; set; }
        public string OtelName { get; set; }
        public string OtelAddress { get; set; }
        public int? OtelTypeId { get; set; }
        public int? OtelDistrictId { get; set; }
        public string Rooms { get; set; }
        public int Price { get; set; }
        public bool? IsFull { get; set; }
        public string Image { get; set; }

        public virtual District OtelDistrict { get; set; }
        public virtual OtelTypes OtelType { get; set; }
        public virtual ICollection<OtelRooms> OtelRooms { get; set; }
    }
}
