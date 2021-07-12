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
    public void Start(){

     
      var random = new Random();
  var list = new List<string>{ "rock","paper","scissor"};
         int index = random.Next(list.Count);
      sp.print(@"
Choose rock, paper or scissors");

    

    }

//     public void ComputerChoice()
//     {



//     }
}

}