namespace NeedForSpeed
{
    class RaceTrack
    {
        private int distance;

        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            return ((double)distance / car.speed) * car.batteryDrain <= 100;
        }
    }
}
