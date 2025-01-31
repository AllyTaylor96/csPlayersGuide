using System.Xml;

namespace csPlayersGuide.Levels;

public class Level9
{
    public static void Complete()
    {
        RepairingTheClockTower();
        WatchTower();
    }
    private static void RepairingTheClockTower()
    {
        // Output tick if even, and tock if not

        Console.WriteLine("Give me a number please!");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber % 2 == 0)
        {
            Console.WriteLine("Tick");
        }
        else
        {
            Console.WriteLine("Tock");
        }
    }
    private static void WatchTower()
    {
        Console.WriteLine("Give me a x-value of the enemy relative to the watchtower position.");
        int xValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give me a y-value of the enemy relative to the watchtower position.");
        int yValue = Convert.ToInt32(Console.ReadLine());

        // logic here to display correct message to user
        string xDirection = xValue < 0 ? "West" : xValue > 0 ? "East" : "Here";
        string yDirection = yValue < 0 ? "South" : yValue > 0 ? "North" : "Here";

        string message;
        if (xValue != 0 && yValue != 0)
        {
            message = $"The enemy is currently to the {yDirection}{xDirection}!";
        }
        else if (xValue == 0 && yValue != 0)
        {
            message = $"The enemy is currently to the {yDirection}!";
        }
        else if (xValue != 0 && yValue == 0)
        {
            message = $"The enemy is currently to the {xDirection}!";
        }
        else
        {
            message = $"Uh oh! The enemy is at the watchtower!";
        }

        Console.WriteLine(message);
    }
}