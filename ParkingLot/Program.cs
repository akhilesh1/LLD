using ParkingLot;
using System.Drawing;

namespace ParkigLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingLotSystem parkingLotSystem = ParkingLotSystem.GetInstance();
            parkingLotSystem.Setup(1, 3, 60, 50, 20);
            Ticket t = parkingLotSystem.GetTicket("UP32MQ2249", Color.White, SpotTypeEnum.Medium, new NearestSpotStratagy());
            if (t != null)
                Console.WriteLine("\nGot Spot Successfully"); Console.WriteLine(t.ToString());

            Ticket t2 = parkingLotSystem.GetTicket("HR26DD9313", Color.Green, SpotTypeEnum.Small,new NearestSpotStratagy());
            if (t2 != null)
                Console.WriteLine("\nGot Spot Successfully"); Console.WriteLine(t2.ToString());
        }
    }
}
