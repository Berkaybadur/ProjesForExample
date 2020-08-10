using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TravelApp.ViewsModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreditCardPage : ContentPage
	{
		public CreditCardPage(AirRoutes airRoutes)
		{
			InitializeComponent();
			this.AirRoutes = airRoutes;
			this.BindingContext = this;
		}
		public AirRoutes AirRoutes { get; set; }


		async void paymentclick(System.Object sender, System.EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{
					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/airships");
					AirShips airShips = new AirShips();
					airShips.FlyDate = Convert.ToDateTime(flydate.Text);
					airShips.RouteFrom = routesfrom.Text;
					airShips.RouteTo = routesto.Text;
					airShips.CardNumber = cardnumber.Text;
					airShips.CardCvv = Cardcvv.Text;
					airShips.CardExpirationDate = Carddate.Text;
					airShips.Airport = Airport.Text;
					airShips.Price = Convert.ToInt32(price.Text);
					

					var results = await DisplayAlert("Ödeme", "Ödemeyi Onaylıyor musunuz ?", "Evet", "Hayır");
					if (results == true)
					{
						var result = Task.Run(() => HttpClient.PostAsJsonAsync<AirShips>("airships", airShips)).Result;
						var results2 = await DisplayAlert("Ödeme", "Ödemeniz Başarıyla Tamamlandı.", "Tamam", "Çıkış");
						Navigation.PushAsync(new AirportsPage());

					}
					else
					{
						var resultss = await DisplayAlert("Ödeme", "Ödeme Yaparken Bir Hata Oluştu.", "Ok", "Cancel");
						Navigation.PushAsync(new AirportsPage());
					}
				}

			}
			catch (Exception ex)
			{

			}
		}

	}
}