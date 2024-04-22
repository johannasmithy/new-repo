System.Console.WriteLine("Let's play a guessing game! Enter a number between 1 and 100: ");
//Random rand = new(int)
//int value = rand.Next(min, max-1)
int guessingGameNumber = 0;
Random random = new Random();
int randomNumber = random.Next(1, 100);
string guessinggameinput = Console.ReadLine();
        
if (guessinggameinput != null)        
    guessingGameNumber = int.Parse(guessinggameinput);
        
while (guessingGameNumber != randomNumber)
    {
            {
            if (guessinggameinput != null)        
                guessingGameNumber = int.Parse(guessinggameinput);    

            if (guessingGameNumber < randomNumber)
                {
                System.Console.WriteLine("This is awkward...your guess was less than the correct number. Enter another number between 1 and 100 to play again."); 
                    guessinggameinput = Console.ReadLine();
                }
            if (guessingGameNumber > randomNumber)
                {
                System.Console.WriteLine("This is extra awkward...Your guess was greater than the correct answer. Enter another number between 1 and 100 to play again."); 
                    guessinggameinput = Console.ReadLine();
                } 
            if (guessingGameNumber == randomNumber)
                {
                System.Console.WriteLine("Congratulations! You guessed the correct number and won the Guessing Game!"); 
                }  
            } 
    }

