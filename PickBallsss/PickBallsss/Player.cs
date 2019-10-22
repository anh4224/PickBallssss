using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBallsss
{
    class Player
    {
        private string Name;

        public Player(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void PickBalls(Board game)
        {
            Console.WriteLine("Which gruop do you choose?:");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("How ball do you pick?:");
            int b = int.Parse(Console.ReadLine());
            game.Pickball(g, b);
            Console.WriteLine();
        }
    }
}
