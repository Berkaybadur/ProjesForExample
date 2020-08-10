using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IArticlesRepository
	{
		List<Articles> GetAllArticles();
		Articles GetByArticlesId(int id);
		Articles CreateArticles(Articles articles);
		Articles UpdateArticles(Articles articles);
		void RemoveArticles(int id);
	}
}
