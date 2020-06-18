using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_OPCIONAL
{
    class Jugador
    {
        char[,] Grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        int x = 0;
        int y = 0;

        public int getHitCount()
        {
            return HitCount;
        }
        public int getMissCount()
        {
            return MissCount;
        }
        public void AskCoordinates()
        {
            Console.WriteLine("Enter X");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                x = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            Console.WriteLine("Enter Y");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                y = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            try
            {
                if (Grid[x, y].Equals('R') || Grid[x, y].Equals('D')|| Grid[x, y].Equals('S')|| Grid[x, y].Equals('F')|| Grid[x, y].Equals('P'))
                {
                    Grid[x, y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    HitCount += 1;
                }
                else
                {
                    Grid[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    MissCount += 1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Please enter numbers between 0 and 9. (Inclusive)");
            }
        }
        public char[,] GetGrid()
        {
            return Grid;
        }
        public void SetGridRad(int q, int w)
        {
            Grid[q, w] = 'R';
        }
        public void SetGridRep(int q, int w)
        {
            Grid[q, w] = 'D';
        }
        public void SetGridSub(int q, int w)
        {
            Grid[q, w] = 'S';
        }
        public void SetGridFra(int q, int w)
        {
            Grid[q, w] = 'F';
        }
        public void SetGridPor(int q, int w)
        {
            Grid[q, w] = 'P';
        }
        public void Randomize()
        {

            Random random = new Random();
            // 1 of length 1
            SetGridRad(1,1);
            //1 of length 2

            SetGridRep(2,2);
            SetGridRep(2,3);
            //1 of length 3
            SetGridSub(3,5);
            SetGridSub(3,6);
            SetGridSub(3,7);
           
            //1 of length 4
            SetGridFra(2,8);
            SetGridFra(3,8);
            SetGridFra(4,8);
            SetGridFra(5,8);
            //1 of length 5
            SetGridPor(9,4);
            SetGridPor(9,5);
            SetGridPor(9,6);
            SetGridPor(9,7);
            SetGridPor(9,8);
        }


    }
}

