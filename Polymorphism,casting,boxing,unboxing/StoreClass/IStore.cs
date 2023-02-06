using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClass
{
    public interface IStore
    {
        Product[] Products { get; set; }
        void AddProduct(Product product);
        bool HasProductByNo(int no);
        Product GetProductByNo(int no);
        Product GetDrinkProducts(int no);
        Product GetDairyProduct(int no);
        Product RemoveProduct(int no);
    }
}
