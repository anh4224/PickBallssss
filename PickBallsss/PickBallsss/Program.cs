using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBallsss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------StartGame!---------");
            Controller c = new Controller();
            c.PlayGame();
        }
    }
}
