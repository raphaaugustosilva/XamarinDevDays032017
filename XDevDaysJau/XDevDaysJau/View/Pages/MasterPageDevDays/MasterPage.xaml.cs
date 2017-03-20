using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XDevDaysJau.View.Pages;

namespace XDevDaysJau.View.Pages.MasterPageDevDays
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Dev Days",
                IconSource = "iconbadge.png",
                TargetType = typeof(ContentPageDevDays)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Jaú",
                IconSource = "iconcamera.png",
                TargetType = typeof(ContentPageJau)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Monkey Nights",
                IconSource = "iconconstructionworker.png",
                TargetType = typeof(ContentPageMonkeyNights)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Sair",
                IconSource = "iconexit.png"                
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
