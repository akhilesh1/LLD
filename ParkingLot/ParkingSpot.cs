namespace ParkigLot
{
    abstract public class ParkingSpot
    {

        private bool _isReserved;
        private int _distanceFromGate;
        private Guid _id;

        public bool IsReserved { get { return _isReserved; } }
        public int Distance { get { return _distanceFromGate; } }
        public Guid ID { get { return _id; } }
        protected ParkingSpot(int floor)
        {
            _distanceFromGate = new Random().Next(1, 100) + 10 * floor;
            _id = Guid.NewGuid();
        }

        bool Book()
        {
            lock (this)
            {
                if (!_isReserved)
                {
                    _isReserved = true;
                    return true;
                }
            }
            return false;
        }

        void Free()
        {
            _isReserved = false;
        }

    }
}