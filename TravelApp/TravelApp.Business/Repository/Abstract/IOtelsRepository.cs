using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IOtelsRepository
	{
		List<Otels> GetAllOtels();
		Otels GetByOtelsId(int id);
		Otels CreateOtels(Otels otels);
		Otels UpdateOtels(Otels otels);
		void RemoveOtels(int id);
	}
}
