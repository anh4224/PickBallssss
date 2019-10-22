using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBallsss
{
    class Controller
    {

        public Controller()
        {
            this.Game = new Board(4, 5, 6);
            this.P1 = new Player("Player1");         
            this.P2 = new Player("Player2");
        }

        private Board Game;
        private Player P1, P2;

        public void PlayGame()
        {
            Game.Printgame();
            while (true)
            {
                Console.WriteLine(P1.GetName()+ " play: " );
                P1.PickBalls(Game);
                Game.Printgame();
                if (Game.IsgameOver())
                {
                    Console.WriteLine(P2.GetName()+ " play: ");
                    break;
                }
            
           
                Console.WriteLine("Player2 pickBall: ");
                P2.PickBalls(Game);
                Game.Printgame();
                if (Game.IsgameOver())
                {
                    Console.WriteLine("Player2 lose!");
                    break;
                }
            }
        }
    }
}