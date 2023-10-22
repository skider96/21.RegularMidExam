namespace _2.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> vehicle = Console.ReadLine()
                .Split(">>")
                .ToList();
           
            List<string> carType = new List<string>();
            List<int> yearsTheTaxShouldBePaid = new List<int>();
            List<int> kilometers = new List<int>();
            List<string> separatedVehicleList = new List<string>();
            for (int i = 0; i < vehicle.Count; i++)
            {

                separatedVehicleList = vehicle[i].Split().ToList();


                carType.Add(separatedVehicleList[0]);
                yearsTheTaxShouldBePaid.Add(int.Parse(separatedVehicleList[1]));
                kilometers.Add(int.Parse(separatedVehicleList[2]));
                separatedVehicleList.Clear();
            }



            int[] totalTaxToPayForCar = new int[carType.Count];
            for (int i = 0; i < carType.Count; i++)
            {
                if (carType[i] == "family")
                {
                    totalTaxToPayForCar[i] += 50;
                    totalTaxToPayForCar[i] = totalTaxToPayForCar[i] - yearsTheTaxShouldBePaid[i] * 5;
                    totalTaxToPayForCar[i] += (kilometers[i] / 3000) * 12;
                    Console.WriteLine($"A {carType[i]} car will pay {totalTaxToPayForCar[i]:f2} euros in taxes.");

                }
                else if (carType[i] == "heavyDuty")
                {
                    totalTaxToPayForCar[i] += 80;
                    totalTaxToPayForCar[i] = totalTaxToPayForCar[i] - yearsTheTaxShouldBePaid[i] * 8;
                    totalTaxToPayForCar[i] += (kilometers[i] / 9000) * 14;
                    Console.WriteLine($"A {carType[i]} car will pay {totalTaxToPayForCar[i]:f2} euros in taxes.");
                }
                else if (carType[i] == "sports")
                {
                    totalTaxToPayForCar[i] += 100;
                    totalTaxToPayForCar[i] = totalTaxToPayForCar[i] - yearsTheTaxShouldBePaid[i] * 9;
                    totalTaxToPayForCar[i] += (kilometers[i] / 2000) * 18;
                    Console.WriteLine($"A {carType[i]} car will pay {totalTaxToPayForCar[i]:f2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }

               
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTaxToPayForCar.Sum():f2} euros in taxes.");
        }
    }
}
// family 3 7210>>van 4 2345>>heavyDuty 9 31000>>sports 4 7410