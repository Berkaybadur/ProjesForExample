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
	public class OtelsController : ControllerBase
	{
		private IOtelsService _otelsService;
		public OtelsController(IOtelsService otelsService)
		{
			_otelsService = otelsService;
		}
		//	[HttpGet]
		//	public List<Otels> Get()
		//	{
		//		return _otelsService.GetAllOtels();
		//}
		[HttpGet("Get")]
		public List<Otels> Get()
		{
			return _otelsService.GetAllInclude();
		}
		[HttpGet("Getid")]
		public Otels GetById(int id)
		{
			return _otelsService.GetByOtelsId(id);
		}
		[HttpPost]
		public void Post([FromBody]Otels otels)
		{
			_otelsService.CreateOtels(otels);
		}

		[HttpPut]
		public void Put([FromBody]Otels otels)
		{
			_otelsService.UpdateOtels(otels);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var otel = _otelsService.GetByOtelsId(id);
			_otelsService.RemoveOtels(otel);
		}
		//Kolon adı neydi ? IsFull 1 sn 
		//silmedin mi ? yok silme böyle olması lazım da neden gelmiyor Column Çekilmesi saçma olum ya Şey olabilir mi aynısını yapıyoruz amk
		[HttpGet]
		[Route("Full/{id:int}")]
		public void Full(int id)
		{
			//geldi şu sessionu da yapayım bıktım amk 
			//büüyk harf türkçe karkatero lmaıdıg için problem yaşanıyor olablir
			var otels = _otelsService.GetByOtelsId(id);
			otels.IsFull = true;
			_otelsService.UpdateOtels(otels);
		}

	}
}