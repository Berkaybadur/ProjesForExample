using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelApp.Data.Models;
using TravelApp.Service.Abstract;
using TravelApp.Service.Concrete;

namespace TravelApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ArticlesController : ControllerBase
	{
		private IArticlesService _articlesService;
		public ArticlesController(IArticlesService articlesService)
		{
			_articlesService = articlesService;
		}
		[HttpGet("Get")]
		public List<Articles> Get()
		{
			return _articlesService.GetAllArticles();
		}
		[HttpGet("{id}")]
		public Articles GetById(int id)
		{
			return _articlesService.GetByArticlesId(id);
		}
		[HttpPost]
		public void Post([FromBody]Articles articles)
		{
			 _articlesService.CreateArticles(articles);
		}
		[HttpPut]
		public void Put([FromBody]Articles articles)
		{
			 _articlesService.UpdateArticles(articles);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var articles = _articlesService.GetByArticlesId(id);
			_articlesService.RemoveArticles(articles);
		}
	}
}