namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
    
          
int n;



Console.WriteLine("Input an Integer:");
n= Convert.ToInt32(Console.ReadLine());
if (n == 0 || n == 1)
{
    Console.WriteLine("N is non-prime");
    
    
}
else
{
    for (int i= 2; i <= n / 2; i++)
    {
        if (n%i == 0)
        
        {
            Console.WriteLine(" N is non-prime");
            break;
        
            
            
            
        }

    
    Console.WriteLine("N is Prime");
    break;}
    }
    
   Console.WriteLine("Assign a int value to n:");
    n=Convert.ToInt32(Console.ReadLine());
       for (int row = 1; row <=n; row++) {
    for (int col = 1;col<=n; col++)
    {
        Console.Write("*");
        
    }
    Console.WriteLine("");
} 

Console.WriteLine("Assign a int value to n:");
    n=Convert.ToInt32(Console.ReadLine());
       for (int row = 1; row <=n; row++) {
    for (int col = 1;col<=n; col++)
    if (row>=col)
    {
        Console.Write('*');
        
    }
    Console.WriteLine("");
}

 Console.WriteLine("Assign a int value to n:");
    n=Convert.ToInt32(Console.ReadLine());
       for (int row =1 ; row <=n; row++) {
    for (int col =1 ;col<=n; col++)
    if(col<=row)
    {
        Console.Write(row);
        
    }
    Console.WriteLine("");
} }}      
        
        






   





        
    

    

    

      
    
    
    

    
    
    








        




        
        
        
    


        
        

        
    
  

        
            
        
            
        
        

        
        
    


  
        
            
                      
        
            






            
    
 
          








    
          
                 


                    
          
        


        
    





