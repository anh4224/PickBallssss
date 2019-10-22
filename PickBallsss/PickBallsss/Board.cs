﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBallsss
{
    class Board
    {
        private int G1, G2, G3;

        public Board(int g1, int g2, int g3)
        {
            this.G1 = g1;
            this.G2 = g2;
            this.G3 = g3;

        }
        public void Pickball(int g, int b)
        {
            if (g == 1)
                G1 -= b;
            else if (g == 2) 
                G2 -= b;
            else 
                G3 -= b;
        }
        public void Printgame()
        {
            Console.Write("Group 1: ");
            for (int i = 0; i < G1; i++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();
            Console.Write("Group 2: ");
            for (int i = 0; i < G2; i++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine(); 

            Console.Write("Group 3: ");
            for (int i = 0; i < G3; i++)
            {
               Console.Write("0 ");
            }
            Console.WriteLine();
        }

        public  bool IsgameOver()
        {
            return (G1 == 0 && G2 == 0 && G3 == 0);
        }

    }
}   
