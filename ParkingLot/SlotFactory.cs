using ParkigLot;

namespace ParkingLot
{
    internal class SpotFactory
    {
        internal static ParkingSpot GetParkingSpot(SpotTypeEnum spotTypeEnum, int floorNo)
        {
            ParkingSpot parkingSpot;
            switch (spotTypeEnum)
            {
                case SpotTypeEnum.Small:
                    parkingSpot= new SmallParkingSpot(floorNo);break;
                case SpotTypeEnum.Medium:
                    parkingSpot= new MediumParkingSpot(floorNo);break;
                case SpotTypeEnum.Large:
                    parkingSpot= new LargeParkingSpot(floorNo);break;
                default:
                    parkingSpot= new MediumParkingSpot(floorNo);break;
            }
            
            return parkingSpot;
        }
    }
}
