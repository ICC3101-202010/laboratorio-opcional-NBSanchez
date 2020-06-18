using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_OPCIONAL
{
    class Ships
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Width;
            }
        }

        public virtual void MoveShip(string direction)
        {

        }

    }
}
