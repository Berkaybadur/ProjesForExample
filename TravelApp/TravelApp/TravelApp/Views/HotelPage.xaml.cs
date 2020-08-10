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
	public partial class HotelPage : ContentPage
	{
		List<Otels> Otels = new List<Otels>();
		F.FirebaseStorageHelper fs = new F.FirebaseStorageHelper("travelappfirebase-af693.appspot.com");
		public HotelPage()
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
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/otels/");
					Otels otels = new Otels();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var notlist= JsonConvert.DeserializeObject<List<Otels>>(result).Where(x=>x.IsFull==false);
					foreach (var item in notlist)
					{
						item.Image = Task.Run(() => fs.GetFile(item.Image)).Result;
					}
					AllHotelList.ItemsSource = notlist;
				}
			}
			catch (Exception ex)
			{

			}

		}
		

		private async void PropertySelected(object sender, EventArgs e)
		{
			var otels = (sender as View).BindingContext as Otels;
			await this.Navigation.PushAsync(new GetByHotelid(otels));
		}
		void OnImageNameTapped(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new HomePage());
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



		private async void AllHotelList_Refreshing(object sender, EventArgs e)
		{
			AllHotelList.IsRefreshing = true;
			this.BindingContext = this;
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/otels/");
					Otels otels = new Otels();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var notlist = JsonConvert.DeserializeObject<List<Otels>>(result).Where(x => x.IsFull == false);
					foreach (var item in notlist)
					{
						item.Image = Task.Run(() => fs.GetFile(item.Image)).Result;
					}
					AllHotelList.ItemsSource = notlist;
				}
			}
			catch (Exception ex)
			{

			}
			await Task.Delay(10);
			AllHotelList.IsRefreshing = false;
		}

		 void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/otels/");
					Otels otels = new Otels();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var notlist = JsonConvert.DeserializeObject<List<Otels>>(result);
					var forsearch = notlist.Where(x => x.OtelDistrict.DistrictName == search.Text||x.IsFull==false).ToList();
					foreach (var item in notlist)
					{
						item.Image = Task.Run(() => fs.GetFile(item.Image)).Result;
					}
					AllHotelList.ItemsSource = notlist;
				}
			}
			catch (Exception ex)
			{

			}

		}
	}

	public class PropertyType
	{
		public string TypeName { get; set; }
	}

	public class Property
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
