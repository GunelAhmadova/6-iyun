using System;
using System.Collections.Generic;
using System.Text;

namespace _6_iyun
{
    interface IStore
    { Product[] products { get; }
        int ProductLimited { get; set; }
        double TotalIncome { get; set; } 
        
        void AddProduct(Product product);
        void SellProduct(string No);

    }
}
