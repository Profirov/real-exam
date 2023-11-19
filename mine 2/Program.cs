

string fanName = Console.ReadLine();
double budget = double.Parse(Console.ReadLine());
int beerCount = int.Parse(Console.ReadLine());
int chipsCount = int.Parse(Console.ReadLine());

double perbeer = 1.20;

double allbeers = beerCount * perbeer;
double perchips = allbeers * 45.0 / 100.0;
double allchips = chipsCount * perchips;

double totalCost = allbeers + Math.Ceiling(allchips);



if (budget >= totalCost)
{
    double remainingMoney = budget - totalCost;
    Console.WriteLine($"{fanName} bought a snack and has {remainingMoney:f2} leva left.");
}
else
{
    double neededMoney = totalCost - budget;
    Console.WriteLine($"{fanName} needs {neededMoney:f2} more leva!");
}
