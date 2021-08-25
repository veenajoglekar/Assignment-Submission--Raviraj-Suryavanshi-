using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionAssignment
{
    public class CollectionAssign
    {

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }

            public int Salary { get; set; }
        }
        public static void StackExample()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Neha",
                Gender = "Female"
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Nitin",
                Gender = "Male"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Suresh",
                Gender = "Male"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Meena",
                Gender = "Female"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Ram",
                Gender = "Male"
            };
            Stack<Customer> stackCustomer = new Stack<Customer>();
            stackCustomer.Push(customer1);
            stackCustomer.Push(customer2);
            stackCustomer.Push(customer3);
            stackCustomer.Push(customer4);
            stackCustomer.Push(customer5);

            //Customer c1 = stackCustomer.Pop();
            //Console.WriteLine(c1.ID + "-" + c1.Name);
            //Console.WriteLine("Items left in the stack =" + stackCustomer.Count);

            //Customer c2 = stackCustomer.Pop();
            //Console.WriteLine(c2.ID + "-" + c2.Name);
            //Console.WriteLine("Items left in the stack =" + stackCustomer.Count);

            //Customer c3 = stackCustomer.Pop();
            //Console.WriteLine(c3.ID + "-" + c3.Name);
            //Console.WriteLine("Items left in the stack =" + stackCustomer.Count);

            //Customer c4 = stackCustomer.Pop();
            //Console.WriteLine(c4.ID + "-" + c4.Name);
            //Console.WriteLine("Items left in the stack =" + stackCustomer.Count);

            //Customer c5 = stackCustomer.Pop();
            //Console.WriteLine(c5.ID + "-" + c5.Name);
            //Console.WriteLine("Items left in the stack =" + stackCustomer.Count);


            //peek() topmost element 
            Customer c1 = stackCustomer.Peek();
            Console.WriteLine(c1.ID + " - " + c1.Name); // ID: 105 Name:Ram
            Console.WriteLine("Items left in the stack =" + stackCustomer.Count);


            Console.WriteLine(stackCustomer.Contains(c1));
        }
        //Stack assignment end

        //Queue assignment begin
        public static void QueueExample()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Neha",
                Gender = "Female"
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Nitin",
                Gender = "Male"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Suresh",
                Gender = "Male"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Meena",
                Gender = "Female"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Ram",
                Gender = "Male"
            };

            Queue<Customer> queueCustomer = new Queue<Customer>();
            queueCustomer.Enqueue(customer1);
            queueCustomer.Enqueue(customer2);
            queueCustomer.Enqueue(customer3);
            queueCustomer.Enqueue(customer4);
            queueCustomer.Enqueue(customer5);

            //Customer c1 = queueCustomer.Dequeue();
            //Console.WriteLine(c1.ID + " - " + c1.Name);
            //Console.WriteLine("Total items in the queue = " + queueCustomer.Count);

            Customer c = queueCustomer.Peek();
            Console.WriteLine(c.ID + " - " + c.Name);
            Console.WriteLine("Total items in the queue = " + queueCustomer.Count);

            Customer c2 = queueCustomer.Peek();
            Console.WriteLine(c2.ID + " - " + c2.Name);
            Console.WriteLine("Total items in the queue = " + queueCustomer.Count);

        }

        //Queue assignment end

        //List assignment begin

        public static void ListEx()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Neha",
                Salary = 7000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Nitin",
                Salary = 9000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Suresh",
                Salary = 9000
            };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            //List grow in size automatically

            //retrieve specific item in the list
            Customer c = customers[0];
            Console.WriteLine("ID = {0}, Name={1}, Salary={2}", c.ID, c.Name, c.Salary);


            //Iterate through all the items
            foreach (Customer cs in customers)
            {
                Console.WriteLine("ID = {0}, Name={1}, Salary={2}", cs.ID, cs.Name, cs.Salary);

            }


            //using for loop
            //for (int i = 0;i < customers.Count; i++)
            //{
            //    Customer cs = customers[i];
            //    Console.WriteLine("ID = {0}, Name={1}, Salary={2}", cs.ID, cs.Name, cs.Salary);

            //}


            //insert at specific location
            customers.Insert(0, customer3);
            //when we insert this at 0th position, it will push rest of the objects further down
            foreach (Customer cs in customers)
            {
                Console.WriteLine(cs.ID);
            }


            //IndexOf()
            Console.WriteLine(customers.IndexOf(customer3)); //output:0

            //IndexOf(item,int index,count): 
            //second parameter i.e. position that you want to searching from
            //third parameter: no of items to look 
            //in this case from 1 to 3
            Console.WriteLine(customers.IndexOf(customer3, 1, 3)); //output:3
            Console.WriteLine(customers.IndexOf(customer3, 1, 2)); //output:-1


            //Contains():Checks if an item exists. Return true or false
            if (customers.Contains(customer3))
            {
                Console.WriteLine("customer3 object exists in the list");
            }
            else
            {
                Console.WriteLine("customer3 object does not exists in the list");
            }


            //exists(): checks an item exists in the list but based on given condition
            if (customers.Exists(cust => cust.Name.StartsWith("N")))
            {
                Console.WriteLine("start with N exists");
            }
            else
            {
                Console.WriteLine("start with N does not exists");
            }


            //find()
            //searches for an element that matches the condition and 
            //returns first matching item

            Customer cst = customers.Find(cust => cust.Salary > 8000);
            Console.WriteLine("ID = {0}, Name={1}, Salary={2}", cst.ID, cst.Name, cst.Salary);

            //FindLast()
            //searches for an element that matches the condition and 
            //returns last matching item
            Customer cust = customers.FindLast(cust => cust.Salary > 8000);
            Console.WriteLine("ID = {0}, Name={1}, Salary={2}", cust.ID, cust.Name, cust.Salary);

            //FindAll()
            //searches for an element that matches the condition and 
            //returns All  matching item
            List<Customer> cstm = customers.FindAll(cust => cust.Salary > 5000);
            foreach (Customer cs in cstm)
                Console.WriteLine("ID = {0}, Name={1}, Salary={2}", cs.ID, cs.Name, cs.Salary);

        }

        //List assignment end

        //Dictionary Assignmnet begin 

        public class Country
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public string Capital { get; set; }
        }

        public static void DictionaryEx()
        {
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRAILIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washtingon" };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);


            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ?
                                        dictionaryCountries[strCountryCode] : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name={0}, Capital={1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();

                } while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice == "YES");

        }

        //Dictionary Assignment End
    }

}
   

