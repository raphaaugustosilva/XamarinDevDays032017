using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XDevDaysJau.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAnimationAPI_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.AnimationAPI());
        }

        private void btnPages_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.PagesXamarin());
        }

        private void btnServicoDependencia_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.ServicoDependencia());
        }

        private void btnCustomizacaoPorPlataforma_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.CustomizacaoPorPlataforma());
        }

        private void btnDeclaracaoViewNativa_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.DeclaracaoViewNativa());
        }
    }
}
