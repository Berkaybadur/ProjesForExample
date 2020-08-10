using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IOtelRoomsRepository
	{
		List<OtelRooms> GetAllOtelRooms();
		OtelRooms GetByOtelRoomsId(int id);
		OtelRooms CreateOtelRooms(OtelRooms otelRooms);
		OtelRooms UpdateOtelRooms(OtelRooms otelRooms);
		void RemoveOtelRooms(int id);
	}
}
