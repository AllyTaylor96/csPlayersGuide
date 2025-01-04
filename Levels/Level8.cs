namespace csPlayersGuide.Levels;

public class Level8
{
    public static void Complete()
    {
        BuildBetterConsole();
        DefendConsolas();
    }
    private static void BuildBetterConsole()
    {
        Console.Clear();
        // Beep not supported on WSL - so missed out
        // Console.Beep(440, 1000);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "\"Consolas Defence\"";
        Console.WriteLine("The city of Consolas is under attack...");
    }
    private static void DefendConsolas()
    {
        Console.WriteLine("An attack is incoming to Consolas! Check where it is going to hit!");

        Console.Write("What is the target row? ");
        int targetRow = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the target column? ");
        int targetColumn = Convert.ToInt32(Console.ReadLine());

        List<(int, int)> defencePositions = CalculateWhereToDeploySquad(targetRow, targetColumn);

        Console.WriteLine("Deploy to the following positions to protect the city!");
        Console.ForegroundColor = ConsoleColor.Red;

        foreach ((int, int) setOfPositions in defencePositions)
        {
            Console.WriteLine(setOfPositions); 
        }

        // Console.Beep(440, 1000);
    }

    private static List<(int, int)> CalculateWhereToDeploySquad(int targetRow, int targetColumn)
    {
        (int, int) aboveTarget = (targetRow+1, targetColumn);
        (int, int) belowTarget = (targetRow-1, targetColumn);
        (int, int) rightTarget = (targetRow, targetColumn+1);
        (int, int) leftTarget = (targetRow, targetColumn-1);

        List<(int, int)> deploymentPositions = new List<(int, int)> { aboveTarget, belowTarget, rightTarget, leftTarget };
        return deploymentPositions;
    } 
}