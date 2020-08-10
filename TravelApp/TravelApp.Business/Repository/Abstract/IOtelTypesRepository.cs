using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IOtelTypesRepository
	{
		List<OtelTypes> GetAllOtelTypes();
		OtelTypes GetByOtelTypesId(int id);
		OtelTypes CreateOtelTypes(OtelTypes otelTypes);
		OtelTypes UpdateOtelTypes(OtelTypes otelTypes);
		void RemoveOtelTypes(int id);
	}
}
