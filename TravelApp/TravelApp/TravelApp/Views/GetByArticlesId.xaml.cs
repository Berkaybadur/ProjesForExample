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
	public partial class GetByArticlesId : ContentPage
	{
		public GetByArticlesId(Articles articles)
		{
			InitializeComponent();
			this.Articles = articles;
			this.BindingContext = this;
		}
		public Articles Articles { get; set; }
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
	}
}