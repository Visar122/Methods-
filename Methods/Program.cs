using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The name Game");

            Console.Write("Whats your fitrst name : ");
            string firstname = Console.ReadLine();

            while(validatefirstName(firstname))
            {
                Console.WriteLine("Invalid First name ");
                Console.WriteLine("Whats ur Name Again : ");
                firstname = Console.ReadLine();
            }
  
            Console.Write("Whats your last name :");
            string lastname = Console.ReadLine();

            Console.Write("whats your city name : ");
            string city = Console.ReadLine();

            Console.Write("How old Are U :");
            int age=int.Parse(Console.ReadLine());



            while(Validatetheage(age))
            {
                Console.WriteLine("U should be over 18 to play this game ");
                Console.WriteLine("Try Again  put ur Age if you are over 18 ");
                age = int.Parse(Console.ReadLine());
            }
              
           

            DisplayResult(ReverseString(firstname),
                ReverseString(lastname),
                ReverseString(city),
                ReverseString(age.ToString())) ;

      
           




            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
          

            return string.Concat(messageArray);
          
        }
     
        private static void DisplayResult(string reversedFirstName,string reversedlastname,string reversedcity,string reversedage )
        {
            Console.Write("Result : ");

            Console.WriteLine("{0} {1} {2} {3}",
              reversedFirstName,
              reversedlastname,
              reversedcity,
              reversedage);

        }
     private static bool validatefirstName(string firstname)
        {
            if (firstname.StartsWith("v", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
      private static bool  Validatetheage( int age)
        {
            if(age == 18)
            {
                return true;
            }
            return true;
        }
    }
}
