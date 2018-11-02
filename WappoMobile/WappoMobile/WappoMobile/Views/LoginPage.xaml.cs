﻿using System;
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
            //bool loginExitoso = _usuarioService.Login(email, password);
            bool loginExitoso = WappoMobile.Services.UsuarioService.ValidarLogin(email, password);
            if (loginExitoso)
            {
                await Navigation.PushAsync(new Views.MainPage()); //Redirigir a vista               
            }
        }
    }
}