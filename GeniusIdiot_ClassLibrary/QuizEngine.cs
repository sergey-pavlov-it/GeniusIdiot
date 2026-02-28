using GeniusIdiot.Domain;

namespace GeniusIdiot.Application
{
    public class QuizEngine
    {
        public int Run(List<Question> questions)
        {
            Question[] shuffled = questions.ToArray();
            Random.Shared.Shuffle(shuffled);
            
            int correctAnswers = 0;

            for (int i = 0; i < shuffled.Length; i++)
            {
                Console.WriteLine($"Вопрос №{i + 1}\n{shuffled[i].Text}");
                int userAnswer = CheckInputAnswer();
                if (userAnswer == shuffled[i].Answer)
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }

        private static int CheckInputAnswer()
        {
            while (true)
            {
                string input = (Console.ReadLine() ?? "").Trim();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }

                Console.WriteLine("Некорректный ввод. Введите целое число.");
            }
        }
    }
}
