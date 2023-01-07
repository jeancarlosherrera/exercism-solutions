namespace AnnalynsAttack
{
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
            return lastWeek;
        }

        public int Today()
        {
            return birdsPerDay[5];
        }

        public void IncrementTodaysCount()
        {
            birdsPerDay[5]++;
        }

        public bool HasDayWithoutBirds()
        {
            return Array.Exists(birdsPerDay, day => day == 0);
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int sumOfDays = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                sumOfDays += birdsPerDay[i];
            }
            return sumOfDays;
        }

        public int BusyDays()
        {
            int totalDays = 0;
            foreach (int day in birdsPerDay)
            {
                if (day >= 5) totalDays++;
            }
            return totalDays;
        }
    }
}
