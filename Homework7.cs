namespace Homework7;
using System;

public class Program
    {
    static void Main(string[] args)
    {
        // Creating two customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        // Printing initial customer information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Updating customers' IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        // Printing updated customer information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Comparing ages and printing who is older
        customer1.CompareAge(customer2);
    }

    // Creating class Customer with private id, public name, and customer age
    public class Customer
    {
        private int cus_id;
        public string cus_name;
        public int cus_age;

        public Customer(int cus_id, string cus_name, int cus_age)
        {
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        public void ChangeID(int new_id)
        {
            cus_id = new_id;
        }

        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
        }

        // Comparing ages
        public void CompareAge(Customer objCustomer)
        {
            if (cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"{cus_name} is older");
            }
            else
            {
                Console.WriteLine($"{objCustomer.cus_name} is older");
            }
        }
    }
}
 
    









    
    

