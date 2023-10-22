namespace _1.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double neededExp = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            double[] exp = new double[countOfBattles];
            int counter = 1;

            for (int i = 0; i < countOfBattles; i++)
            {
                if (counter % 3 == 0)
                {
                    exp[i] = double.Parse(Console.ReadLine()) * 1.15;
                }
                else if (counter % 5 == 0)
                {
                    exp[i] = double.Parse(Console.ReadLine()) * 0.9;
                }
                else if (counter % 15 == 0)
                {
                    exp[i] = double.Parse(Console.ReadLine()) * 1.05;
                }
                else
                {
                    exp[i] = double.Parse(Console.ReadLine());
                }
                double sumOfExp = exp.Sum();
                if (neededExp <= sumOfExp)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
                    return;
                }


                counter++;
            }
            if (neededExp <= exp.Sum())
            {
                Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
            }
            else if (neededExp > exp.Sum())
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(neededExp - exp.Sum()):f2} more needed.");
            }
        }
    }
}