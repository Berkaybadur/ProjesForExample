using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class ArticlesManager : IArticlesService
	{
		private IArticlesDal _articlesDal;
		public ArticlesManager(IArticlesDal articlesDal)
		{
			_articlesDal = articlesDal;
		}
		public void CreateArticles(Articles articles)
		{
			_articlesDal.Add(articles);
		}

		public List<Articles> GetAllArticles()
		{
			return _articlesDal.GetList();
		}

		public Articles GetByArticlesId(int id)
		{
			return _articlesDal.Get(a=>a.ArticlesId==id);
		}

		public void RemoveArticles(Articles articles)
		{
			_articlesDal.Delete(articles);
		}

		public void UpdateArticles(Articles articles)
		{
			_articlesDal.Update(articles);
		}
	}
}
