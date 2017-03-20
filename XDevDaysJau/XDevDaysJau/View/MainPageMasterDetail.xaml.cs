using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XDevDaysJau.View.Pages;
using XDevDaysJau.View.Pages.MasterPageDevDays;

namespace XDevDaysJau.View
{
    public partial class MainPageMasterDetail : MasterDetailPage    
    {
        public MainPageMasterDetail()
        {
            InitializeComponent();

            masterPage.ListView.ItemSelected += OnItemSelected;

            if (Device.OS == TargetPlatform.Windows)
            {
                Master.Icon = "swap.png";
            }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                if (item.TargetType == null)
                {
                    
                    App.Current.MainPage = new NavigationPage(new View.MainPage());
                }
                else
                {

                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    masterPage.ListView.SelectedItem = null;
                    IsPresented = false;
                }
            }
        }
    }
}
