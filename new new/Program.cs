
        
        int locationsCount = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < locationsCount; i++)
        {
            
            double expectedAverageGold = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            
            double totalGold = 0;

            
            for (int day = 0; day < days; day++)
            {
                double dailyGold = double.Parse(Console.ReadLine());
                totalGold += dailyGold;
            }

            
            double averageGoldPerDay = totalGold / days;

            
            if (averageGoldPerDay >= expectedAverageGold)
            {
                Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:F2}.");
            }
            else
            {
                
                double neededGold = expectedAverageGold - averageGoldPerDay;
                Console.WriteLine($"You need {neededGold:F2} gold.");
            }
        }
    

