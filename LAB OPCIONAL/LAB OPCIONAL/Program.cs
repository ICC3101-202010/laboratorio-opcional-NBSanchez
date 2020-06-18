using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_OPCIONAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BattleShip!";
            Console.WriteLine("Welcome to Battleship!\r\n\r\n");
            Console.WriteLine("What is your name player 1?");
            string player1 = System.Console.ReadLine();
            //Console.WriteLine("What is your name player 2?");
            //string player2 = System.Console.ReadLine();
            Console.WriteLine();
            Tablero b = new Tablero();
            //Tablero b1 =new Tablero();
            Jugador p = new Jugador();
            p.Randomize();
            //Jugador p1 = new Jugador();
            while (p.getHitCount() < 15)
            {
                Console.WriteLine("TABLERO JUGADOR: " + player1);
                b.DisplayBoard(p.GetGrid());
                p.AskCoordinates();
            }
            Console.WriteLine("Congratulations, " + player1 + "! You Win!\r\n");
            Console.WriteLine("You missed: " + p.getMissCount() + " times\r\n");
            Console.WriteLine("Thanks for playing BerdShip. Press enter to quit.");
            System.Console.ReadLine();

            //while(p1.getHitCount() < 10)
            {
                //Console.WriteLine("TABLERO JUGADOR: " + player2);
                //b1.DisplayBoard(p1.GetGrid());
                //p1.AskCoordinates();
            }


            //if (p1.getHitCount() > 10 && p.getHitCount() < 10)
            {
                //Console.WriteLine("Congratulations, " + player1 + "! You Win!\r\n");
                //Console.WriteLine("You missed: " + p.getMissCount() + " times\r\n");
                //Console.WriteLine("Thanks for playing BattleShip. Press enter to quit.");
                //System.Console.ReadLine();
            }
            //else
            {
               // Console.WriteLine("Congratulations, " + player2 + "! You Win!\r\n");
                //Console.WriteLine("You missed: " + p.getMissCount() + " times\r\n");
                //Console.WriteLine("Thanks for playing BattleShip. Press enter to quit.");
                //System.Console.ReadLine();
            }

           
        }
    }
    
}
