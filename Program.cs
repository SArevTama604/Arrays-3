using System.ComponentModel.DataAnnotations;

namespace Arrays_3
{
    internal class Program
    {
        static double[] numbers = { 5.2, 7.9, 10.0, 4, 9.7 };
        private static double[] number;
        static void MultiplyByTwo(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Before:");
            DisplayArray(numbers);

            MultiplyByTwo(number);

            Console.WriteLine("After:");
            DisplayArray(numbers);
        }

        static void DisplayArray(double[] array)
        {
            Console.Write("{ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine(" }");
        }
    }
}
