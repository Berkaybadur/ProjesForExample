using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class AirSeatTypeManager : IAirSeatTypeService
	{
		private IAirSeatTypeDal _airSeatTypeDal;
		public AirSeatTypeManager(IAirSeatTypeDal airSeatTypeDal)
		{
			_airSeatTypeDal = airSeatTypeDal;
		}
		public void CreateAirSeatTypes(AirSeatType airSeatType)
		{
			_airSeatTypeDal.Add(airSeatType);
		}

		public List<AirSeatType> GetAirSeatTypes()
		{
			return _airSeatTypeDal.GetList();
		}

		public AirSeatType GetByAirSeatTypesId(int id)
		{
			return _airSeatTypeDal.Get(a=>a.SeatTypeId==id);
		}

		public void RemoveAirSeatTypes(AirSeatType airSeatType)
		{
			_airSeatTypeDal.Delete(airSeatType);
		}

		public void UpdateAirSeatTypes(AirSeatType airSeatType)
		{
			_airSeatTypeDal.Update(airSeatType);
		}
	}
}
