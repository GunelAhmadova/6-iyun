using System;
using System.Collections.Generic;
using System.Text;

namespace _6_iyun
{
    class Market : IStore
    {
        private Product[] _products= new Product[0];
        private int _productLimited = 10;
        public Product[] products { get => _products; set => _products = value; }
        public int ProductLimited { get => _productLimited; set => _productLimited = value; }
        public double TotalIncome { get; set; }

        public void AddProduct(Product product1)

        {
            if (HasNo(product1) && ProductLimited > _products.Length)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product1;
            }    
        }

        public void SellProduct (string No)
        {
            for (int i = 0; i < _products.Length; i++)

            { 
                if (_products[i].No == No && _products[i].count>0)
                {
                    TotalIncome += _products[i].Price;
                    _products[i].count--; 
                }

            }
        }
        public bool HasNo(Product product1)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No ==product1.No)
                {
                    return false;
                }
            }
            return true;
           

        }
        public void ShowProduct()
        {
            foreach (var item in _products)
            {
                Console.WriteLine( $"{item.Name} {item.Price} {item.count} ");
            }
                           
        } 
    }


    

    

}

