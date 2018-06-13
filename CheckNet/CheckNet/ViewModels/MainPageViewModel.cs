using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckNet.MenuItem;
using I18NPortable;
using Xamarin.Forms;

namespace CheckNet.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private Command _changeLangCommand;
        Dclass MenuName = new Dclass();
        public Command ChangeLanguageCommand => _changeLangCommand ?? (_changeLangCommand = new Command(async () => await ChangeLanguage()));


        public Page CurrentPage { get; set; }

        private async Task ChangeLanguage()
        {
            try
            {
                var cancel = "Cancel".Translate();
                var result = await CurrentPage.DisplayActionSheet(Strings["ChooseLanguage"], cancel, null,
                    LanguagesToSelect.Select(l => l.DisplayName).ToArray());

                if (result == cancel)
                    return;

                var resultLocale = LanguagesToSelect.Single(l => l.DisplayName == result).Locale;

                var resultMenus = MenuToSelect.ToList();

                LoadLocale(resultLocale);

            }
            catch (Exception ex)
            { }
        }

        public List<MenuList> LoadLanguages()
        {
            List<MenuList> mylist = new List<MenuList>() {

            new MenuItem.MenuList() {

                MenuName = MenuName.Menu_ContactUs ,MenuId="1",Icon="Contactus.png",ArrowIcon="Arrow1.png",
            },
            new MenuItem.MenuList() {
                MenuName = MenuName.Menu_FAQ,MenuId="2",Icon="Faq.png",ArrowIcon="Arrow1.png",

            },
            new MenuItem.MenuList() {
                MenuName = MenuName.Menu_TermsConditions,MenuId="3",Icon="Termscondi.png",ArrowIcon="Arrow1.png",
            },
            new MenuItem.MenuList() {
                MenuName = MenuName.Menu_Policies,Icon="Policies.png",MenuId="4",ArrowIcon="Arrow1.png",
            },
            new MenuItem.MenuList() {
                MenuName = MenuName.Menu_Help,Icon="Help.png",MenuId="5",ArrowIcon="Arrow1.png",
            },
        };

            return mylist;
        }


    }
}
