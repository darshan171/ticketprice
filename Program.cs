using System;

namespace ageticket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //   Console.WriteLine("Enter your age:");
            //  int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is: " + age);

        int age;
        string input;
        Console.WriteLine("WelCome To ComIT Movie Theatre");
        Console.WriteLine("Please Enter your age:");
        input = Console.ReadLine();
        age = Convert.ToInt32(input);
        //Console.WriteLine("Your Age Is: " +age); 
        //Console.Read();  
           if(age <= 5)
           {
            Console.WriteLine("You Do not need to pay anything");
            }
            else if(age > 5 && age <= 14)
            {
                Console.WriteLine("The Ticket Price Is : $ 7.99");
            }
            
            else if(age > 14 && age <= 65)
            {
                Console.WriteLine("The Ticket Price Is : $ 11.99");
            }
            else if(age >= 65)
            {
                Console.WriteLine("The Ticket Price Is : $ 9.99");
            }
      
        }
    }
}
