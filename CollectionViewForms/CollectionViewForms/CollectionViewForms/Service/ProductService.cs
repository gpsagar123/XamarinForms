using CollectionViewForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewForms.Service
{
    public class ProductService
    {
        public List<Product> GetProductList()
        {
            return
                new List<Product>()
                {
                    new Product(){Name="Fan" , Price=1689, ImageUrl = "fan.png"},
                    new Product(){Name="Iron Box" , Price=899, ImageUrl = "ironbox.png"},
                    new Product(){Name="TV" , Price=17089, ImageUrl = "tv.png"},
                    new Product(){Name="USB" , Price=689, ImageUrl = "usb.png"},
                    new Product(){Name="Washing Machine" , Price=23891, ImageUrl = "washingmachine.png"}
                };
        }
    }
}
