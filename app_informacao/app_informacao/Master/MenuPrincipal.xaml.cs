using app_informacao.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_informacao.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : MasterDetailPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void IrPaginaPerfil1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Perfil1());
            IsPresented = false;
        }
        private void IrPaginaSobre(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;
        }
    }
}