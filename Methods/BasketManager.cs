using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager 
    {
        //Naming convention
        public void Add (Product product)
        {
            Console.WriteLine(product.Name + " sepete eklendi.");
        }
        //encapsulation
        public void Add2(string productName,double productPrice,string productDetail,int StockAmount)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);  
        }
    }
}
