using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] priceRatings = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        int entryPoint = int.Parse(Console.ReadLine());
        string itemType = Console.ReadLine();

        int leftDamage = CalculateDamage(priceRatings, entryPoint, -1, itemType);
        int rightDamage = CalculateDamage(priceRatings, entryPoint, 1, itemType);

        string position;
        int damage;

        if (leftDamage >= rightDamage)
        {
            position = "Left";
            damage = leftDamage;
        }
        else
        {
            position = "Right";
            damage = rightDamage;
        }

        Console.WriteLine($"{position} - {damage}");
    }

    static int CalculateDamage(int[] priceRatings, int entryPoint, int direction, string itemType)
    {
        int damage = 0;

        for (int i = entryPoint + direction; i >= 0 && i < priceRatings.Length - 1; i += direction)
        {
            if ((itemType == "cheap" && priceRatings[i] < priceRatings[entryPoint])
                || (itemType == "expensive" && priceRatings[i] >= priceRatings[entryPoint]))
            {
                damage += priceRatings[i];
            }
        }

        return damage;
    }
}