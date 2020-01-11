using CollectionViewForms.Model;
using CollectionViewForms.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewForms.ViewModel
{
    public class ProductViewModel
    {
        List<Product> Products;

        public ProductViewModel()
        {
            Products = new ProductService().GetProductList();
        }
    }
}
