namespace GeniusIdiot.Application
{
    public class DiagnosisCalculator
    {
        public string CalculateDiagnosis(int correctAnswers, int totalQuestions)
        {
            var indexDiagnos = GetDiagnosisIndex(correctAnswers, totalQuestions);
            return GetDiagnosis(indexDiagnos);
        }
                    
        public string GetDiagnosis(int diagnosisIndex)
        {
            string[] diagnosis = new string[6]
            {
                "идиот",
                "кретин",
                "дурак",
                "нормальный",
                "талант",
                "гений"
            };
            return diagnosis[diagnosisIndex];
        }

        public int GetDiagnosisIndex(int correctAnswers, int totalQuestions)
        {
            int result = (int)Math.Floor(correctAnswers * 5.0 / totalQuestions);
            return result;
        }
    }
}
