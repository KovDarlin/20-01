class Passport
{
    public string Num_Passport { get; set; }
    public string Full_Name { get; set; }
    public DateTime Date { get; set; }

    public Passport(string num_Passport, string full_Name, DateTime date)
    {
        if (string.IsNullOrEmpty(num_Passport))throw new ArgumentException("Number password can`t be empty!");
        if (string.IsNullOrEmpty(full_Name)) throw new ArgumentException("Full name owner`s can`t be empty!");
        if (date > DateTime.Now) throw new ArgumentException("Date can`t be in future!");


        Num_Passport = num_Passport;
        Full_Name = full_Name;
        Date = date;
    }

    public void Print()
    {
        Console.WriteLine($"Number passport:  {Num_Passport}");
        Console.WriteLine($"Full name: {Full_Name}");
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Passport passport = new Passport("3489765678", "Marina Konotop", new DateTime(2024, 09, 01));
            passport.Print();
            Console.WriteLine();

            Passport bad_passport = new Passport("", "", new DateTime(2026, 09, 01));
            bad_passport.Print();

        }
        catch (ArgumentException problem)
        {
            Console.WriteLine($"Error: {problem.Message}");
        }
        
    }
}