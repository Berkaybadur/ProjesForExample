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
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void LoginClick(System.Object sender, System.EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/customers/");
					Customers airports = new Customers();
					var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
					var list = JsonConvert.DeserializeObject<List<Customers>>(result).Where(x => x.CustomerUserName == Kullaniciadi.Text && x.CustomerPassword == Password.Text).Count();
					if (list != 0)
					{
						Navigation.PushAsync(new HomePage());
					}
					else
					{
						var results = await DisplayAlert("Hata", "Kullanıcı Adı Veya Şifre Yanlış.", "Tamam", "Çıkış");
						if (results == true)
						{
							Navigation.PushAsync(new LoginPage());
						}
						else
						{
							return;
						}
					}
				}
			}
			catch (Exception ex)
			{

			}
		}
		void RegisterClick(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Register());
		}
	}
}
