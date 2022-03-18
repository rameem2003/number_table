using System;

namespace table_of_number
{
    class app
    {
        public static void Main()
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int product;

            for(i = 1; i <= 10; i++)
            {
                product = n * i;
                Console.WriteLine("Product of " + n + " * " + i + " is " + product);
            }
        }
    }
}