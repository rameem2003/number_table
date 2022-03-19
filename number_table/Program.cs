using System;

namespace table_of_number
{
    class app
    {
        public static void Main()
        {
            Console.WriteLine("<<<< Multiplication Table >>>>");
            Console.Write("Enter the number for know the multiplication table: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the range for multiplication table: ");
            int range = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int product;

            for(i = 1; i <= range; i++)
            {
                product = n * i;
                Console.WriteLine("Product of " + n + " * " + i + " is " + product);
            }
        }
    }
}