using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IOtelTypesService
	{
		List<OtelTypes> GetAllOtelTypes();
		OtelTypes GetByOtelTypesId(int id);
		void CreateOtelTypes(OtelTypes otelTypes);
		void UpdateOtelTypes(OtelTypes otelTypes);
		void RemoveOtelTypes(OtelTypes otelTypes);
	}
}
