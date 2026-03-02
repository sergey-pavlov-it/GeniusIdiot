namespace GeniusIdiot.Infrastructure
{
    public class UserResultRepository
    {
        private readonly string _path;
        private readonly FileService _fileService;

        public UserResultRepository()
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GeniusIdiot");
            Directory.CreateDirectory(dir);

            _path = Path.Combine(dir, "userResult.csv");
            _fileService = new FileService();

            _fileService.EnsureFileExists(_path);
        }

        public void SaveResult(string userName, int correctAnswers, string userDiagnos)
        {
            string text = $"{userName};{correctAnswers};{userDiagnos}";
            _fileService.AppendLine(_path, text);
        }

        public string[] GetArrayResult()
        {
            return _fileService.ReadLines(_path);
        }
    }
}
