using CheckNet.MenuItem;
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
	public partial class ContactUs : TabbedPage
    {
		public ContactUs ()
		{
			InitializeComponent ();
           


		}
        async void Write_Email(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new View.Email());
        }
        private void ListViewItem_Tabbed(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Products;
            var vm = BindingContext as MainViewModel;
            vm?.ShoworHiddenProducts(product);
        }
        
    }
}