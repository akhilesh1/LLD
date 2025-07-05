using ParkigLot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public enum SpotTypeEnum
    {
        Small,
        Medium,
        Large
    }

    
    internal class ParkingLotSystem
    {
        private static ParkingLotSystem system;
        private static readonly object lockObject = new object();
        private List<Floor> floors;

        private List<Gate> gates;

        private PriorityQueue<ParkingSpot,int> parkingSpotQueueSmall;
        private PriorityQueue<ParkingSpot,int> parkingSpotQueueMedium;
        private PriorityQueue<ParkingSpot,int> parkingSpotQueueLarge;
        private Dictionary<string, ParkingSpot> parkedNumbers;
        
        private ParkingLotSystem() 
        {
            parkingSpotQueueSmall = new PriorityQueue<ParkingSpot,int>();
            parkingSpotQueueMedium = new PriorityQueue<ParkingSpot,int>();
            parkingSpotQueueLarge = new PriorityQueue<ParkingSpot,int>();
            floors=new List<Floor>();
            gates=new List<Gate>();
        }
        public static ParkingLotSystem GetInstance()
        {
            if (system == null)
            {
                lock (lockObject)
                {
                    if (system == null)
                    {
                        system = new ParkingLotSystem();
                    }
                }
            }
            return system;
        }

        public void Setup(int gateCount, int floorCount,int perFloorSmallSpots,int perFloorMediumSpots,int perFloorLargeSpots)
        {
            for (int i = 0; i < gateCount; i++)
            {
                gates.Add(new Gate());
            }
            for (int i = 0; i < floorCount; i++)
            {
                var floor = new Floor(perFloorSmallSpots, perFloorMediumSpots, perFloorLargeSpots, i);
                floors.Add(floor);
                foreach (var spot in floor.ParkingSpots)
                {
                    if(spot is SmallParkingSpot)
                        parkingSpotQueueSmall.Enqueue(spot, spot.Distance);
                    if (spot is MediumParkingSpot)
                        parkingSpotQueueMedium.Enqueue(spot, spot.Distance);
                    if (spot is LargeParkingSpot)
                        parkingSpotQueueLarge.Enqueue(spot, spot.Distance);
                }
            }
        }

     
        public Ticket GetTicket(string LicensePlateNo, Color color, SpotTypeEnum spotTypeEnum,SpotFetchStratagy spotFetchStratagy )
        {

            var  parkingSpot=spotFetchStratagy.GetSpot(spotTypeEnum, parkingSpotQueueSmall, parkingSpotQueueMedium, parkingSpotQueueLarge, floors);
            if (parkingSpot == null)
                throw new Exception($"No spot found for {spotTypeEnum}");

            Ticket ticket = new(LicensePlateNo, color)
            {
                Spot = parkingSpot
            };
            parkedNumbers.Add(LicensePlateNo,parkingSpot);
            return ticket;
            
        }

       



    }
}
