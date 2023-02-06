using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClass
{
    public class Dairy:Product
    {
        private double _fatPercent;
        public double FatPercent
        {
            get { return _fatPercent; }
            set { _fatPercent = value; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Adi: {Name} - Qiymeti: {Price} - No: {No} - Yagliliq derecesi: {_fatPercent}");
        }
    }
}
