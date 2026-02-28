using GeniusIdiot.Domain;

namespace GeniusIdiot.Infrastructure
{
    public class QuestionsRepository
    {
        private readonly string _path;
        private readonly FileService _fileService;
        public List<Question> Questions { get; private set; }

        public QuestionsRepository()
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GeniusIdiot");
            Directory.CreateDirectory(dir);

            _path = Path.Combine(dir, "questions.csv");
            _fileService = new FileService();
            Questions = new List<Question>();
            _fileService.EnsureFileExists(_path);
            LoadFromFile();
        }

        public void LoadFromFile()
        {
            Questions.Clear();
            string[] lines = _fileService.ReadLines(_path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }
                else
                {
                    string[] line = lines[i].Split(';');
                    if (line.Length < 2)
                        continue;
                    if (!int.TryParse(line[1], out int answer))
                        continue;
                    Questions.Add(new Question(line[0], answer));
                }
            }
        }

        public void AddQuestion(string text, int answer)
        {
            Questions.Add(new Question(text, answer));
            _fileService.AppendLine(_path, $"{text};{answer}");
        }

        public bool DeleteQuestion(int indexDelete, out string error)
        {
            error = "";

            if (indexDelete < 1 || indexDelete > Questions.Count)
            {
                error = "Вопроса с таким номером не существует";
                return false;
            }

            Questions.RemoveAt(indexDelete - 1);

            List<string> lines = new List<string>();
            foreach (Question question in Questions)
            {
                lines.Add($"{question.Text};{question.Answer}");
            }

            _fileService.OverwriteFile(_path, lines);
            return true;
        }
    }
}