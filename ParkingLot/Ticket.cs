using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkigLot
{
    internal class Ticket
    {
        public  int ID { get; set; }
        public ParkingSlot Slot { get; set; }
        public DateTime StartTime { get; set; }

    }
}
