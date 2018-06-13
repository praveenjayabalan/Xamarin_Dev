using I18NPortable;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using CheckNet.MenuItem;

namespace CheckNet.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public II18N Strings => I18N.Current;
        //Login List
        public string Login_RememberMe => "Login_RememberMe".Translate(Device.RuntimePlatform);
        public string Login_Username => "Login_Username".Translate(Device.RuntimePlatform);
        public string Login_Password => "Login_Password".Translate(Device.RuntimePlatform);
        public string Login_PasswordHint => "Login_PasswordHint".Translate(Device.RuntimePlatform);        
        public string Login_Login => "Login_Login".Translate(Device.RuntimePlatform);
        public string Login_Contentone => "Login_Contentone".Translate(Device.RuntimePlatform);
        public string Login_Contenttwo => "Login_Contenttwo".Translate(Device.RuntimePlatform);
        
        //Menu List
        public string Menu_ContactUs => "Menu_ContactUs".Translate(Device.RuntimePlatform);
        public string Menu_FAQ => "Menu_FAQ".Translate(Device.RuntimePlatform);
        public string Menu_TermsConditions => "Menu_TermsConditions".Translate(Device.RuntimePlatform);
        public string Menu_Policies => "Menu_Policies".Translate(Device.RuntimePlatform);
        public string Menu_Help => "Menu_Help".Translate(Device.RuntimePlatform);


        //Forgot List
        public string Forgot_Password => "Forgot_Password".Translate(Device.RuntimePlatform);
        public string Forgot_info => "Forgot_info".Translate(Device.RuntimePlatform);
        public string Forgot_Email => "Forgot_Email".Translate(Device.RuntimePlatform);
        public string Forgot_pass => "Forgot_pass".Translate(Device.RuntimePlatform);
        public string FAQ_Content => "FAQ_Content".Translate(Device.RuntimePlatform);

        public IEnumerable<PortableLanguage> LanguagesToSelect
            => I18N.Current.Languages
                .Where(x => x.Locale != I18N.Current.Locale);

        public IEnumerable<MenuList> MenuToSelect
          => LoadLanguages();

        public IEnumerable<MenuList> LoadLanguages()
        {
            List<MenuList> mylist = new List<MenuList>() {

            new MenuItem.MenuList() {

                MenuName =  Menu_ContactUs ,MenuId="1",Icon="Contactus.png",ArrowIcon="Arrow1.png",Text=Menu_ContactUs,
            },
            new MenuItem.MenuList() {
                MenuName = Menu_FAQ,MenuId="2",Icon="Faq.png",ArrowIcon="Arrow1.png",Text=Menu_FAQ,

            },
            new MenuItem.MenuList() {
                MenuName = Menu_TermsConditions,MenuId="3",Icon="Termscondi.png",ArrowIcon="Arrow1.png",Text=Menu_TermsConditions,
            },
            new MenuItem.MenuList() {
                MenuName = Menu_Policies,Icon="Policies.png",MenuId="4",ArrowIcon="Arrow1.png",Text=Menu_Policies,
            },
            new MenuItem.MenuList() {
                MenuName = Menu_Help,Icon="Help.png",MenuId="5",ArrowIcon="Arrow1.png",Text=Menu_Help,
            },
        };

            return mylist;
        }

        public void LoadLocale(string locale)
        {
            I18N.Current.Locale = locale;
            //Login List
            OnPropertyChanged(nameof(Login_RememberMe));
            OnPropertyChanged(nameof(Login_Username));
            OnPropertyChanged(nameof(Login_Password));
            OnPropertyChanged(nameof(Login_PasswordHint));
            OnPropertyChanged(nameof(Login_Login));
            OnPropertyChanged(nameof(Login_Contentone));
            OnPropertyChanged(nameof(Login_Contenttwo));

            //Menus List
            OnPropertyChanged(nameof(Menu_ContactUs));
            OnPropertyChanged(nameof(Menu_FAQ));
            OnPropertyChanged(nameof(Menu_TermsConditions));
            OnPropertyChanged(nameof(Menu_Policies));
            OnPropertyChanged(nameof(Menu_Help));

            //Forgot List
            OnPropertyChanged(nameof(Forgot_Password));
            OnPropertyChanged(nameof(Forgot_info));
            OnPropertyChanged(nameof(Menu_ContactUs));
            OnPropertyChanged(nameof(Forgot_pass));

            OnPropertyChanged(nameof(FAQ_Content));



        }
    }
    public class Dclass : BaseViewModel
    {
     
    }
}
