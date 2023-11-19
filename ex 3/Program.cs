
        
        string pastryType = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        
        double cakePrice = 0;
        double soufflePrice = 0;
        double baklavaPrice = 0;

        
        if (day <= 15)
        {
            cakePrice = 24;
            soufflePrice = 6.66;
            baklavaPrice = 12.60;
        }
        else
        {
            cakePrice = 28.70;
            soufflePrice = 9.80;
            baklavaPrice = 16.98;
        }

        double totalCost = 0;

        switch (pastryType)
        {
            case "Cake":
                totalCost = cakePrice * quantity;
                break;
            case "Souffle":
                totalCost = soufflePrice * quantity;
                break;
            case "Baklava":
                totalCost = baklavaPrice * quantity;
                break;
        }

       
        if (day <= 22)
        {
            if (totalCost > 100 && totalCost <= 200)
            {
                totalCost *= 0.85; 
            }
            else if (totalCost > 200)
            {
                totalCost *= 0.75; 
            }
        }

        if (day <= 15)
        {
            totalCost *= 0.9; 
        }

       
        Console.WriteLine($"{totalCost:f2}");
    

