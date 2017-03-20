using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using XDevDaysJau.InjecaoDependencia;
using XDevDaysJau.iOS.ImplementacaoInterfaces;

[assembly: Xamarin.Forms.Dependency(typeof(LigacaoTelefonicaiOS))]
namespace XDevDaysJau.iOS.ImplementacaoInterfaces
{
    public class LigacaoTelefonicaiOS : ILigacaoTelefonica
    {
        public bool Discar(string numero)
        {
            bool vRetorno = false;
            UIApplication.SharedApplication.InvokeOnMainThread(delegate
            {
                vRetorno = UIApplication.SharedApplication.OpenUrl(new NSUrl("tel:" + numero));
            });
            return vRetorno;

        }
    }
}
