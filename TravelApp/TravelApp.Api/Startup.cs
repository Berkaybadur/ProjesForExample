using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.DataAccess.Concrete;
using TravelApp.Service.Abstract;
using TravelApp.Service.Concrete;

namespace TravelApp.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
			services.AddControllers();
			services.AddScoped<IAirportService, AirportManager>();
			services.AddScoped<IAirportsDal, EfAirportsDal>();
			services.AddScoped<IAirRoutesService, AirRoutesManager>();
			services.AddScoped<IAirRoutesDal, EfAirRoutesDal>();
			services.AddScoped<IAirSeatTypeService, AirSeatTypeManager>();
			services.AddScoped<IAirSeatTypeDal, EfAirSeatTypeDal>();
			services.AddScoped<IAirShipExpeditionService, AirShipExpeditionManager>();
			services.AddScoped<IAirShipExpeditionDal, EfAirShipExpeditionDal>();
			services.AddScoped<IAirShipsService, AirShipsManager>();
			services.AddScoped<IAirShipsDal, EfAirShipsDal>();
			services.AddScoped<IAirShipTicketsService, AirShipTicketsManager>();
			services.AddScoped<IAirShipTicketsDal, EfAirShipTickets>();
			services.AddScoped<IArticlesService, ArticlesManager>();
			services.AddScoped<IArticlesDal, EfArticlesDal>();
			services.AddScoped<ICountriesService, CountriesManager>();
			services.AddScoped<ICountriesDal, EfCountriesDal>();
			services.AddScoped<ICustomersService, CustomersManager>();
			services.AddScoped<ICustomersDal, EfCustomersDal>();
			services.AddScoped<IDistrictService, DistrictManager>();
			services.AddScoped<IDistrictDal, EfDistrictDal>();
			services.AddScoped<IOtelRoomsService, OtelRoomsManager>();
			services.AddScoped<IOtelRoomsDal, EfOtelRoomsDal>();
			services.AddScoped<IOtelsService, OtelsManager>();
			services.AddScoped<IOtelsDal, EfOtelsDal>();
			services.AddScoped<IOtelTypesService, OtelTypesManager>();
			services.AddScoped<IOtelTypesDal, EfOtelTpyesDal>();
			services.AddScoped<IProvincesService, ProvincesManager>();
			services.AddScoped<IProvincesDal, EfProvincesDal>();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "TravelApp Swagger");
			});
			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
