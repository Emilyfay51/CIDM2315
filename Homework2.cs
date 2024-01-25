namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        string grade= Console.ReadLine();
        if(grade=="A"){
        Console.WriteLine("GPA Point: 4");
        }
         else if(grade=="B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if(grade=="C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if(grade=="D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if(grade=="F"){
            Console.WriteLine("GPA Point: 0");
        }
        else
            Console.WriteLine("Wrong Letter Grade!");

            Console.WriteLine("Please input in first num:");
            string number1=Console.ReadLine();
            int number1_int=Convert.ToInt16(number1);
            
             Console.WriteLine("Please input in second num:");
            string number2=Console.ReadLine();
            int number2_int=Convert.ToInt16(number2);

            Console.WriteLine("Please input in third num:");
            string number3=Console.ReadLine();
            int number3_int=Convert.ToInt16(number3);
            if(number1_int<=number2_int&&number1_int<=number3_int){
            Console.WriteLine("The smallest value is:" + number1_int);


            }
             Console.WriteLine("Please input a year:");
            string year=Console.ReadLine();
            int year_int=Convert.ToInt16(year);
           if(year_int%4==0&&year_int%100!=0){
            Console.WriteLine("This is a Leap Year.");
}
else
    Console.WriteLine("This is not a Leap Year.");
}
}





            

    


        
             
             



            


            

        
            
    

    


            
          
            

        
    

        




