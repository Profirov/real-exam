
        
        string fanName = Console.ReadLine();
        double budget = double.Parse(Console.ReadLine());
        int beerCount = int.Parse(Console.ReadLine());
        int chipsCount = int.Parse(Console.ReadLine());

        double beerPrice = beerCount * 1.20;

       
        double chipsPrice = Math.Ceiling(beerPrice * 0.45) * chipsCount;

    
        double totalCost = beerPrice + chipsPrice;

       
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
    
