using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        void OnImageNameTapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
        void HotelLayoutClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HotelPage());
        }
        void ArticlesClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ArticlesPage());
        }
        void TicketLayoutClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AirportsPage());
        }
        void WorldLayoutClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CountriesPage());
        }
    }
}
