using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.Mobile.Core.Models;
using GreenHouse.Mobile.Infrastructure.graphql;
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
            BtnSignup.Clicked += async delegate { await SigninProcedure(); };
        }

        private async Task SigninProcedure()
        {
            var manager = new GraphQlClientManager();
            var response = await manager.SendMutationAsync<LoginResponse>("login", "login",
                GraphQlRequestFactory.CreateLoginMutation(Email.Text, Password.Text));
            if (response.Success)
                Application.Current.MainPage = new MainnPage();
            else
            {
                Email.Text = response.Error;
            }
        }

        void SignupProcedure()
        {
            Navigation.PushAsync(new SignupPage());
            var manager = new GraphQlClientManager();

            //Application.Current.MainPage = new SignupPage ();
        }
    }
}