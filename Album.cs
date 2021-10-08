namespace MAU_Assignment1_HT2021;

public class Album
{
    private string? _albumName;
    private string? _artistName;

    private float _inputNumber;
    private int _numOfTracks;

    internal void Start()
    {
        Console.WriteLine("Starting the Album Program!\n\nWhat is the name of your favorite music album?");
        _albumName = Console.ReadLine();
        Console.WriteLine("\nThe chosen album name is: " + _albumName);
        Console.WriteLine("\nWhat is the name of the artist or band for '{0}'?", _albumName);
        _artistName = Console.ReadLine();
        Console.WriteLine("\nThe chosen artist name is: " + _artistName);
        Console.WriteLine("\nHow many tracks does '{0}' have?", _albumName);
        try //   again int sanitization... please read Pet class
        {
            _inputNumber = float.Parse(Console.ReadLine() ?? string.Empty);
            if (_inputNumber != 0 && _inputNumber < 0)
                _inputNumber *= -1;
            _numOfTracks = (int) Math.Round((decimal) _inputNumber);
        }
        catch (Exception e)
        {
            Console.WriteLine("\nPlease enter a valid amount of tracks.");
            Console.WriteLine("\nERROR: " + e);
            Console.WriteLine("\n++++++++++++++++++++++");
            Console.WriteLine("Press Enter to exit the program.");
            Console.WriteLine("++++++++++++++++++++++");
            Console.ReadLine();
            throw;
        }

        Console.WriteLine("\nThe given amount of tracks corresponds to: " + _numOfTracks);
        Console.WriteLine(
            "\n\nThis is what I understood!\nAlbum Name: {0}\nArtist or Band: {1}\nNumber of available tracks: {2}\n\nPlease come back!\nEnjoy listening music with us again!",
            _albumName, _artistName, _numOfTracks);
    }
}