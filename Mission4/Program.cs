using Mission4;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] x = ["O", "O", "O", "O", "X", "X", "X", "O", "O"];

        Support.printBoard(x);

        Console.WriteLine( Support.results(x) );

    }
}