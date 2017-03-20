using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XDevDaysJau.InjecaoDependencia;

namespace XDevDaysJau.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicoDependencia : ContentPage
    {
        public ServicoDependencia()
        {
            InitializeComponent();
        }

        private void btnDiscar_Clicked(object sender, EventArgs e)
        {
            string apenasNumeros = Regex.Replace(entNumeroTelefone.Text, @"[^\d]", "");
            DependencyService.Get<ILigacaoTelefonica>().Discar(apenasNumeros);
        }
    }
}
