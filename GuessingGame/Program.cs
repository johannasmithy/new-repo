bool again = true;

while (again)
{
    Random random = new Random();
    int randomNumber = random.Next(1, 101);
    int guessingGameNumber = 0;
    string? guessinggameinput;
    System.Console.WriteLine("Let's play a guessing game! Enter a number between 1 and 100: ");       
while (guessingGameNumber != randomNumber)
    {
        guessinggameinput = Console.ReadLine();
        if (guessinggameinput != null) guessingGameNumber = int.Parse(guessinggameinput);    

        if (guessingGameNumber < randomNumber)
            {
                System.Console.WriteLine("This is awkward...your guess was less than the correct number. Enter another number between 1 and 100 to play again."); 
            }
        else if (guessingGameNumber > randomNumber)
            {
                System.Console.WriteLine("This is extra awkward...Your guess was greater than the correct answer. Enter another number between 1 and 100 to play again.");             
            } 
    }

    System.Console.WriteLine("Congratulations! You won the Guessing Game! The number was "+ randomNumber); 

    System.Console.WriteLine("Would you like to play again? Enter Yes or no.");
    guessinggameinput = Console.ReadLine();

    if (!"Yes".Equals(guessinggameinput) )
    {
        again = false;
    }
}

System.Console.WriteLine("Thanks for playing! This message will self destruct in 3...2...1...");