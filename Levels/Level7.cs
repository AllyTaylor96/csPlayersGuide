namespace csPlayersGuide.Levels;

public class Level7
{
    public static void Complete()
    {
        TriangleFarmer();
        FourSisters();
        DominionOfKings();
    }
    private static void TriangleFarmer()
    {
        Console.WriteLine("What is the triangle base size?");
        double triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the triangle height size?");
        double triangleHeight = Convert.ToDouble(Console.ReadLine());

        double triangleArea = CalculateTriangleSize(triangleBase, triangleHeight);
        Console.WriteLine($"The triangle area is {triangleArea}!");
    }
    private static double CalculateTriangleSize(double triangleBase, double triangleHeight)
    {
        double triangleArea = (triangleBase * triangleHeight) / 2;
        return triangleArea;
    }
    private static void FourSisters()
    {
        // four sisters get an equal amount of the eggs gathered that day
        // the remainder gets given to a duckbear
        // calculate the remainder using / and %
        Console.WriteLine("How many eggs were gathered today?");
        int numberOfEggsThatDay = Convert.ToInt32(Console.ReadLine());

        int numberOfEggsPerSister = numberOfEggsThatDay / 4;
        int numberOfEggsForDuckbear = numberOfEggsThatDay % 4;
        Console.WriteLine($"The sisters get {numberOfEggsPerSister} eggs each, and the duckbear gets the remaining {numberOfEggsForDuckbear}!");
    }

    private static void DominionOfKings()
    {
        // calculate how great a users kingdom is
        // estates are worth 1 point, duchys 3 and provinces 6
        Console.WriteLine("How many provinces do you have?");
        int numberProvinces = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many duchies do you have?");
        int numberDuchies = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many estates do you have?");
        int numberEstates = Convert.ToInt32(Console.ReadLine());

        int kingdomScore = (numberProvinces * 6) + (numberDuchies * 3) + numberEstates;
        Console.WriteLine($"You have a kingdom score of {kingdomScore}!"); 
    }
}