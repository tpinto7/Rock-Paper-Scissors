using System;
using static System.Console;

namespace Bme121
{
    class Program
    {
        static void Main()
        {
			bool wantsToPlay = true;
			int userWins = 0; 
			int compWins = 0;
			int timesRock = 0;
			int timesPaper = 0;
			int timesScissors = 0;
			
            while(wantsToPlay == true)
            {
				Random rand = new Random();
				int compMove =0;
				
				if(timesRock == timesPaper && timesPaper == timesScissors)
				{
					compMove = rand.Next(3);
				}
				
				else if(timesRock >= timesPaper && timesRock >= timesScissors)
				{
					compMove = 1;
				}
				
				else if(timesPaper >= timesRock && timesPaper >= timesScissors)
				{
					compMove = 2;
				}
				
				int userMove = 0;
				
				WriteLine("Welcome to Rock Paper Scissors! Please select rock, paper, or scissors! Or enter snake to quit.");
				
				string move = ReadLine();
				if(String.Compare(move, "snake") ==0)
				{
					WriteLine("Thanks for playing rock paper scissors! Final score is User Wins: {0} and Computer Wins: {1}", userWins, compWins);
					break;
				}
				
				if(String.Compare(move, "paper") ==0)
				{
					userMove = 1;
				} 
				 if(String.Compare(move, "scissors") ==0)
				{
					userMove = 2;
				}
				
				if(compMove == userMove)
				{
					WriteLine("Tie! You and the computer both selected {0}", move);
					if(userMove ==0)
					{
						timesRock++;
					}
					if(userMove ==1)
					{
						timesPaper++;
					}
					else
					{
						timesScissors++;
					}
				}
				
				else if(userMove ==0)
				{
					if(compMove == 1)
					{
						WriteLine("You Lose! Paper folds Rock!");
						compWins++;
					}
					else
					{
						WriteLine("You Win! Rock crushes Scissors!");
						userWins++;
					}
					timesRock++;
				}
				else if(userMove ==1)
				{
					if(compMove == 2)
					{
						WriteLine("You Lose! Scissors cut Paper!");
						compWins++;
					}
					else
					{
						WriteLine("You Win! Paper fold Rock!");
						userWins++;
					}
					timesPaper++;
				}
				else if(userMove ==2)
				{
					if(compMove == 0)
					{
						WriteLine("You Lose! Rock crushes Scissors!");
						compWins++;
					}
					else
					{
						WriteLine("You Win! Scissor cut Paper!");
						userWins++;
					}
					timesScissors++;
				}
		
				WriteLine("User Wins: {0}", userWins);
				WriteLine("Computer Wins: {0}", compWins);
				
				if(userWins > compWins)
				{
					WriteLine("Wow, we got a real gambler here!");
				}
				
				if(userWins == compWins)
				{
					WriteLine("Not Bad! Keep it Up!");
				}
				
				if(compWins > userWins)
				{
					WriteLine("Hard Luck! You'll get 'em next time!");
				}
				WriteLine();
			}
        }
    }
}
