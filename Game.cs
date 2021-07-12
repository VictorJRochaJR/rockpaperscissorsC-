using System;
using rockpaperscissors.Utils;


namespace rockpaperscissors
{

class Game
{
    private bool keepPlaying = true;
    public int Score {get; private set; } = 0;
    ScreenPrinter  sp =  new ScreenPrinter();
    public void Start(){
      var r = "rock";
      var p = "paper";
      var s = "scissor";
      sp.print(@"
Choose rock, paper or scissors");

    

    }

    public void ComputerChoice()
    {



    }
}

}