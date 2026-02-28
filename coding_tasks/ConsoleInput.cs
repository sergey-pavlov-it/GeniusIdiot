namespace GeniusIdiotConsoleApp.UI
{
    public static class ConsoleInput
    {
        public static string ReadTrimmedLine()
        {
            string userInput = (Console.ReadLine() ?? "").Trim();
            return userInput;
        }

        public static bool ReadYesNo(string prompt)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                string answer = ReadTrimmedLine().ToLowerInvariant();
                if (answer == "да") return true;
                if (answer == "нет") return false;
                Console.WriteLine("Не понял ответа, повторите (да/нет)");
            }
        }
    }
}
