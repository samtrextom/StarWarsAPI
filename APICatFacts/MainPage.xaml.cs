using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APISample;
using Xamarin.Forms;

namespace APICatFacts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.CatFactsManager.GetTasksAsync();
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CatFact catFact = (CatFact)e.SelectedItem;
            await DisplayAlert("Worthless Info", catFact.Name + ".", "OK");

        }
    }
}
