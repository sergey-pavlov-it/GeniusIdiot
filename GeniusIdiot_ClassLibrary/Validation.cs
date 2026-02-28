namespace GeniusIdiot.Validation
{
    public static class InputValidation
    {
        public static bool TryParseIndex(string input, out int value)
        {
            value = 0;

            if (input == null) return false;

            input = input.Trim();
            if (input.Length == 0) return false;

            if (!int.TryParse(input, out value)) return false;

            return value > 0;
        }
    }

    public static class QuestionValidation
    {
        public static bool TryParseNewQuestion(string text, string answer, out string validText, out int validAnswer, out string error)
        {
            validText = "";
            validAnswer = -1;
            error = "";

            text = (text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(text) || text.Contains(';') || text.Contains('\n') || text.Contains('\r'))
            {
                error = "Некорректный текст вопроса (пусто, символ ;, перенос строки).";
                return false;
            }

            if (!int.TryParse((answer ?? "").Trim(), out validAnswer))
            {
                error = "Ответ должен быть числом.";
                return false;
            }

            validText = text;
            return true;
        }
    }
}
