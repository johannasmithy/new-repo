System.Console.WriteLine("Let's play a guessing game! Enter a number between 1 and 100: ");
int guessingGameNumber = 0;
string guessinggameinput = Console.ReadLine();
        
if (guessinggameinput != null)        
    guessingGameNumber = int.Parse(guessinggameinput);
        
while (guessingGameNumber != 73)
    {
            {
            if (guessinggameinput != null)        
                guessingGameNumber = int.Parse(guessinggameinput);    

            if (guessingGameNumber < 73)
                {
                System.Console.WriteLine("This is awkward...your guess was less than the correct number. Enter another number between 1 and 100 to play again."); 
                    guessinggameinput = Console.ReadLine();
                }
            if (guessingGameNumber > 73)
                {
                System.Console.WriteLine("This is extra awkward...Your guess was greater than the correct answer. Enter another number between 1 and 100 to play again."); 
                    guessinggameinput = Console.ReadLine();
                } 
            if (guessingGameNumber == 73)
                {
                System.Console.WriteLine("Congratulations! You guessed 73 and won the Guessing Game!"); 
                }  
            } 
    }

