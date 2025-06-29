using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    internal class BallPen:Pen,IRefillable
    {
        internal BallPen(double tipRadius, Color color, IOpenCloseMechanism openCloseMechanism) : base(tipRadius, color, openCloseMechanism)
        {

        }

        public void Refill()
        {
            Console.WriteLine("Ballpen refill changed");
        }

    }
}
