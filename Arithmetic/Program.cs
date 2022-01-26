using System;

namespace Arithmetic {
   class Arithmetic
   {
      static void Main(string[] args)
      {
         int number1; //declare first number to add
         int number2; //declare second number to add
         int sum; // declare sum of number1 and number2
         int difference; // declare difference of number1 and number2
         int product; // declare product number1 and number2
         int quotient; //declare product number1 and number2


         Console.Write("Enter first integer "); // prompt user
         // read first number from user
         number1 = int.Parse(Console.ReadLine());

         Console.Write("Enter second integer"); //prompt user
         //read second number from user
         number2 = int.Parse(Console.ReadLine());

         sum = number1 + number2;//add numbers
         difference = number1 - number2; //subtract number
         product = number1 * number2; // multiply number
         quotient = number1 / number2; // divide number

         Console.WriteLine($"Sum is {sum}"); //display sum
         Console.WriteLine($"difference is {difference}");
         Console.WriteLine($"product is {product}");
         Console.WriteLine($"quotient is {quotient}");

      }

      }

   
   


 }
         




