using System;

namespace Methods_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite Animal");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite Artist");
            string userArtist = Console.ReadLine();

            Console.WriteLine($"There was a guy named { userName} The guy like the color{userColor}");
            Console.WriteLine($"He likes the {animal} animal and his favorite music artist is {userArtist}");
 
            Console.WriteLine ("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;   

        }
        public static int multiply (int x, int y)
        {
            return x * y;
        }
    }
         
}
