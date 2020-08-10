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

namespace TravelApp
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class Register : ContentPage
	{
		public Register()
		{
			InitializeComponent();
		}
		void LoginClick(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LoginPage());
		}
		 async void RegisterClick(System.Object sender, System.EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/customers");
					Customers customers = new Customers();
					customers.CustomerUserName = Kullaniciadi.Text;
					customers.CustomerPassword = Sifre.Text;
					customers.CustomerName = Ad.Text;
					customers.CustomerSurname = Soyadi.Text;
					customers.CustomerPhone = Telefon.Text;
					var result = Task.Run(() => HttpClient.PostAsJsonAsync<Customers>("customers", customers)).Result;

					if (result.IsSuccessStatusCode)
					{
						var results = await DisplayAlert("Başarılı", "Başarıyla Kayıt Olundu.", "Tamam", "Çıkış");
						if (results == true)
						{
							Navigation.PushAsync(new LoginPage());
						}
						else
						{
							var resultss = await DisplayAlert("Başarılı", "Kayıt Olunurken Hata Oluştu.", "Tamam", "Çıkış");
							Navigation.PushAsync(new Register());
						}
					}
				}
			}
			catch (Exception ex)
			{

			}
		}

	}
}
