namespace NeedForSpeed
{
    class RemoteControlCar
    {
        public int speed;

        public int batteryDrain;

        public int distanceDriven;

        public int batteryRemaining = 100;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }

        public void Drive()
        {
            if (batteryRemaining >= batteryDrain)
            {
                distanceDriven += speed;
                batteryRemaining -= batteryDrain;
            }
        }

        public int DistanceDriven()
        {
            return distanceDriven;
        }

        public bool BatteryDrained()
        {
            return batteryRemaining < 0 || batteryRemaining < batteryDrain;
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }
}
