using System.Numerics;

namespace ThatsASmallNumber;
class Program
{
    static string to_string(int[] values)
    {
        return string.Join(", ", values);
    }

    static void Main(string[] args)
    {
        ArrayHelper helper = new ArrayHelper();

        int[] values1 = { 1, -3, 104 };
        Console.WriteLine($"Het kleinste getal in ({to_string(values1)}) is {helper.SmallestValue(values1)} op index [{helper.SmallestIndex(values1)}]");

        int[] values2 = { -5, 11, 3 };
        Console.WriteLine($"Het kleinste getal in ({to_string(values2)}) is {helper.SmallestValue(values2)} op index [{helper.SmallestIndex(values2)}]");

        int[] values3 = { 0, 109, 66 };
        Console.WriteLine($"Het kleinste getal in ({to_string(values3)}) is {helper.SmallestValue(values3)} op index [{helper.SmallestIndex(values3)}]");

        int[] values4 = { 8, 19, 3 };
        Console.WriteLine($"Het kleinste getal in ({to_string(values4)}) is {helper.SmallestValue(values4)} op index [{helper.SmallestIndex(values4)}]");
    }
}
