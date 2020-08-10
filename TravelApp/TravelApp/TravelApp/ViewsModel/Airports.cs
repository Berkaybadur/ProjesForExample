using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.ViewsModel
{
	public class Airports
	{

		public int AirportId { get; set; }
		public string AirportName { get; set; }
		public int? DiscId { get; set; }
		public District Disc { get; set; }
	}
}
