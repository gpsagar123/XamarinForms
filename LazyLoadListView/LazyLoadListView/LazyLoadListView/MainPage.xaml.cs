using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LazyLoadListView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

            
        }

        private void sample_LV_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            (BindingContext as MainPageViewModel).LoadMoreItems(e.Item as MyData);
        }
    }
}
