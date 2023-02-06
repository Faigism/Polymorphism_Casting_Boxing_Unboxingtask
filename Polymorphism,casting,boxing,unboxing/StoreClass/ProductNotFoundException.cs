using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClass
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string error) : base(error)
        {

        }
    }
}
