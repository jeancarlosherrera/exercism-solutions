namespace AnnalynsAttack
{
    class Appointment
    {

        public Appointment()
        {

        }

        public static DateTime Schedule(string dateTime)
        {
            return DateTime.Parse(dateTime);
        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            var result = DateTime.Compare(appointmentDate, DateTime.Now);
            return result < 0;
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            return appointmentDate.Hour >= 12;
        }

        public static string Description(DateTime appointmentDate)
        {
            return $"You have an appointment on {appointmentDate:G}.";
        }

        public static DateTime AnniversaryDate()
        {
            return DateTime.Now.AddYears(1);
        }
    }
}
