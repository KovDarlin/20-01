using System.Data;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Input: ");

            string input = Console.ReadLine();
            string[] operation = { "<=", ">=", "==", "!=", "<", ">" };
            string chose = null;

            foreach (string active in operation)
            {
                if (input.Contains(active))
                {
                    chose = active;
                    break;
                }
            }

            if (chose == null) throw new Exception("No correct operation!");

            string[] part = input.Split(new string[] { chose }, StringSplitOptions.None);
            if (part.Length != 2) throw new Exception("Not correct format!");

            int first = int.Parse(part[0].Trim());
            int second = int.Parse(part[1].Trim());
            bool result = false;


            switch (chose)
            {
                case "<":
                    result = first < second;
                    break;
                case ">":
                    result = first > second;
                    break;
                case "<=":
                    result = first <= second;
                    break;
                case ">=":
                    result = first >= second;
                    break;
                case "==":
                    result = first == second;
                    break;
                case "!=":
                    result = first != second;
                    break;
            }
            Console.WriteLine($"Result: {result}"); 
        }
        catch (Exception problem)
        {
            Console.WriteLine($"Error: {problem.Message}");
        }
    }
}