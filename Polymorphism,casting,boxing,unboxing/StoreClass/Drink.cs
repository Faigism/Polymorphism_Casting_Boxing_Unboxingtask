using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClass
{
    public class Drink:Product
    {
        private double _alcoholPercent;
        public double AlcoholPercent
        {
            get { return _alcoholPercent;}
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _alcoholPercent = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Adi: {Name} - Qiymeti: {Price} - No: {No} - Alkoqol faizi: {_alcoholPercent}");
        }
    }
}
