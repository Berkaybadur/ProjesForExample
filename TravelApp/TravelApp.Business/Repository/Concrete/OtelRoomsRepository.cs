using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class OtelRoomsRepository : IOtelRoomsRepository
	{
		public OtelRooms CreateOtelRooms(OtelRooms otelRooms)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.OtelRooms.Add(otelRooms);
				db.SaveChanges();
				return otelRooms;
			}
		}

		public List<OtelRooms> GetAllOtelRooms()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.OtelRooms.ToList();
			}
		}

		public OtelRooms GetByOtelRoomsId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.OtelRooms.Find(id);
			}
		}

		public void RemoveOtelRooms(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeOtelRooms = GetByOtelRoomsId(id);
				db.OtelRooms.Remove(removeOtelRooms);
				db.SaveChanges();
			}
		}

		public OtelRooms UpdateOtelRooms(OtelRooms otelRooms)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.OtelRooms.Update(otelRooms);
				return otelRooms;
			}
		}
	}
}
