using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    internal class FountainPen : Pen,IRefillable
    {
        internal FountainPen(double tipRadius, Color color, IOpenCloseMechanism openCloseMechanism) : base(tipRadius, color, openCloseMechanism)
        {

        }

        public void Refill()
        {
            Console.WriteLine("FountainPen Ink Fill");
        }

    }
}
