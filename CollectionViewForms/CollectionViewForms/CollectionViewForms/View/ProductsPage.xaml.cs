using CollectionViewForms.Model;
using CollectionViewForms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewForms.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
            productsCV.ItemsSource = new ProductViewModel().Products;


            productsCV.SelectionChanged += ProductsCV_SelectionChanged;
        }

        private void ProductsCV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var products = e.CurrentSelection;
            string msg = string.Empty;
            msg = "Selected Product \n";

            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i] as Product;
                msg += $"{product.Name} ({product.Price})\n" ;
            }

            DisplayAlert("Demo", msg, "Ok");

        }
    }
}