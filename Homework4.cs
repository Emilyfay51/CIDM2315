namespace Homework4;

class Program
{


  static void Main(string[] args)
    {
        
Console.WriteLine("Input First number");
int num1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input second number");
int num2=Convert.ToInt16(Console.ReadLine());
int largest=Getlargest(num1,num2);
Console.WriteLine($"a={num1}, b={num2}");
Console.WriteLine("The largest number is: " + largest);
static int Getlargest(int num1, int num2)
{
  return(num1>num2)?num1:num2;
}

 int n;
        string shape = "left"; 
        Console.WriteLine("Input a Number:");
        n = Convert.ToInt32(Console.ReadLine());
       

       
    

     Console.WriteLine($"N = {n}, Shape is {shape}");

    
        

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");}
    }}
        
    




    
        
        
        

        
    


    
    
       
        
           
    
          
     
    


    

