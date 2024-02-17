namespace Homework5;

    using System;

class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Input Four numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());

        int largest = GetLargest(num1, num2, num3, num4);

        Console.WriteLine($"a={num1}, b={num2}, c={num3}, d={num4}");
        Console.WriteLine("The largest number is: " + largest);

        CreateAccount();
    }

    static int GetLargest(int num1, int num2, int num3, int num4)
    {
        int max1 = num1 > num2 ? num1 : num2;
        int max2 = num3 > num4 ? num3 : num4;

        return max1 > max2 ? max1 : max2;
    }

    static void CreateAccount()
    {
        Console.WriteLine("Enter your Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter your password again:");
        string password2 = Console.ReadLine();

        if (password1 != password2)
        {
            Console.WriteLine("Wrong password");
            return; 
        }

        Console.WriteLine("Enter your Birth Year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (!CheckAge(birthYear))
        {
            Console.WriteLine("Could not create an account");
            return; 
        }

        Console.WriteLine("Account is created successfully.");
    }

    static bool CheckAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age >= 18;
    }
} 

    






        
        
    
        

        


        
       
    






   

    

