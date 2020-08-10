using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class OtelTypesManager : IOtelTypesService
	{
		private IOtelTypesDal _otelTypesDal;
		public OtelTypesManager(IOtelTypesDal otelTypesDal)
		{
			_otelTypesDal = otelTypesDal;
		}
		public void CreateOtelTypes(OtelTypes otelTypes)
		{
			_otelTypesDal.Add(otelTypes);
		}

		public List<OtelTypes> GetAllOtelTypes()
		{
			return _otelTypesDal.GetList();
		}

		public OtelTypes GetByOtelTypesId(int id)
		{
			return _otelTypesDal.Get(a=>a.TypesId==id);
		}

		public void RemoveOtelTypes(OtelTypes otelTypes)
		{
			_otelTypesDal.Delete(otelTypes);
		}

		public void UpdateOtelTypes(OtelTypes otelTypes)
		{
			_otelTypesDal.Update(otelTypes);
		}
	}
}
