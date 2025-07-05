using ParkigLot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{

    public abstract class SpotFetchStratagy
    {
        internal abstract ParkingSpot GetSpot(SpotTypeEnum spotTypeEnum, PriorityQueue<ParkigLot.ParkingSpot, int> parkingSpotQueueSmall, PriorityQueue<ParkigLot.ParkingSpot, int> parkingSpotQueueMedium, PriorityQueue<ParkigLot.ParkingSpot, int> parkingSpotQueueLarge, List<Floor> floors);
    }

    public class NearestSpotStratagy : SpotFetchStratagy
    {
        internal override ParkingSpot GetSpot(SpotTypeEnum spotTypeEnum, PriorityQueue<ParkingSpot, int> parkingSpotQueueSmall, PriorityQueue<ParkingSpot, int> parkingSpotQueueMedium, PriorityQueue<ParkingSpot, int> parkingSpotQueueLarge, List<Floor> floors)
        {
            ParkingSpot parkingSpot = null;
            if (spotTypeEnum == SpotTypeEnum.Large && parkingSpotQueueLarge.Count > 0)
                parkingSpot = parkingSpotQueueLarge.Dequeue();
            if (spotTypeEnum == SpotTypeEnum.Medium)
            {
                if (parkingSpotQueueMedium.Count > 0)
                    parkingSpot = parkingSpotQueueMedium.Dequeue();
                else if (parkingSpotQueueLarge.Count > 0)
                    parkingSpot = parkingSpotQueueLarge.Dequeue();
            }
            if (spotTypeEnum == SpotTypeEnum.Small)
            {
                if (parkingSpotQueueSmall.Count > 0)
                    parkingSpot = parkingSpotQueueSmall.Dequeue();
                else if (parkingSpotQueueMedium.Count > 0)
                    parkingSpot = parkingSpotQueueMedium.Dequeue();
                else if (parkingSpotQueueLarge.Count > 0)
                    parkingSpot = parkingSpotQueueLarge.Dequeue();
            }
            if (parkingSpot == null)
                throw new Exception($"No spot found for {spotTypeEnum}");
            return parkingSpot;
        }
    }

    public class RandomSpotStratagy : SpotFetchStratagy
    {
        internal override ParkingSpot GetSpot(SpotTypeEnum spotTypeEnum, PriorityQueue<ParkingSpot, int> parkingSpotQueueSmall, PriorityQueue<ParkingSpot, int> parkingSpotQueueMedium, PriorityQueue<ParkingSpot, int> parkingSpotQueueLarge, List<Floor> floors)
        {
            ParkingSpot parkingSpot = null;
            //foreach (var floor in floors)
            //{
            //    if (spotTypeEnum == SpotTypeEnum.Large && floor.ParkingSpots.Exists(s=>s is LargeParkingSpot))
            //        parkingSpot = floor.ParkingSpots.Where(s => s is LargeParkingSpot).FirstOrDefault();
            //    if (spotTypeEnum == SpotTypeEnum.Medium)
            //    {
            //        if (floor.ParkingSpots.Exists(s => s is MediumParkingSpot))
            //            parkingSpot = floor.ParkingSpots.Where(s => s is MediumParkingSpot).FirstOrDefault(); 
            //        else if (floor.ParkingSpots.Exists(s => s is LargeParkingSpot))
            //            parkingSpot = floor.ParkingSpots.Where(s => s is LargeParkingSpot).FirstOrDefault();
            //    }
            //    if (spotTypeEnum == SpotTypeEnum.Small)
            //    {
            //        if (parkingSpotQueueSmall.Count > 0)
            //            parkingSpot = parkingSpotQueueSmall.Dequeue();
            //        else if (parkingSpotQueueMedium.Count > 0)
            //            parkingSpot = parkingSpotQueueMedium.Dequeue();
            //        else if (parkingSpotQueueLarge.Count > 0)
            //            parkingSpot = parkingSpotQueueLarge.Dequeue();
            //    }
            //    if (parkingSpot == null)
            //        throw new Exception($"No spot found for {spotTypeEnum}");
            return parkingSpot;
        }
    }
}
