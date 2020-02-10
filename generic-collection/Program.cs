using System;
using System.Collections.Generic;

namespace generic_collection {
    class Program {
        static void Main(string[] args) {

            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            var numberInList = ints.Count;
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach(var anInt in ints) {
                Console.Write($" {anInt} ");
                }
            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
                }
            var strings = new List<string>();
            strings.Add("Parker");
            strings.Add("Armon");
            strings.Add("Rob");
            strings.Add("Danae");
            strings.Add("Traci");
            strings.Add("Manish");
            strings.Add("Vaughn");
            strings.Add("Sarah");
            strings.Add("David");
            strings.Add("Ian");
            strings.Add("Laura");
            strings.Add("George");
            strings.Add("Greg");

            var nunberInList = strings.Count;
           foreach(var name in strings) {
           Console.WriteLine($"Names of the class {name}");
                }


            //generic array of strings

            var customers = new List<Customer>();
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            var meijer = new Customer() { Id = 3, Name = "Meijer", Active = true };
            var target = new Customer() { Id = 4, Name = "Target" };
            var microsoft = new Customer() { Id = 5, Name = "Microsoft", Active = false };

            customers.Add(amazon);
            customers.Add(pg);
            var custArray = new Customer[] { meijer, target, microsoft, };
            customers.AddRange(custArray);
            var custName = "Not Found";

            foreach (var customer in customers) {

                //if (customer.active == true)       
                // if (customer.Active == false) { continue; }
                if (customer.Id == 33) {
                    custName = customer.Name; break;

                };
                //  Console.WriteLine($"[{customer.Id},{customer.Name}, {customer.Active}] );;

                Console.WriteLine($" {custName} ");

                var custDictionary = new Dictionary<int, Customer>();
                custDictionary.Add(amazon.Id, amazon);
                custDictionary.Add(target.Id, target);
                custDictionary.Add(meijer.Id, meijer);
                custDictionary.Add(microsoft.Id, microsoft);
                custDictionary.Add(pg.Id, pg);

                var cust2 = custDictionary[3];

                var cust3 = custDictionary[2];



                // Console.WriteLine($"Customer id 3 is {cust2.Name}");
                //Console.WriteLine($"Customer id 2 is {cust3.Name}");
                Console.WriteLine($"Customer id 2 is {custDictionary[2].Name}"); // Alternate to the above syntax

                foreach (var key in custDictionary.Keys) {
                    var customer1 = custDictionary[key];
                    Console.WriteLine($"{customer1.Name}");
                
                }
            
                
              
            }

        }
        }
    }
