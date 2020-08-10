using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class OtelRoomsManager : IOtelRoomsService
	{
		private IOtelRoomsDal _otelRoomsDal;
		public OtelRoomsManager(IOtelRoomsDal otelRoomsDal)
		{
			_otelRoomsDal = otelRoomsDal;
		}
		public void CreateOtelRooms(OtelRooms otelRooms)
		{
			_otelRoomsDal.Add(otelRooms);
		}

		public List<OtelRooms> GetAllOtelRooms()
		{
			return _otelRoomsDal.GetList();
		}

		public OtelRooms GetByOtelRoomsId(int id)
		{
			return _otelRoomsDal.Get(a=>a.RoomId==id);
		}

		public void RemoveOtelRooms(OtelRooms otelRooms)
		{
			_otelRoomsDal.Delete(otelRooms);
		}

		public void UpdateOtelRooms(OtelRooms otelRooms)
		{
			_otelRoomsDal.Update(otelRooms);
		}
	}
}
