using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_OPCIONAL
{
    class Portaaviones : Ships
    {
        
        public override void MoveShip(string direction)
        {
            if (direction == "+")
            {

            }
        }
        public Portaaviones()
        {
            Name = "Portaaviones";
            Width = 5;
        }

    }
}
