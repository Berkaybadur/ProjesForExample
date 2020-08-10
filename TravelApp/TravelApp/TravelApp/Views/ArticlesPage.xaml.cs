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
using Xamarin.Forms.Xaml;
using F = TravelApp.FirebaseStorageHelper;

namespace TravelApp
{
	[DesignTimeVisible(false)]
	public partial class ArticlesPage : ContentPage
	{

        List<Articles> Otels = new List<Articles>();
        F.FirebaseStorageHelper fs = new F.FirebaseStorageHelper("travelappfirebase-af693.appspot.com");
        public ArticlesPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            using (var HttpClient = new HttpClient(handler))
            {
                HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                HttpClient.BaseAddress = new Uri("https://192.168.1.8:44391/api/articles/");
                Articles otels = new Articles();
                var result = Task.Run(() => HttpClient.GetStringAsync("Get")).Result;
                var list = JsonConvert.DeserializeObject<List<Articles>>(result);
                foreach (var item in list)
                {
                    item.Image = Task.Run(() => fs.GetFile(item.Image)).Result;
                }
                AllArticlesList.ItemsSource = list;
            }
        }
  

        private async void PropertySelected(object sender, EventArgs e)
        {
            var article = (sender as View).BindingContext as Articles;
            await this.Navigation.PushAsync(new GetByArticlesId(article));
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
    }

  

    public class Propertys
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
        public string Title { get; set; }
    }
}
