using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CheckNet.MenuItem
{
    public class MainViewModel
    {
        private Products _oldProduct;
        public ObservableCollection<Products> Products { get; set; }
        public MainViewModel()
        {
            Products = new ObservableCollection<Products>
            {
                new Products
                {
                    Title="Checkpoint Systems Corporate Headquarters USA",
                    Id="1"
,                    Isvisible=false
                },
                new Products
                {
                    Title="Checkpoint Order Information/Order Status USA",
                    Id="2",
                    Isvisible =false
                },
                new Products
                {
                    Title="Credit and Collections Department",
                    Id="3",
                    Isvisible =false
                },
            };
        }





        internal void ShoworHiddenProducts(Products product)
        {
            if (_oldProduct == product)
            {
                product.Isvisible = !product.Isvisible;
                UpDateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.Isvisible = false;
                    UpDateProducts(_oldProduct);

                }
                product.Isvisible = true;
                UpDateProducts(product);
            }
            _oldProduct = product;
        }

        private void UpDateProducts(Products product)
        {
            var Index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(Index, product);
        }


    }
}
