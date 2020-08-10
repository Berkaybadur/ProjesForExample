using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.ViewsModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GetByCountriesId : ContentPage
	{
		public GetByCountriesId(Countries countries)
		{
			InitializeComponent();
			this.Countries = countries;
			this.BindingContext = this;
		}
		public Countries Countries { get; set; }
		private void GoBack(object sender, EventArgs e)
		{
			Navigation.PushAsync(new CountriesPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			DetailsView.TranslationY = 600;
			DetailsView.TranslateTo(0, 0, 500, Easing.SinInOut);
		}
	}

}