using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.Mobile.Core.MenuItems;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace GreenHouse.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainnPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList{get; set; }
        public MainnPage()
        {
            InitializeComponent();
            
            var menuList = new List<MasterPageItem>();
            
            var page1 = new MasterPageItem() { Title = "Friends", TargetType = typeof(FriendsPage) };
            var page2 = new MasterPageItem() { Title = "Reports",TargetType = typeof(ReportsPage) };
            var page3 = new MasterPageItem() { Title = "Schedule",TargetType = typeof(SchedulePage) };
            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(FriendsPage)));
            this.BindingContext = new
            {
                Header = "",
                Image = "https://www.belightsoft.com/products/imagetricks/img/core-image-filters@2x.jpg",
                //Footer = "         -------- Welcome To HotelPlaza --------           "
                Footer = "Welcome To Gay"
            };
        }
        
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}