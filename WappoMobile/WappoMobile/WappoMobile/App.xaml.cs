using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WappoMobile.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WappoMobile
{
    public partial class App : Application
    {
        public static string Email { get; set; }
        public App()
        {
            InitializeComponent();

            //Registración de dependencias
            //Usuario
            DependencyAttribute usuarioDependecy = new DependencyAttribute(typeof(Contracts.IUsuarioService));
            usuarioDependecy.Match(typeof(Services.UsuarioService));
            //Pedidos
            DependencyAttribute pedidosDependecy = new DependencyAttribute(typeof(Contracts.IPedidosService));
            pedidosDependecy.Match(typeof(Services.PedidosService));
            //Postulación
            DependencyAttribute postulacionDependecy = new DependencyAttribute(typeof(Contracts.IPostulacionService));
            postulacionDependecy.Match(typeof(Services.PostulacionService));
            //MainPage = new MainPage();
            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new NavigationPage(new LoginPage()); //Para que inicie en la pantalla de Login
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
