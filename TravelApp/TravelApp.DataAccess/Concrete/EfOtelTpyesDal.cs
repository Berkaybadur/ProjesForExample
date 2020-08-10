using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.DataAccess.EntityFramework;

namespace TravelApp.DataAccess.Concrete
{
	public class EfOtelTpyesDal : EfEntityRepositoryBasecs<OtelTypes, TravelMobilContext>, IOtelTypesDal
	{
	}
}
