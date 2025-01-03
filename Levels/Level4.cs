namespace csPlayersGuide.Levels;

public class Level4
{
    public static void Complete()
    {
        /* A test of effective commenting 
        including multiline comments*/

        // BadImplementation();
        BetterImplementation();

    }

    private static void BadImplementation()
    {
        /* A bad implementation that requires lots of comments to
        describe the variables and ugly less-readable string manipulation */

        Console.WriteLine("What kind of thing are we talking about?");

        // A noun describing what we are talking about 
        string a = Console.ReadLine();

        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

        // An adjective describing a property of the 'thing'
        string b = Console.ReadLine();

        // A terribly named + unnecessary variable
        string c = "of Doom";

        // Another terribly named + unnecessary variable
        string d = "3000";

        // Some unnecessary string manipulation
        Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
    }

    private static void BetterImplementation()
    {
        /* By naming things better, removing extraneous variables and
        better string manipulation, we clean this up to be more readable
        without requiring comments*/

        Console.WriteLine("What kind of thing are we talking about?");
        string noun = Console.ReadLine();

        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string adjective = Console.ReadLine();

        Console.WriteLine($"The {adjective} {noun} of Doom 3000!");

    }
}
