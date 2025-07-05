using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkigLot
{
    internal class Ticket
    {
        public Guid ID { get; set; }
        public string LicensePlate { get; set; }
        public ParkingSpot Spot { get; set; }
        public DateTime StartTime { get; set; }

        public Color Color { get; set; }
        public Ticket(string licensePlate,Color color)
        {
            Color = color;
            LicensePlate = licensePlate;
            ID = Guid.NewGuid();
            StartTime = DateTime.Now;
        }
        public override string ToString()
        {
            return $"\nColour: {Color}\n License Plate: {this.LicensePlate}\n TicketID: {this.ID}\n StartTime: {this.StartTime}\n SpotID: {this.Spot.ID}\n SpotDistance: {this.Spot.Distance}";
        }

    }
}
