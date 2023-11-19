using System;

class Program
{
    static void Main()
    {
        int locationsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < locationsCount; i++)
        {
            double expectedAverageGoldPerDay = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalGold = ReadGoldForDays(days);

            double averageGoldPerDay = totalGold / days;

            PrintResult(averageGoldPerDay, expectedAverageGoldPerDay, days);
        }
    }

    static double ReadGoldForDays(int days)
    {
        double totalGold = 0;
        for (int day = 0; day < days; day++)
        {
            double goldForTheDay = double.Parse(Console.ReadLine());
            totalGold += goldForTheDay;
        }
        return totalGold;
    }

    static void PrintResult(double averageGoldPerDay, double expectedAverageGoldPerDay, int days)
    {
        if (averageGoldPerDay >= expectedAverageGoldPerDay)
        {
            Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:F2}.");
        }
        else
        {
            double neededGold = expectedAverageGoldPerDay * days - averageGoldPerDay * days ;
            Console.WriteLine($"You need {neededGold:F2} gold.");
        }
    }
}
