using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClass
{
    public class Araz : IStore
    {
        private Product[] _products=new Product[0];
        public Product[] Products
        {
            get { return _products; }
            set { _products = value; }
        }
        private double _dairyProductCountLimit;
        public double DairyProductCountLimit
        {
            get { return _dairyProductCountLimit; }
            set { _dairyProductCountLimit = value;}
        }
        private double _alcoholPercentLimit;
        public double AlcoholPercentLimit
        {
            get { return _alcoholPercentLimit;}
            set { _alcoholPercentLimit = value;}
        }

        public void AddProduct(Product product)
        {
            byte count = 0;
            if(product is Dairy)
            {
                foreach (Product item in _products)
                {
                    count++;
                }
            }
            if (count <= _dairyProductCountLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
            else
            {
                throw new Exception();
            }
            if(product is Drink)
            {
                Drink dr = (Drink)product;
                if (dr.AlcoholPercent <= _alcoholPercentLimit)
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
            }
        }

        public Product GetDairyProduct(int no)
        {
            foreach (Product item in _products)
            {
                if (item is Dairy)
                    return item;
            }
            throw new Exception();
        }

        public Product GetDrinkProducts(int no)
        {
            foreach (Product item in _products)
            {
                if (item is Drink)
                    return item;
            }
            throw new Exception();
        }

        public Product GetProductByNo(int no)
        {
            foreach (Product item in _products)
            {
                if(item.No==no)
                    return item;
            }
            throw new Exception();
        }

        public bool HasProductByNo(int no)
        {
            foreach (Product item in _products)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }

        public Product RemoveProduct(int no)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == no)
                {
                    _products[i] = _products[_products.Length - 1];
                    Array.Resize(ref _products, _products.Length - 1);
                }
            }
            throw new Exception();
        }
    }
}
