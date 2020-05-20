using System;
using APISample.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APICatFacts
{
    public partial class App : Application
    {
        public static CatFactsManager CatFactsManager { get; private set; }
        public App()
        {
            InitializeComponent();
            CatFactsManager = new CatFactsManager(new RestService());
            MainPage = new MainPage();
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
