namespace program2024
{
    internal class MyConsole
    {
        public static string Ask(string qustion)
        {
            Console.Write(qustion + " ");
            return Console.ReadLine();
        }
        public static int AskForInt(string qustion)
        {

            var answearStr = Ask(qustion);
            return Convert.ToInt32(answearStr);
        }
        public static bool AskForBool(string qustion)
        {

            var answearStr = Ask(qustion + " (y/n)");
            return answearStr.ToLower().StartsWith("y");
        }
    }
}
