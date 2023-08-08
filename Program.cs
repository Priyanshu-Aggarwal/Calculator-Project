using Calculator;
using static System.Console;
public class Entry
{
    static void Main(string[] args)
    {
        CalculatorDevice device = new();

        while (true)
        {
            dynamic first, second;

            // Read first Number
            Console.Write("Enter First Number: ");
            first  = ReadLine();

            // Read Second Number
            Console.Write("Enter Second Number: ");
            second = ReadLine();

            Console.WriteLine("Choose Operation ");
            Console.WriteLine(" 1 for Addition ");
            Console.WriteLine(" 2 for Subtraction ");
            Console.WriteLine(" 3 for Multiplication ");
            Console.WriteLine(" 4 for Division ");

            int result = Convert.ToInt32(ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("Result = " + device.Add(first, second));
                    break;
                case 2:
                    Console.WriteLine("Result = " + device.Subtract(first, second));
                    break;
                case 3:
                    Console.WriteLine("Result = " + device.Multiply(first, second));
                    break;
                case 4:
                    Console.WriteLine("Result = " + device.Divide(first, second));
                    break;

                default: Console.WriteLine("Incorrect Option"); break;
            }

        }
    }
}

