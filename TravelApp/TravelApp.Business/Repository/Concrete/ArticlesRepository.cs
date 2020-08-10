using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class ArticlesRepository : IArticlesRepository
	{
		public Articles CreateArticles(Articles articles)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Articles.Add(articles);
				db.SaveChanges();
				return articles;
			}
		}

		public List<Articles> GetAllArticles()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Articles.ToList();
			}
		}

		public Articles GetByArticlesId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Articles.Find(id);
			}
		}

		public void RemoveArticles(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeArticles = GetByArticlesId(id);
				db.Articles.Remove(removeArticles);
				db.SaveChanges();
			}
		}

		public Articles UpdateArticles(Articles articles)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Articles.Update(articles);
				return articles;
			}
		}
	}
}
