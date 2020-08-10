using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IOtelsService
	{
		List<Otels> GetAllOtels();
		Otels GetByOtelsId(int id);
		void CreateOtels(Otels otels);
		void UpdateOtels(Otels otels);
		void RemoveOtels(Otels otels);
		List<Otels> GetAllInclude();
	}
}
