using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XDevDaysJau.InjecaoDependencia;
using Android.Telephony;
using XDevDaysJau.Droid.ImplementacaoInterfaces;

[assembly: Xamarin.Forms.Dependency(typeof(LigacaoTelefonicaAndroid))]
namespace XDevDaysJau.Droid.ImplementacaoInterfaces
{
    public class LigacaoTelefonicaAndroid : ILigacaoTelefonica
    {
        public bool Discar(string numero)
        {
            var context = Application.Context;
            if (context == null)
                return false;

            var intent = new Intent(Intent.ActionCall);
            intent.SetFlags(ActivityFlags.NewTask);
            intent.SetData(Android.Net.Uri.Parse("tel:" + numero));

            if (IsIntentAvailable(context, intent))
            {
                context.StartActivity(intent);
                return true;
            }

            return false;
        }

        public static bool IsIntentAvailable(Context context, Intent intent)
        {
            var packageManager = context.PackageManager;

            var list = packageManager.QueryIntentServices(intent, 0)
                .Union(packageManager.QueryIntentActivities(intent, 0));
            if (list.Any())
                return true;

            TelephonyManager mgr = TelephonyManager.FromContext(context);
            return mgr.PhoneType != PhoneType.None;
        }

    }
}