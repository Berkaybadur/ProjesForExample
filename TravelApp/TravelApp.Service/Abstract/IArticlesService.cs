using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IArticlesService
	{
		List<Articles> GetAllArticles();
		Articles GetByArticlesId(int id);
		void CreateArticles(Articles articles);
		void UpdateArticles(Articles articles);
		void RemoveArticles(Articles articles);
	}
}
