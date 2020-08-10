using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.ViewsModel
{
	public class District
	{
        public District()
        {
            AirRoutesRoutesFrom = new HashSet<AirRoutes>();
            AirRoutesRoutesTo = new HashSet<AirRoutes>();
            Airports = new HashSet<Airports>();
            Otels = new HashSet<Otels>();
        }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int? ProvId { get; set; }

        public virtual Provinces Prov { get; set; }
        public virtual ICollection<AirRoutes> AirRoutesRoutesFrom { get; set; }
        public virtual ICollection<AirRoutes> AirRoutesRoutesTo { get; set; }
        public virtual ICollection<Airports> Airports { get; set; }
        public virtual ICollection<Otels> Otels { get; set; }
    }
}

