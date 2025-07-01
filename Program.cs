using System;

class Converter
{
    public static string ConvertNumber(int number, int fromBase, int toBase)
    {
        string result = Convert.ToString(number, toBase);
        return result;
    }
}


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. 10 -> 2");
            Console.WriteLine("2. 2 -> 10");
            Console.WriteLine("3. 10 -> 16");
            Console.WriteLine("4.16 ->");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Bye...");
                break;
            }

            try
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();
                int number = 0;
                string result = "";

                switch (choice)
                {
                    case "1":
                        number = int.Parse(input);
                        result = Converter.ConvertNumber(number, 10, 2);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "2": 
                        number = Convert.ToInt32(input, 2);
                        Console.WriteLine($"Result: {number}");
                        break;

                    case "3": 
                        number = int.Parse(input);
                        result = Converter.ConvertNumber(number, 10, 16);
                        Console.WriteLine($"Result: {result.ToUpper()}");
                        break;

                    case "4":
                        number = Convert.ToInt32(input, 16);
                        Console.WriteLine($"Result: {number}");
                        break;

                    default:
                        Console.WriteLine("Problem!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct format number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number not int!");
            }
            catch (Exception problem)
            {
                Console.WriteLine($"Error: {problem.Message}");
            }
        }
    }
}
