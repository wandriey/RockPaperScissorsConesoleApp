    using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsConesoleApp
{
    class Fight
    {
        public string playerInput;
        public string cpuInput;
        public int randomNumber;
        public int pointsToPlayer = 0; //Default value 
        public int pointsToCpu = 0; //Default value 
        public bool noWinnerFound = true; //Default value
        public int gamesPlayed = 0; //Default value 
        public int playerTotalWins;
        public int CPUTotalWins;

        public Fight()
        {
            Console.WriteLine("Hello and Welcome to Rock, Paper, Scissors");
            fightStart();
           
        }

        public void endGame()
        {
            if (pointsToPlayer == 3 || pointsToCpu == 3)
            {
                if (pointsToPlayer == 3)
                {
                    Console.WriteLine("Player has won");
                    playerTotalWins++;
                    noWinnerFound = false;
                }
                if (pointsToCpu == 3)
                {
                    Console.WriteLine("CPU has won");
                    CPUTotalWins++;
                    noWinnerFound = false;
                }
                Console.WriteLine("do you wanna play agian? (Y/N)");
                if (Console.ReadLine() == "y")
                {
                    gamesPlayed++;
                    Console.Clear();
                    noWinnerFound = true;
                    Console.WriteLine($"new games has started");
                    Console.WriteLine($"Game number: {gamesPlayed}");
                    fightStart();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Game is stoppet");
                    Console.WriteLine("You can now close the game");
                    Console.WriteLine("PRESS \"ENTER\"");
                    Console.ReadLine();
                }
            }
        }
    

        public void fightStart()
        {
            //When a new game is started the values are set to 0 agian. 
            pointsToCpu = 0;
            pointsToPlayer = 0;

            while (noWinnerFound == true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose either rock, paper or scissors ");
                playerInput = Console.ReadLine().ToLower(); //makes the program not sensetive to upper/lower cases letters 

                if (playerInput != "rock" && playerInput != "paper" && playerInput != "scissors") //validates wheater or not the player input is valid to play with. 
                {
                    Console.WriteLine("The choosen type is not an option, please try agian");
                    fightStart(); //Starts over
                }

                Random numberGenereter = new Random(); //new random object
                randomNumber = numberGenereter.Next(1, 4); //generates a random numbe between 1-3.

                switch (randomNumber) //the 3 differnedt outputs of a fight. 
                {
                    case 1:
                        cpuInput = "rock";
                        Console.WriteLine("CPU choosed: rock");
                        if (playerInput == "rock")
                        {
                            Console.WriteLine("Draw!");
                        }
                        if (playerInput == "paper")
                        {
                            Console.WriteLine("Player wins!");
                            pointsToPlayer++;
                        }
                        if (playerInput == "scissors")
                        {
                            Console.WriteLine("CPU wins!");
                            pointsToCpu++;
                        }
                        Console.WriteLine($"Score is Player: {pointsToPlayer} and CPU: {pointsToCpu}");
                        break;
                    case 2:
                        cpuInput = "paper";
                        Console.WriteLine("CPU choosed: paper");
                        if (playerInput == "rock")
                        {
                            Console.WriteLine("CPU wins!");
                            pointsToCpu++;
                        }
                        if (playerInput == "paper")
                        {
                            Console.WriteLine("Draw!");
                        }
                        if (playerInput == "scissors")
                        {
                            Console.WriteLine("Player wins!");
                            pointsToPlayer++;
                        }
                        Console.WriteLine($"Score is Player: {pointsToPlayer} and CPU: {pointsToCpu}");
                        break;
                    case 3:
                        cpuInput = "scissors";
                        Console.WriteLine("CPU choosed: scissors");
                        if (playerInput == "rock")
                        {
                            Console.WriteLine("Player wins!");
                            pointsToPlayer++;
                        }
                        if (playerInput == "paper")
                        {
                            Console.WriteLine("CPU wins!");
                            pointsToCpu++;
                        }
                        if (playerInput == "scissors")
                        {
                            Console.WriteLine("Draw!");
                        }
                        Console.WriteLine($"Score is Player: {pointsToPlayer} and CPU: {pointsToCpu}");
                        break;
                }
                endGame(); //shows the winner and gives the option to play agian. 
            }
        }
    }
}
