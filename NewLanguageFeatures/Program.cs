using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;


namespace NewLanguageFeatures
{
    class Program
    {
        //static void VarTest()
        //{
        //    //var i = 43;
        //    //var s = "...This is only a test...";
        //    //var numbers = new  [] { 4, 9, 16 };
        //    //var complex = new SortedDictionary<string, List<DateTime>>();

        //    //var x; //no initialization
        //    //x = new int[] { 1, 2, 3 };
        //    //var x = { 1, 2, 3 }; // need to have new[]
        //    var x = new[] { 1, 2, 3 };
        //}


        static void Main1(string[] args)
        {
            //Customer c = new Customer(1) { Name = "Maria Anders", City = "Berlin"};
            //c.Name = "Maria Anders";
            //c.City = "Berlin";
            //c.CustomerID = 1;

            //Console.WriteLine(c);

            //List<Customer> customers = CreateCustomers();
            //var customers = CreateCustomers();
            //var addedCustomers = new List<Customer>
            //{
            //    new Customer(9)  { Name = "Paolo Accorti", City = "Torino" },
            //    new Customer(10) { Name = "Diego Roel", City = "Madrid" }
            //};

            //var updatedCustomers = customers.Append(addedCustomers);
            //Console.WriteLine("Customer:\n");
            //foreach (Customer c in customers)
            //foreach (var c in customers)
            //{
            //    Console.WriteLine(c);
            //}
            //var newCustomer = new Customer(10)
            //{
            //    Name = "Diego Roel",
            //    City = "Madrid"
            //};
            //foreach (var c in updatedCustomers)
            //{
            //    //if(Extensions.Compare(newCustomer, c)){
            //    if (newCustomer.Compare(c))
            //    {
            //        Console.WriteLine("The new customer was already in the list");
            //        return;
            //    }
            //}
            //Console.WriteLine("The new customer was not in the list");

            //foreach (var c in FindCustomerByCity(customers, "London"))
            //{
            //    Console.WriteLine(c);
            //}

            //var customerDictionary = new Dictionary<Customer, string>();

            //foreach (var c in customers)
            //{
            //    customerDictionary.Add(c, c.Name.Split(' ')[1]);
            //}
            //var matches = customerDictionary.FilterBy((customer, lastNmae) => lastNmae.StartsWith("A"));
            //Console.WriteLine("Number of Matches: {0}", matches.Count);



        }
       
        public static List<Customer> FindCustomerByCity(List<Customer> customers, string city)
        {
            //return customers.FindAll(delegate (Customer c) { return c.City == city; });
            //return customers.FindAll(c => c.City == city);
            return customers.FindAll((Customer c) => c.City == city);
        }

        static List<Customer> CreateCustomers()
        {
            return new List<Customer>
            {
                new Customer(1) { Name = "Maria Anders", City = "Berlin"},
                new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
                new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
                new Customer(4) { Name = "Ann Devon",        City = "London"    },
                new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
                new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
                new Customer(7) { Name = "Simon Crowther",   City = "London"    },
                new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
            };
        }
    }
}
