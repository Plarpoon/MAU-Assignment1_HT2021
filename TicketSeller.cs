using System.Security.Cryptography.X509Certificates;

namespace MAU_Assignment1_HT2021;

public class TicketSeller
{
    private string? _name;
    private const double Price = 100;   // 'P' is capital since it's a constant value
    private int _numOfAdults;
    private int _numOfChildren;
    private double _amountToPay;

    private float? _inputNumber;
    private double _totalAdultPrice;
    private double _totalChildrenPrice;

    public void Start()
    {
        Console.WriteLine("Welcome to KIDS' FAIR!\nChildren get always a 75% discount!");

        Console.WriteLine("\nWrite your name please:");
        _name = Console.ReadLine();
        Console.WriteLine("The name you have written is: " + _name);

        try    // input sanitization again, please read 'Pet'.
        {
            Console.WriteLine("\nWrite the number of adults:");
            _inputNumber = float.Parse(Console.ReadLine() ?? string.Empty);
            if (_inputNumber < 0)
                _inputNumber *= -1;
            _numOfAdults = Convert.ToInt32(_inputNumber);
            Console.WriteLine("The written number of adults is:\n" + _numOfAdults);

            Console.WriteLine("\nWrite the number of children:");
            _inputNumber = float.Parse(Console.ReadLine() ?? string.Empty);
            if (_inputNumber < 0)
                _inputNumber *= -1;
            _numOfChildren = Convert.ToInt32(_inputNumber);
            Console.WriteLine("The written number of children is:\n" + _numOfChildren);
        }
        catch (Exception e) 
        {
            Console.WriteLine("\nPlease enter a valid number of people.");
            Console.WriteLine("\nERROR: " + e);
            Console.WriteLine("\n++++++++++++++++++++++");
            Console.WriteLine("Press Enter to exit the program.");
            Console.WriteLine("++++++++++++++++++++++");
            Console.ReadLine();
            throw;
        }

        _totalAdultPrice = Price * _numOfAdults;
        _totalChildrenPrice = _numOfChildren * (0.25 * Price);
        _amountToPay = _totalAdultPrice + _totalChildrenPrice;
        Console.WriteLine("\n+++ Your receipt +++\n+++ Amount to pay = " + _amountToPay);
    }
}