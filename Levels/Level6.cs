namespace csPlayersGuide.Levels;

public class Level6
{
    public byte byteNumber = 18;
    public short shortNumber = -30_000;
    public int intNumber = 2_000_000;
    public long longNumber = 5_000_000_000_000;
    public sbyte sbyteNumber = -50;
    public ushort ushortNumber = 100;
    public uint uintNumber = 200_000;
    public ulong ulongNumber = 20_000_000_000;
    // can declare characters using hexadecimal Unicode numner for a symbol after \u
    public char charVariable = '\u0061';
    public string stringVariable = "Another variable declared";
    public float floatNumber = 0.3333F;
    // can use scientific notation in declaring numbers
    public double doubleNumber = 6.022e23;
    public decimal decimalNumber = 0.777_777_777_777_777_777m;
    public bool boolVariable = true;

    public void Complete()
    {
        BrowseVariableShop();
        UpdateVariableShop();
        BrowseVariableShop();
    }
    private void BrowseVariableShop()
    {
        Console.WriteLine($"A byte has range 0-256: {byteNumber}");
        Console.WriteLine($"A short has range -/+32768: {shortNumber}");
        Console.WriteLine($"An int has ~range -/+2Billion: {intNumber}");
        Console.WriteLine($"A long has ~range -/+9Quintillion: {longNumber}");
        Console.WriteLine($"An sbyte (signed byte) has range -/+128-: {sbyteNumber}");
        Console.WriteLine($"A ushort (unsigned short) has range 0-65535: {ushortNumber}");
        Console.WriteLine($"A uint (unsigned int) has ~range 0-4Billion: {uintNumber}");
        Console.WriteLine($"A ulong (unsigned long) has ~range 0-18.5Quintillion: {ulongNumber}");

        Console.WriteLine($"A char uses 2 bytes and can represent 65,536 total different characters: {charVariable}");
        Console.WriteLine($"A string is simply an aggregation of chars in a single variable: {stringVariable}");

        Console.WriteLine($"A float has 7 digits of precision: {floatNumber}");
        Console.WriteLine($"A double has 15-16 digits of precision: {doubleNumber}");
        Console.WriteLine($"A decimal has 28-29 digits of precision: {decimalNumber}");

        Console.WriteLine($"A bool can only either contain true/false: {boolVariable}");
    }

    private void UpdateVariableShop()
    {
        byteNumber = 31;
        shortNumber = 20_000;
        intNumber = 3_000_000;
        longNumber = 5_000_000_000_001;
        sbyteNumber = 25;
        ushortNumber = 200;
        uintNumber = 300_000;
        ulongNumber = 30_000_000_000;
        charVariable = 'B';
        stringVariable = "A new string variable";
        floatNumber = 1.368F;
        doubleNumber = 2.023e15;
        decimalNumber = 0.117_777_777_777_777_777m;
        boolVariable = false;
    }
}