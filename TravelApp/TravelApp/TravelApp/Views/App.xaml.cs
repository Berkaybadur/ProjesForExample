using Plugin.SharedTransitions;
using System;
using TravelApp.ViewsModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("NunitoSans-Regular.ttf", Alias = "ThemeFontRegular")]
[assembly: ExportFont("NunitoSans-SemiBold.ttf", Alias = "ThemeFontMedium")]
[assembly: ExportFont("NunitoSans-Bold.ttf", Alias = "ThemeFontBold")]
namespace TravelApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SharedTransitionNavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
