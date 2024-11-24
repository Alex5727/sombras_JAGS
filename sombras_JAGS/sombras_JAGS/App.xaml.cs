using sombras_JAGS.Services;
using sombras_JAGS.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sombras_JAGS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new sombra();
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
