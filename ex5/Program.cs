

        
        int adultsCount = 0;
        int kidsCount = 0;
        int toysCost = 0;
        int sweatersCost = 0;

       
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Christmas")
            {
                break;
            }

            int age = int.Parse(input);

            if (age <= 16)
            {
                kidsCount++;
                toysCost += 5;
            }
            else
            {
                adultsCount++;
                sweatersCost += 15;
            }
        }

        
        Console.WriteLine($"Number of adults: {adultsCount}");
        Console.WriteLine($"Number of kids: {kidsCount}");
        Console.WriteLine($"Money for toys: {toysCost}");
        Console.WriteLine($"Money for sweaters: {sweatersCost}");
    

