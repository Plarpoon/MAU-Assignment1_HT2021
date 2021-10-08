namespace MAU_Assignment1_HT2021_Part1;

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

    internal void Start()
    {
        Console.WriteLine("Welcome to KIDS' FAIR!\nChildren get always a 75% discount!\n\nEach ticket is {0}€", Price);

        Console.WriteLine("\nWrite your name please:");
        _name = Console.ReadLine();
        Console.WriteLine("\nThe name you have written is: " + _name);

        try    // input sanitization again, please read 'Pet'.
        {
            Console.WriteLine("\nWrite the number of adults:");
            _inputNumber = float.Parse(Console.ReadLine() ?? string.Empty);
            if (_inputNumber < 0)
                _inputNumber *= -1;
            _numOfAdults = (int)Math.Round((decimal)_inputNumber);
            Console.WriteLine("The written number of adults is:\n" + _numOfAdults);

            Console.WriteLine("\nWrite the number of children:");
            _inputNumber = float.Parse(Console.ReadLine() ?? string.Empty);
            if (_inputNumber < 0)
                _inputNumber *= -1;
            _numOfChildren = (int)Math.Round((decimal) _inputNumber);
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
        Console.WriteLine("\n+++ Your receipt +++\n+++ total amount to pay = {0}€\n+++ DETAILED PAYMENT\n+++ Paid amount by adults: {1}€\n+++ Paid amount by kids: {2}€\n\n+++ Thank you {3} for your purchase!\n\nHAVE A NICE DAY!\n", _amountToPay, _totalAdultPrice, _totalChildrenPrice, _name);
    }
}