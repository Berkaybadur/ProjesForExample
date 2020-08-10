using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class AirShipExpeditionManager : IAirShipExpeditionService
	{
		private IAirShipExpeditionDal _airShipExpeditionDal;
		public AirShipExpeditionManager(IAirShipExpeditionDal airShipExpeditionDal)
		{
			_airShipExpeditionDal = airShipExpeditionDal;
		}
		public void CreateAirShipExpedition(AirShipExpedition airShipExpedition)
		{
			_airShipExpeditionDal.Add(airShipExpedition);
		}

		public List<AirShipExpedition> GetAllAirShipExpedition()
		{
			return _airShipExpeditionDal.GetList();
		}

		public AirShipExpedition GetByAirShipExpeditionId(int id)
		{
			return _airShipExpeditionDal.Get(a => a.ExpeditionId == id);
		}

		public void RemoveAirShipExpedition(AirShipExpedition airShipExpedition)
		{
			_airShipExpeditionDal.Delete(airShipExpedition);
		}

		public void UpdateAirShipExpedition(AirShipExpedition airShipExpedition)
		{
			_airShipExpeditionDal.Update(airShipExpedition);
		}
	}
}
