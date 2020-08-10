using Newtonsoft.Json;
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
	public partial class GetByHotelid : ContentPage
	{
		public GetByHotelid(Otels otels)
		{
			InitializeComponent();
			this.Otels = otels;
			this.BindingContext = this;
		}
		public Otels Otels { get; set; }

		private void GoBack(object sender, EventArgs e)
		{
			this.Navigation.PopAsync();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			DetailsView.TranslationY = 600;
			DetailsView.TranslateTo(0, 0, 500, Easing.SinInOut);
		}
		async void RezerveClick(System.Object sender, System.EventArgs e)
		{
			try
			{
				HttpClientHandler handler = new HttpClientHandler();
				handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
				using (var HttpClient = new HttpClient(handler))
				{

					HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
					HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/otels/");

					var results = await DisplayAlert("Rezerve İşlemi", "Rezerve İşlemini Onaylıyor musunuz?", "Ok", "Cancel");
					if (results == true)
					{
						var update = Task.Run(() => HttpClient.GetAsync("Full/" + Otels.OtelId)).Result;
						var resultss = await DisplayAlert("Rezerve İşlemi Onayı", "Rezerve İşlemininiz Onaylandı", "Ok", "Cancel");
						if (resultss == true)
						{
							await Navigation.PushAsync(new HotelPage());
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