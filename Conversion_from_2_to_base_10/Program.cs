namespace Conversion_from_2_to_base_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string num = Console.ReadLine();

            int decimalNumber = 0;
            int power = 1;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] != '0')
                {
                    decimalNumber += power;
                }
                power *= 2;


            }

            Console.WriteLine($"The decimal equivalent of {num} is {decimalNumber}");
        }
    }
}