using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    internal abstract class Pen
    {
        private double _tipRadiusMM;
        private Color _colour;
        private IOpenCloseMechanism _openCloseMechanism;
        internal Pen(double tipRadius, Color color, IOpenCloseMechanism openCloseMechanism)
        {
            _tipRadiusMM = tipRadius;
            _colour = color;
            _openCloseMechanism = openCloseMechanism;
        }
        public string Write()
        {
            return $"Pen is writing in colour {_colour} with precision {_tipRadiusMM}";
        }

        public void Open()
        {
            _openCloseMechanism.Open();
        }
        public void Close()
        {
            _openCloseMechanism.Close();
        }
    }
}
