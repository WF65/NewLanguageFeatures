using System;
using System.Collections.Generic;
using System.Text;

namespace NewLanguageFeatures
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int CustomerID { get; private set; }

        public Customer(int ID)
        {
            CustomerID = ID;
        }
        public override string ToString()
        {
            return Name + "\t" + City +"\t" + CustomerID;
        }
    }
}
