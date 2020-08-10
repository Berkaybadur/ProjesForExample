using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class OtelsManager : IOtelsService
	{
		private IOtelsDal _otelsDal;
		public OtelsManager(IOtelsDal otelsDal)
		{
			_otelsDal = otelsDal;
		}
		public void CreateOtels(Otels otels)
		{
			_otelsDal.Add(otels);
		}

		public List<Otels> GetAllInclude()
		{
			return _otelsDal.GetIncludee(x => x.OtelDistrict, x => x.OtelType);
		}

		public List<Otels> GetAllOtels()
		{
			return _otelsDal.GetList();
		}

		public Otels GetByOtelsId(int id)
		{
			return _otelsDal.Get(a=>a.OtelId==id);
		}

		public void RemoveOtels(Otels otels)
		{
			_otelsDal.Delete(otels);
		}

		public void UpdateOtels(Otels otels)
		{
			_otelsDal.Update(otels);
		}
	}
}
