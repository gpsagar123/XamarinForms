using CollectionViewForms.Model;
using CollectionViewForms.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewForms.ViewModel
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ProductService().GetProductList();
            //Products.AddRange(Products);
            //Products.AddRange(Products);
        }
    }
}
