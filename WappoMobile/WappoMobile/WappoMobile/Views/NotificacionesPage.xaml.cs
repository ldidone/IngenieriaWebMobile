using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WappoMobile.ViewModels;

namespace WappoMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificacionesPage : ContentPage
    {
        NotificacionesViewModel viewModel;
        
        public NotificacionesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new NotificacionesViewModel();
        }
  
        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Notificacion;
            if (item == null)
                return;

            await DisplayAlert("¡Postulación aceptada!", "¡Su postulación a " + item.DescripcionPedido + " ha sido aceptada!" , "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
