using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace NewLanguageFeatures
{
    class StoreManagement
    {
        static void Main(string[] args)
        {
            Query();
        }
        static List<Store> CreateStore()
        {
            return new List<Store>
              {
                new Store { Name = "Jim’s Hardware",    City = "Berlin" },
                new Store { Name = "John’s Books",  City = "London" },
                new Store { Name = "Lisa’s Flowers",    City = "Torino" },
                new Store { Name = "Dana’s Hardware",   City = "London" },
                new Store { Name = "Tim’s Pets",    City = "Portland" },
                new Store { Name = "Scott’s Books",     City = "London" },
                new Store { Name = "Paula’s Cafe",  City = "Marseille" },
              };
        }

        static void Query()
        {
            //var stores = CreateStore();
            //foreach (var store in stores.Where(s=>s.City == "London"))
            //{
            //    Console.WriteLine(store);
            //}
            //IEnumerable<Store> results = from s in stores
            //                             where s.City == "London"
            //                             select s;
            //foreach (var s in results)
            //{
            //    Console.WriteLine(s);
            //}
            //var numLondon = stores.Count(s => s.City == "London");
            //Console.WriteLine("There are {0} stores in London. ", numLondon);

            //foreach (var c in CreateCustomers())
            //{
            //    var customerStores = new
            //    {
            //        //CustomerID = c.CustomerID,
            //        //City = c.City,
            //        c.CustomerID,                   //statement to see the type
            //        c.City,
            //        CustomerName = c.Name,
            //        Stores = from s in CreateStore()
            //                 where s.City == c.City
            //                 select s
            //    };
            //    Console.WriteLine("{0}\t{1}", customerStores.City, customerStores.CustomerName);

            //    foreach (var store in customerStores.Stores)
            //    {
            //        Console.WriteLine("\t<{0}>", store.Name);
            //    }

            //}

            //var results = from c in CreateCustomers()
            //              select new
            //              {
            //                  c.CustomerID,
            //                  c.City,
            //                  CustomerName = c.Name,
            //                  Stores = CreateStore().Where(s => s.City == c.City)
            //              };
            //foreach (var result in results)
            //{
            //    Console.WriteLine("{0}\t{1}", result.City, result.CustomerName);
            //    foreach (var store in result.Stores)
            //        Console.WriteLine("\t<{0}>", store.Name);

            //}

            //var results = from c in CreateCustomers()
            //              join s in CreateStore() on c.City equals s.City
            //              select new
            //              {
            //                  CustomerName = c.Name,
            //                  StoreName = s.Name,
            //                  c.City
            //              };

            //foreach (var r in results)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}", r.City, r.CustomerName, r.StoreName);
            //}

            var results = from c in CreateCustomers()
                          join s in CreateStore() on c.City equals s.City
                          group s by c.Name into g
                          let count = g.Count()
                          orderby count ascending
                          select new { CustomerName = g.Key, Count = g.Count() };
            foreach (var r in results) 
                Console.WriteLine("{0}\t{1}", r.CustomerName, r.Count);


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
