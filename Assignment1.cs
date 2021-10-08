namespace MAU_Assignment1_HT2021;
//  This project is made for .NET 6 which is the default version on Windows 11
//  Thus using the new program style linked below
//  https://docs.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates

public static class Assignment1 // Assignment 1 (HT2021)
{
    public static void Main()
    {
        InitConsole();
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var pet = new Pet();
        pet.Start();

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.Clear();

        var ticket = new TicketSeller();
        ticket.Start();

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.Clear();

        var album = new Album();
        album.Start();

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }

    private static void InitConsole()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "KIDS FAIR";
    }
}