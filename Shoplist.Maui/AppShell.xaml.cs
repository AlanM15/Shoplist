using Shoplist.Maui.Views;

namespace Shoplist.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Registrar las rutas de las paginas de la aplicacion
            Routing.RegisterRoute(nameof(EditShopListItemPage), typeof(EditShopListItemPage));
        }
    }
}
