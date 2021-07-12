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
    string playerInput;
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
            if (playerInput == "q")
        {
            keepPlaying = false;
            sp.print("bye");
            continue;
        }
        switch(randomnum)
            { case 0: 
string ComputerChoice = "rock";
if (ComputerChoice == playerInput)
{
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
break;
case 1:
 ComputerChoice = "paper";
 if (playerInput == "paper")
 {
     Console.WriteLine("tie");
 }
 else if (playerInput == "rock")
 {
     Console.WriteLine("computer wins");
 }
 else if (playerInput == "scissors")
 {
     Console.WriteLine("you win");
 }
break;
case 2:
ComputerChoice = "scissor";
if(playerInput == "scissor")
{
Console.WriteLine("tie");
}
else if(playerInput == "rock")
{
Console.WriteLine("you win");
}
else if(playerInput == "paper")
{
    Console.WriteLine("computer wins");
}
break;
}
 
        }

        }


    }

//     public void ComputerChoice()
//     {


//     }
}

