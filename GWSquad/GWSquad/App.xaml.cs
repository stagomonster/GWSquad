using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GWSquad
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor=Color.Black}; //First Page is MainPage. Then, SquadEdit, then BuildSelect and back down again.
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
