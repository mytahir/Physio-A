using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Physio_A
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            MenuItems = GetMenus();
            this.BindingContext = this;

            MainContent.Children.Add(new Home());
        }

        public ObservableCollection<Menu> MenuItems { get; set; }


        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Title = "HOME", Icon = "homeicon.png" },
                new Menu { Title = "SERVICES", Icon = "services.png" },
                new Menu { Title = "SHOPPING", Icon = "shoppingcart.png" },
                new Menu { Title = "SEARCH", Icon = "search.png" },
                new Menu { Title = "ABOUT US", Icon = "about.png" },
                new Menu { Title = "SETTINGS", Icon = "settings.png" }
            };
        }

        private async void Show()
        {
            _ = TitleTxt.FadeTo(0);
            _ = MenuItemsView.FadeTo(1);
            await MainMenuView.RotateTo(0, 300, Easing.SinInOut);
        }

        private async void Hide()
        {
            _ = TitleTxt.FadeTo(1);
            _ = MenuItemsView.FadeTo(0);
            await MainMenuView.RotateTo(-90, 300, Easing.SinIn);
        }

        private void ShowMenu(object sender, EventArgs e)
        {
            Show();
        }

        private void MenuTapped(object sender, EventArgs e)
        {
            TitleTxt.Text = ((sender as StackLayout).BindingContext as Menu).Title;
            Hide();

            switch (TitleTxt.Text)
            {
                case "HOME":
                    MainContent.Children.Clear();
                    MainContent.Children.Add(new Home());
                    break;
                case "ABOUT US":
                    MainContent.Children.Clear();
                    MainContent.Children.Add(new About());
                    break;
                case "SERVICES":
                    MainContent.Children.Clear();
                    MainContent.Children.Add(new Services());
                    break;
                default:
                    MainContent.Children.Add(new Home());
                    break;
            }
        }

    }

    public class Menu
    {
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
