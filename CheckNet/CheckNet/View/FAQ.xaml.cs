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
	public partial class FAQ : ContentPage
	{
		public FAQ ()
		{
            MenuList faq = new MenuList();
            faq.FAQ_Content = "This Following list contains a serios of frequently Asked Questions(FAQ)and their repective answers.the list is provided as the first source of information for users when there is an operational question regarding login procedure or the credit application process.Users should refer to this list first and prior to containing their Checkpoint systems Customer Service Respresentative.(CSR)";
            BindingContext = faq;
            InitializeComponent ();
            
		}

        private void ListViewItem_Tabbed(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Products;
            var vm = BindingContext as MainViewModel;
            vm?.ShoworHiddenProducts(product);
            //if (product.Id == "1") { 
            //    Products prop = new Products();
            //    prop.FAQ_Content = "sandy";
            //        }
            //else if(product.Id == "2")
            //{
            //    Products prop = new Products();
            //    prop.FAQ_Content = "sandy2";
            //}
            //else if (product.Id == "3")
            //{
            //    Products prop = new Products();
            //    prop.FAQ_Content = "sandy3";
            //}
        }
    }
}