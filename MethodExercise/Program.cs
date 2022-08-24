using System;

namespace MethodExercise
{
    class Program
    {
      
        public static int add(params int[] listNumbers)
        {
            int total = 0;

            foreach(int i in listNumbers)
            {
                total += i;
            }
            return total;
        }

        public static int subtract(params int[] listNumbers)
        {
            int total = 0;

            foreach(int i in listNumbers)
            {
                total -= i;
            }
            return total;
        }

        public static int multiply(params int[] listNumbers)
        {
            int total = 0;

            foreach(int i in listNumbers)
            {
                total *= i;
            }
            return total;
        }

        public static int divide(params int[] listNumbers)
        {
            int total = 0;

            foreach (int i in listNumbers)
            {
                total /= i;
            }
            return total;
        }

        public static int modulas(params int[] listNumbers)
        {
            int total = 0;

            foreach (int i in listNumbers)
            {
                total %= i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            // Methods
            int a = add(2, 5, 7);
            int s = subtract(3, 4);
            int m = multiply(6, 9);
            int d = divide(4, 4);
            int mod = modulas(8, 7);

           Console.WriteLine(a);
           Console.WriteLine(s);
           Console.WriteLine(m);
           Console.WriteLine(d);
           Console.WriteLine(mod);

            // Story
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite hobbie?");
            string hobbie = Console.ReadLine();

            Console.WriteLine("Where do you live?");
            string city = Console.ReadLine();

            Console.WriteLine("Who do you like spending time with?");
            string spendTimeWith = Console.ReadLine();

            Console.WriteLine("What is your job title?");
            string jobTitle = Console.ReadLine();

            Console.WriteLine($"This is " + name);
            Console.WriteLine($"" + name + "lives in " + city);
            Console.WriteLine($"" + name + "likes " + hobbie);
            Console.WriteLine($"" + name + "likes spending time with " + spendTimeWith);
            Console.WriteLine($"" + name + "Is a " + jobTitle);
            Console.WriteLine("Be like " + name);

            
        }
    }
}
