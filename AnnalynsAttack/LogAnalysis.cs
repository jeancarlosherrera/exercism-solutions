namespace AnnalynsAttack
{
    public static class LogAnalysis
    {
        public static string SubstringAfter(this string str, string input)
        {
            return str.Split(input)[1];
        }

        public static string SubstringBetween(this string str, string firstChar, string secondChar)
        {
            str = str.Split(firstChar)[1];
            return str.Split(secondChar)[0];
        }

        public static string Message(this string str)
        {
            return str.SubstringAfter(":").Trim();
        }

        public static string LogLevel(this string str)
        {
            return str.SubstringBetween("[", "]");
        }
    }
}
