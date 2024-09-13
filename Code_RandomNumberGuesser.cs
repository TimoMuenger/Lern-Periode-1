class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        string response;
        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = " ";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Errate eine Nummer von" + min + " - " + max + " : ");
                Console.WriteLine("Rate: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " ist zu hoch");


                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + "ist zu klein");
                }
                guesses++;
            }
            Console.WriteLine("Nummer: " + number);
            Console.WriteLine("Du hast gewonnen!");
            Console.WriteLine("Geraten: " + guesses + "mal");

            Console.WriteLine("Willst du noch einmal spielen? (Ja/Nein): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Ja")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }


        Console.ReadKey();
    }
}
