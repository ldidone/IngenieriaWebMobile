using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace WappoMobile.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            MapView.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(-31.2526564, -61.4938347), Distance.FromMiles(0.4)));
            Title = "Pedidos asignados";
        }

        private void Street_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Street;
        }


        private void Hybrid_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Hybrid;
        }

        private void Satellite_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Satellite;
        }
    }
}