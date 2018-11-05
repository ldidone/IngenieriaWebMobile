using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using WappoMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WappoMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostularsePage : ContentPage
	{
        private readonly IPostulacionService _postulacionService = DependencyService.Get<IPostulacionService>();

        PostulacionViewModel postulacionViewModel;

        private readonly decimal _precioMinimo;
        private readonly decimal _precioMaximo;

        public PostularsePage (PostulacionViewModel viewModel)
		{
			InitializeComponent ();
            _precioMinimo = viewModel.PrecioMinimo;
            _precioMaximo = viewModel.PrecioMaximo;
            rangoPrecio.Text = "Precio min: $" + _precioMinimo + "- Precio max: $" + _precioMaximo;
            BindingContext = this.postulacionViewModel = viewModel;            
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            int tiempo = Convert.ToInt32(tiempoText.Text);
            decimal precio = Convert.ToDecimal(precioText.Text);
            string email = postulacionViewModel.EmailUsuario;
            int idPedido = postulacionViewModel.IdPedido;
            if (precio >= _precioMinimo && precio <= _precioMaximo)
            {
                Postulacion postulacion = new Postulacion()
                {
                    EmailUsuario = email,
                    IdPedido = idPedido,
                    Tiempo = tiempo,
                    Precio = precio
                };

                bool postulacionCorrecta = await _postulacionService.Postularse(postulacion);
                if (postulacionCorrecta)
                {
                    await Navigation.PushAsync(new Views.PostulacionCorrectaPage());
                    //await DisplayAlert("Postulación", "¡Postulación correcta!", "Aceptar");
                }
                else
                {
                    await Navigation.PushAsync(new Views.PostulacionIncorrectaPage());
                    //await DisplayAlert("Postulación", "Postulación incorrecta", "Aceptar");
                }
                //await Navigation.PushAsync(new Views.MainPage()); //Aparece doble la parte superior
            }
            else
            {
                await DisplayAlert("Precio", "El precio no se encuentra dentro del rango válido.", "Aceptar");
            }

        }
    }
}