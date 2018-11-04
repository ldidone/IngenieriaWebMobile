using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WappoMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostularsePage : ContentPage
	{
		public PostularsePage ()
		{
			InitializeComponent ();
            int precioMin = 20;
            int precioMax = 50;
            rangoPrecio.Text = "Precio min: $" + precioMin + "- Precio max: $" + precioMax;

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var tiempo = tiempoText.Text;
            var precio = precioText.Text;
        }
    }
}