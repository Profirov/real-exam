
       
        int paintBoxes = int.Parse(Console.ReadLine());
        int wallpaperRolls = int.Parse(Console.ReadLine());
        double glovesPrice = double.Parse(Console.ReadLine());
        double brushPrice = double.Parse(Console.ReadLine());

        
        int glovesCount = (int)Math.Ceiling(wallpaperRolls * 0.35);
        int brushCount = (int)Math.Floor(paintBoxes * 0.48);

        
        double paintPrice = paintBoxes * 21.50;
        double wallpaperPrice = wallpaperRolls * 5.20;
        double glovesTotalPrice = glovesCount * glovesPrice;
        double brushTotalPrice = brushCount * brushPrice;

        double totalCost = paintPrice + wallpaperPrice + glovesTotalPrice + brushTotalPrice;

        
        double deliveryCost = totalCost / 15;

        
        Console.WriteLine($"This delivery will cost {deliveryCost:f2} lv.");
    

