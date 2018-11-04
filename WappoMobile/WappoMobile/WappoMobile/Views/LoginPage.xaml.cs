using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using WappoMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WappoMobile.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        private readonly IUsuarioService _usuarioService = DependencyService.Get<IUsuarioService>();

        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            App.Email = emailText.Text;
            string email = emailText.Text;
            string password = passwordText.Text;
            //bool loginExitoso = await _usuarioService.Login(email, password); //Inyección de dependencias: ERROR
            bool loginExitoso = await UsuarioService.ValidarLogin(email, password);
            if (loginExitoso)
            {
                mensajeError.IsVisible = false;
                await Navigation.PushAsync(new Views.MainPage()); //Redirigir a vista               
            }
            else
            {
                mensajeError.IsVisible = true;
            }
        }
    }
}