using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IOtelRoomsService
	{
		List<OtelRooms> GetAllOtelRooms();
		OtelRooms GetByOtelRoomsId(int id);
		void CreateOtelRooms(OtelRooms otelRooms);
		void UpdateOtelRooms(OtelRooms otelRooms);
		void RemoveOtelRooms(OtelRooms otelRooms);
	}
}
