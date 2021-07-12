using System;
using System.Collections.Generic;
using rockpaperscissors.Utils;


namespace rockpaperscissors
{

class Game
{
    private bool keepPlaying = true;
    public int Score {get; private set; } = 0;
    ScreenPrinter  sp =  new ScreenPrinter();
    string playerInput, ComputerChoice;
    int randomnum;

    public void Start(){

     
      var random = new Random();
  var list = new List<string>{ "rock","paper","scissor"};
         int index = random.Next(list.Count);
         randomnum = random.Next(list.Count);
      sp.print(@"
Choose rock, paper or scissors");
PlayGame();
    

    }

    public void PlayGame()
    {
        while(keepPlaying)
        {
            playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower();
            switch(randomnum)
            { case 1: 
ComputerChoice = "rock";
if (playerInput == "rock"){
Console.WriteLine("tie");
}
else if(playerInput == "paper")
{
    Console.WriteLine("you win");
    Score++;
}
else if(playerInput == "scissors")
{
    Console.WriteLine("computer wins");
}
 }

        }

    }

//     public void ComputerChoice()
//     {



//     }
}

}