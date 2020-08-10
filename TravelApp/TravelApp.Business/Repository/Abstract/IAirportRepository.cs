using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IAirportRepository
	{
		List<Airports> GetAllAirport();
		Airports GetByAirportId(int id);
		Airports CreateAirport(Airports airport);
		Airports UpdateAirport(Airports airport);
		void RemoveAirport(int id);
		List<Airports> GetAllInclude();
	}
}
