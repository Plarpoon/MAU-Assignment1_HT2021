namespace MAU_Assignment1_HT2021;

public class Pet
{
    //  I've added the question mark next to the variable type to avoid "null" values.
    //  Since all these values are private a discard sign is added in front of them.
    private string? _name;
    private int? _age;
    private bool _isFemale;

    //  I am not too happy with this 'temp' variable but
    //  I was under the impression it was required to have
    //  a 'isFemale' named variable for the sake of the exam
    //  I'm terribly sorry for the lack of optimization.
    private float _inputAge;
    private char _char;
    private bool _loop;

    internal void Start()
    {
        Console.WriteLine("What is the name of your pet?");
        _name = Console.ReadLine();
        Console.WriteLine("\nThe name you selected is " + _name);

        Console.WriteLine("\nWhat is " + _name + "'s age?");

        //  I'm really tempted to leave the 'float' and avoid all these issues
        //  but with this '_age' will be an 'int' type like the exercise requires.
        try
        {
            _inputAge = float.Parse(Console.ReadLine() ?? string.Empty);    //  Parsing of a string into a float to accept any numeric input.
            if (_inputAge != 0 && _inputAge < 0)
                _inputAge *= -1;    //  If the number is negative then make it positive.
            _age = Convert.ToInt32(_inputAge);
        }
        catch (Exception e) // this is because testers enjoyed typing letters and symbols or numbers bigger than an INT32 on purpose.
        {
            Console.WriteLine("\nPlease enter a valid age for a pet.");
            Console.WriteLine("\nERROR: " + e);
            Console.WriteLine("\n++++++++++++++++++++++");
            Console.WriteLine("Press Enter to exit the program.");
            Console.WriteLine("++++++++++++++++++++++");
            Console.ReadLine();
            throw;
        }
        
        Console.WriteLine("\nThe age you selected is " + _age);

        Console.WriteLine("\nWrite 'f' if you pet is Female or 'm' if Male");
        do
        {
            _char = Convert.ToChar(Console.ReadLine()?.Remove(1).ToLower() ?? string.Empty);
            switch (_char)
            {
                case 'f':
                    _isFemale = true;
                    _loop = true;
                    break;
                case 'm':
                    _isFemale = false;
                    _loop = true;
                    break;
                default:
                    Console.WriteLine("Please try again..");
                    break;
            }
        } while (_loop == false);

            //  I've integrated an 'if' into the following WriteLine
            //  It defaults to 'if == true' so I decided to cut also the other redundant bloat
            //  before edit: Console.WriteLine(isFemale == true ? "Your pet is female" : "Your pet is male.");
            Console.WriteLine(_isFemale ? "\nYour pet is female" : "\nYour pet is male.");

            //  Presentation on console.
            Console.WriteLine("\n++++++++++++++++++++++");
            Console.WriteLine("Name: {0} Age: {1}", _name, _age);
            if (_isFemale)
            {
                Console.WriteLine(_name + " is a good girl!");
            }
            else
                Console.WriteLine(_name + " is a good boy!");
            Console.WriteLine("++++++++++++++++++++++\n");
    }
}