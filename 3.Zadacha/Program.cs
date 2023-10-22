using System;

namespace _3.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> priceRating = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());

            string typeOfItems = Console.ReadLine();
            List<int> rightSum = new List<int>();

            List<int> leftSum = new List<int>();
            for (int i = 0; i < entryPoint; i++)
            {
                leftSum.Add(priceRating[i]);

            }
            for (int i = entryPoint + 1; i < priceRating.Count; i++)
            {
                rightSum.Add(priceRating[i]);
            }

            whichItemToRemove(rightSum, typeOfItems, priceRating, entryPoint);
            whichItemToRemove(leftSum, typeOfItems, priceRating, entryPoint);

            if (rightSum.Sum() > leftSum.Sum())
            {
                whatToPrint(rightSum, priceRating, entryPoint, typeOfItems, leftSum);

            }
            else if (rightSum.Sum() <= leftSum.Sum())
            {
                whatToPrint(leftSum, priceRating, entryPoint, typeOfItems, rightSum);
            }
        }

        private static void whatToPrint(List<int> leftOrRightSum, List<int> priceRating, int entryPoint, string? typeOfItems, List<int> rightOrLeftSum)
        {
            if (leftOrRightSum.Sum() > priceRating[entryPoint] && typeOfItems == "cheap")
            {
                Console.WriteLine($"Left - {rightOrLeftSum.Sum()}");
            }
            else if (leftOrRightSum.Sum() <= priceRating[entryPoint] && typeOfItems == "expensive")
            {
                Console.WriteLine($"Left - {rightOrLeftSum.Sum()}");
            }
            else
            {
                Console.WriteLine($"Right - {leftOrRightSum.Sum()}");
            }
        }

        private static void whichItemToRemove(List<int> rightOrLeftSum, string? typeOfItems, List<int> priceRating, int entryPoint)
        {
            for (int i = 0; i < rightOrLeftSum.Count; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (rightOrLeftSum[i] >= priceRating[entryPoint])
                    {
                        rightOrLeftSum.RemoveAt(i);
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (rightOrLeftSum[i] < priceRating[entryPoint])
                    {
                        rightOrLeftSum.RemoveAt(i);
                    }
                }
            }
        }
    }
}

/*
1, 5, 1
1
cheap

5, 10, 12, 5, 4, 20
3   
cheap

-2, 2, 1, 5, 9, 3, 2, -2, 1, -1, -3, 3   
7   
expensive
 */