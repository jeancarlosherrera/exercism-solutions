namespace AnnalynsAttack
{
    internal class AssemblyLine
    {

        public static double SuccessRate(int rate)
        {
            return rate == 0 ? 0 : rate == 1 || rate == 2 || rate == 3 || rate == 4 ? 1
                : rate == 5 || rate == 6 || rate == 7 || rate == 8 ? 0.9 : rate == 9 ? 0.8: 0.77; 
        }

        public static double ProductionRatePerHour(int hours)
        {
            return SuccessRate(hours) * hours * 221;
        }

        public static int WorkingItemsPerMinute(int hours)
        {
            return (int)ProductionRatePerHour(hours) / 60;
        }

    }
}
