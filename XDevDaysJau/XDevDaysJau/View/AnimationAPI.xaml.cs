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
    public partial class AnimationAPI : ContentPage
    {
        private double rotateLabelValue = -360;
        public AnimationAPI()
        {
            InitializeComponent();
        }

        private async void btnAnimar_Clicked(object sender, EventArgs e)
        {
            btnAnimar.IsEnabled = false;
            rotateLabelValue = -rotateLabelValue;
            await lblLabelGirar.RotateTo(rotateLabelValue, 2000);

            double widthBackground = stkBackground.Width - (stkMovimentar01.WidthRequest + stkBackground.Padding.Left + stkBackground.Padding.Right);
            await stkMovimentar01.TranslateTo(widthBackground, 0, 2000);

            
            await Task.WhenAll(
              stkMovimentar02.RotateTo(400 * 360, 3000),
              stkMovimentar02.TranslateTo(-widthBackground, 0, 3000)              
            );

            await Task.Delay(1000);

            await Task.WhenAll(
                stkMovimentar01.TranslateTo(0, 0, 2000),
                
                stkMovimentar02.RotateTo(-360, 2000),
                stkMovimentar02.TranslateTo(0, 0, 2000)
            );

            btnAnimar.IsEnabled = true;

        }
    }
}
