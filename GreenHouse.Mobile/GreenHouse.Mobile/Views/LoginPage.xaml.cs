using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenHouse.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        void SigninProcedure(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainnPage ();
        }

        void SignupProcedure(object sender, EventArgs e)
        {
            Navigation.PushAsync (new SignupPage ());
            //Application.Current.MainPage = new SignupPage ();
        }
    }
}