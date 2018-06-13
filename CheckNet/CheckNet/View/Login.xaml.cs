using CheckNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckNet.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {


        //private NavigationPage _mainlayout;
        public Login()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel
            {
                CurrentPage = this
            };
            var boxview = new Entry();
            boxview.SetBinding(BoxView.ColorProperty, new Binding(nameof(BackgroundColorProperty), source: this));



            //BindingContext = this;

            //PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;
        }
        //private void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

       
        private void ToolbarClicked(object sender, EventArgs e)
        {
            //DisplayAlert("Alert", "You have been alerted", "OK");
        }
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new View.ForgotPass());
        }
    }
}