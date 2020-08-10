using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class OtelTypesRepository : IOtelTypesRepository
	{
		public OtelTypes CreateOtelTypes(OtelTypes otelTypes)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.OtelTypes.Add(otelTypes);
				db.SaveChanges();
				return otelTypes;
			}
		}

		public List<OtelTypes> GetAllOtelTypes()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.OtelTypes.ToList();
			}
		}

		public OtelTypes GetByOtelTypesId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.OtelTypes.Find(id);
			}
		}

		public void RemoveOtelTypes(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeOtelTypes = GetByOtelTypesId(id);
				db.OtelTypes.Remove(removeOtelTypes);
				db.SaveChanges();
			}
		}

		public OtelTypes UpdateOtelTypes(OtelTypes otelTypes)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.OtelTypes.Update(otelTypes);
				return otelTypes;
			}
		}
	}
}
