using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IAirportService
	{
		List<Airports> GetAllAirport();
		Airports GetByAirportId(int id);
		void CreateAirport(Airports airport);
		void UpdateAirport(Airports airport);
		void RemoveAirport(Airports airports);
		List<Airports> GetAllInclude();
	}
}
