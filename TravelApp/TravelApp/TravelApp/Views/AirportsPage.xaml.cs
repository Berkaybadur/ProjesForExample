using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using TravelApp.ViewsModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AirportsPage : ContentPage
	{
		public AirportsPage()
		{
			InitializeComponent();
			this.BindingContext = this;
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/airroute/");
					AirRoutes airRoutes = new AirRoutes();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<AirRoutes>>(result).Where(x => x.IsFull == false);
					AirportsList.ItemsSource = list;
				}
			}
			catch (Exception ex)
			{

			}


		}
		private async void PropertySelected(object sender, EventArgs e)
		{
			var airroute = (sender as View).BindingContext as AirRoutes;
			await this.Navigation.PushAsync(new CreditCardPage(airroute));
		}


		private void SearchClick(System.Object sender, System.EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/airroute/");
					AirRoutes airRoutes = new AirRoutes();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<AirRoutes>>(result);
					var _result = list.Where(x => x.RoutesTo.DistrictName == Nereye.Text && x.RoutesFrom.DistrictName == Nereden.Text).ToList();
					AirportsList.ItemsSource = _result;

				}
			}
			catch (Exception ex)
			{

			}

		}

		private async void AirportsList_Refreshing(object sender, EventArgs e)
		{
			AirportsList.IsRefreshing = true;
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/airroute/");
					AirRoutes airRoutes = new AirRoutes();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<AirRoutes>>(result).Where(x => x.IsFull == false);
					AirportsList.ItemsSource = list;
				}
			}
			catch (Exception ex)
			{

			}
			await Task.Delay(20);
			AirportsList.IsRefreshing = false;
		}
		void OnImageNameTapped(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new HomePage());
		}
	}
}