using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XDevDaysJau.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagesXamarin : ContentPage
    {
        public PagesXamarin()
        {
            InitializeComponent();
        }

        private void btnCarousel_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.Pages.PaginaCarousel());
        }

        private void btnMasterDetail_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPageMasterDetail();
        }

        private void btnTabbed_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.Pages.PaginaTabbed()); 
        }
    }
}
