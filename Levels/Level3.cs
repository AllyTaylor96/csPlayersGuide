namespace csPlayersGuide.Levels;

public class Level3
{
    public static void Complete()
    {
        SayHello();
        SayGoodbye();
        SaySomethingComplex();
        TakeNameFromConsole();
    }
    private static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
    private static void SayGoodbye()
    {
        Console.WriteLine("Goodbye, World!");
    }
    private static void SaySomethingComplex()
    {
        Console.WriteLine("Baking bread...");
        Console.WriteLine("Still waiting...");
        Console.WriteLine("Still still waiting...");
        Console.WriteLine("How long does it take...");
        Console.WriteLine("Surely ready soon...");
    }
    private static void TakeNameFromConsole()
    {
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is the bread for?");
        var name = Console.ReadLine();
        Console.WriteLine($"Noted: {name} got bread.");
    }
}