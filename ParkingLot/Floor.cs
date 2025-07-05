using ParkigLot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    internal class Floor
    {
        List<ParkingSpot> _parkingSpots;

        public List<ParkingSpot> ParkingSpots { get { return _parkingSpots; } }
        int _floorNo;
        public Floor(int perFloorSmallSpots,int perFloorMediumSpots,int perFloorLargeSpots,int floorNo=0)
        {
            _floorNo = floorNo;
            _parkingSpots = new List<ParkingSpot>();
            for (int i = 0; i < perFloorSmallSpots; i++) _parkingSpots.Add(SpotFactory.GetParkingSpot(SpotTypeEnum.Small,floorNo));
            for (int i = 0; i < perFloorMediumSpots; i++) _parkingSpots.Add(SpotFactory.GetParkingSpot(SpotTypeEnum.Medium,floorNo));
            for (int i = 0; i < perFloorLargeSpots; i++) _parkingSpots.Add(SpotFactory.GetParkingSpot(SpotTypeEnum.Large, floorNo));

        }
    }
}
