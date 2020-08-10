using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TravelApp.ViewsModel;
using Xamarin.Forms;
using F = TravelApp.FirebaseStorageHelper;

namespace TravelApp
{
	[DesignTimeVisible(false)]
	public partial class CountriesPage : ContentPage
	{
		List<Countries> Countries = new List<Countries>();
		F.FirebaseStorageHelper fss = new F.FirebaseStorageHelper("travelappfirebase-af693.appspot.com");
		public CountriesPage()
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
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/countries/");
					Countries countries = new Countries();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<Countries>>(result);
					foreach (var item in list)
					{
						item.Image = Task.Run(() => fss.GetFile(item.Image)).Result;
					}
					AllCountriesList.ItemsSource = list;
				}
			}
			catch (Exception ex)
			{

			}


		}


		private async void PropertySelected(object sender, EventArgs e)
		{
			var countries = (sender as View).BindingContext as Countries;
			await this.Navigation.PushAsync(new GetByCountriesId(countries));
		}
		void OnImageNameTapped(System.Object sender, System.EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/countries/");
					Countries countries = new Countries();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<Countries>>(result);
					var results =list.Where(x => x.CountryName == countryname.Text).ToList();
					foreach (var item in results)
					{
						item.Image = Task.Run(() => fss.GetFile(item.Image)).Result;
					}
					AllCountriesList.ItemsSource = results;
				}
			}
			catch (Exception ex)
			{

			}

		}

		private void SelectType(object sender, EventArgs e)
		{
			var view = sender as View;
			var parent = view.Parent as StackLayout;

			foreach (var child in parent.Children)
			{
				VisualStateManager.GoToState(child, "Normal");
				ChangeTextColor(child, "#707070");
			}

			VisualStateManager.GoToState(view, "Selected");
			ChangeTextColor(view, "#FFFFFF");
		}

		private void ChangeTextColor(View child, string hexColor)
		{
			var txtCtrl = child.FindByName<Label>("PropertyTypeName");

			if (txtCtrl != null)
				txtCtrl.TextColor = Color.FromHex(hexColor);
		}

		private async void AllCountriesList_Refreshing(object sender, EventArgs e)
		{
			AllCountriesList.IsRefreshing = true;
			this.BindingContext = this;
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/countries/");
					Countries countries = new Countries();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<Countries>>(result);
					foreach (var item in list)
					{
						item.Image = Task.Run(() => fss.GetFile(item.Image)).Result;
					}
					AllCountriesList.ItemsSource = list;
				}
			}
			catch (Exception ex)
			{

			}


			await Task.Delay(10);

			AllCountriesList.IsRefreshing = false;
		}
		
	}

	public class PropertyTypes
	{
		public string TypeName { get; set; }
	}

	public class Propertyies
	{
		public string Id => Guid.NewGuid().ToString("N");
		public string PropertyName { get; set; }
		public string Image { get; set; }
		public string Address { get; set; }
		public string Location { get; set; }
		public string Price { get; set; }
		public string Bed { get; set; }
		public string Bath { get; set; }
		public string Space { get; set; }
		public string Details { get; set; }
	}
}
