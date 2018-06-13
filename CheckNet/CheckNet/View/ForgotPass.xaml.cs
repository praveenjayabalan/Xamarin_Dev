using CheckNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckNet.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPass : ContentPage
	{
		public ForgotPass ()
		{
			InitializeComponent ();
            BindingContext = new MainPageViewModel
            {
                CurrentPage = this
            };
        }
        async void Cancel_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }
    }
}