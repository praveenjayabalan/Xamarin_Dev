using CheckNet.MenuItem;
using CheckNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace CheckNet
{
    public partial class MainPage : MasterDetailPage
    {

        //private NavigationPage _mainlayout;
        MainPageViewModel MpV = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();

            //string menulist = Menu.Menu_ContactUs;
            //BindingContext = new MainPageViewModel
            //{
            //    CurrentPage = this
            //};

            lst.ItemsSource = MpV.LoadLanguages();
            lst.SeparatorColor = Color.Black;
            Application.Current.MainPage = new NavigationPage(new View.Login());

            Detail = new NavigationPage(new View.Login())
            {
                BarBackgroundColor = Color.FromHex("#f2f2f2"),
                BarTextColor = Color.FromHex("#ffffff"),


            };
            IsPresented = false;


        }

        //public List<MenuList> LoadLanguages()
        //{
        //    List<MenuList> mylist = new List<MenuList>() {

        //    new MenuItem.MenuList() {

        //        MenuName = MenuName.Menu_ContactUs ,MenuId="1",Icon="Contactus.png",ArrowIcon="Arrow1.png",
        //    },
        //    new MenuItem.MenuList() {
        //        MenuName = MenuName.Menu_FAQ,MenuId="2",Icon="Faq.png",ArrowIcon="Arrow1.png",

        //    },
        //    new MenuItem.MenuList() {
        //        MenuName = MenuName.Menu_TermsConditions,MenuId="3",Icon="Termscondi.png",ArrowIcon="Arrow1.png",
        //    },
        //    new MenuItem.MenuList() {
        //        MenuName = MenuName.Menu_Policies,Icon="Policies.png",MenuId="4",ArrowIcon="Arrow1.png",
        //    },
        //    new MenuItem.MenuList() {
        //        MenuName = MenuName.Menu_Help,Icon="Help.png",MenuId="5",ArrowIcon="Arrow1.png",
        //    },
        //};
        //    lst.SeparatorColor = Color.Black;
        //    return mylist;
        //}

        private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {


            var Selected = e.Item as MenuList;

            switch (Selected.MenuId)
            {

                case "1":
                    Detail = new NavigationPage(new View.ContactUs())
                    {
                        BarBackgroundColor = Color.FromHex("#ed103c"),
                        BarTextColor = Color.White,

                    };
                    
                    IsPresented = false;
                    break;
                case "2":
                    Detail = new NavigationPage(new View.FAQ())
                    {
                        BarBackgroundColor = Color.FromHex("#ed103c"),
                        BarTextColor = Color.White,
                    };
                    IsPresented = false;

                    break;
                case "3":

                    Detail = new NavigationPage(new View.Terms_And_Condition())
                    {
                        BarBackgroundColor = Color.FromHex("#ed103c"),
                        BarTextColor = Color.White,
                    };
                    IsPresented = false;
                    break;
                case "4":


                    Detail = new NavigationPage(new View.Policies())
                    {
                        BarBackgroundColor = Color.FromHex("#ed103c"),
                        BarTextColor = Color.White,
                    };
                    IsPresented = false;
                    break;
                case "5":

                    Detail = new NavigationPage(new View.Help())
                    {
                        BarBackgroundColor = Color.FromHex("#ed103c"),
                        BarTextColor = Color.White,
                    };
                    IsPresented = false;
                    break;
            }

           ((ListView)sender).SelectedItem = "";
        }



        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new View.Login())
            {
                BarBackgroundColor = Color.FromHex("#f2f2f2"),
                BarTextColor = Color.FromHex("#ffffff"),
            };


            IsPresented = false;
        }



    }
}
