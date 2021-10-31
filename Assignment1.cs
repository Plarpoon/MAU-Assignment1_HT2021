using System;
using System.Text;

namespace MAU_Assignment1_HT2021
{
    public static class Assignment1 // Assignment 1 (HT2021) Part 1
    {
        public static void Main()
        {
            InitConsole();
            Console.OutputEncoding = Encoding.UTF8;

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
}