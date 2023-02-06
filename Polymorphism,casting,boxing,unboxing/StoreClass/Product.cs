using System;

namespace StoreClass
{
    public class Product
    {
        public string Name;
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }
        public byte No;
        static byte count;
        public Product()
        {
            count++;
            No = count;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Adi: {Name} - Qiymeti: {Price} - No: {No}");
        }
    }
}
