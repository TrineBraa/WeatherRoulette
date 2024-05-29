//Weather Roulette 
//Denne appen skal være et slags spill hvor man skal “gjette” hva slags klær som matcher til hva slags vær. Konsollen skal vise en tilfeldig værtype
//    (eksempelvis sterk sol, regnvær, snøstorm) og gi spilleren et valg mellom 3 outfits. En av disse stemmer til værtypen, de andre to ikke. Spilleren skal få feedback på om valget var riktig eller ikke
//Eks: “Dagens vær: Sterk sol”  Valg options: Shorts og T skjorte gir feedbacken “Deilig vær med korte klær!”  Vinterjakke og skibukse gir feedbacken “Oi, dette ble for varmt - jeg tror jeg kovner!” 
//og valget Regnjakke og sydvest kan f.eks gi feedbacken “Dette ble…klamt. Skulle valgt en annen outfit”

//Array av de forskjellige værtypene
//Random som gir en værtype
//Options om hvilke klær du kan ta på deg
//Få tilbakemelding om det var rett eller galt osv.


string[] VærType = new[]
{
    "Strong sunshine",
    "Rainstorm",
    "Snowy",
};

string[] KlesType = new[]
{
    "Shorts and t-shirt",
    "Raincoat and rubber boots",
    "winter coat and mittens",
};



Main();



void Main()
{
    while (true)
    {
        Console.Clear();
        Random Rnd = new Random();
        int Number = Rnd.Next(0, 2);
        string NewWeather = VærType[Number];




        Console.WriteLine("What is the weather today ?");
        Console.WriteLine(NewWeather);
        Console.WriteLine("What do you want to wear today?");
        Console.WriteLine();
        for (int i = 0; i < KlesType.Length; i++)
        {
            Console.WriteLine(i + " " + KlesType[i]);
        }


        int Chosen = 7;


        while (Chosen > 2)
        {
            char Input = Console.ReadKey().KeyChar;
            Chosen = Input - '0';
            if (Chosen > 2)
            {
                Console.WriteLine("Invalid Option!");
            }
        }

        string Clothing = KlesType[Chosen];

        if (Number == 0)
        {
            if (Chosen == 0)
            {
                Console.WriteLine("Perfect Clothing for a perfect day!");
            }
            else if (Chosen == 1)
            {
                Console.WriteLine("You are going to be very sweaty in there!");
            }
            else
            {
                Console.WriteLine("You are going to melt!");
            }
        }
        else if (Number == 1)
        {
            if (Chosen == 0)
            {
                Console.WriteLine("You will be getting wet!");
            }
            else if (Chosen == 1)
            {
                Console.WriteLine("You will stay dry and nice in the rain!");
            }
            else
            {
                Console.WriteLine("That is going to be very wet and heavy!");
            }
        }
        else if (Number == 2)
        {
            if (Chosen == 0)
            {
                Console.WriteLine("You will freeze to ice!");
            }
            else if (Chosen == 1)
            {
                Console.WriteLine("That won't keep you very warm at all!");
            }
            else
            {
                Console.WriteLine("That is cozy warm!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Option! Try again");
        }

        Thread.Sleep(2000);
    }
}


