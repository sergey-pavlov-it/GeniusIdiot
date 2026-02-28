using GeniusIdiot.Application;
using GeniusIdiot.Domain;
using GeniusIdiot.Infrastructure;

namespace GeniusIdiotFormApp
{
    public partial class StartTest : Form
    {
        private readonly QuestionsRepository _questionsRepo;
        private readonly UserResultRepository _userResultRepo;
        private readonly DiagnosisCalculator _diagnoseCalculator;
        private int _currentIndex = 0;
        private List<Question> _questions = new List<Question>();
        private int _correctAnswers = 0;
        private readonly string _userName;

        public StartTest(User userName, QuestionsRepository questionsRepo, UserResultRepository userResultRepo, DiagnosisCalculator diagnoseResult)
        {
            InitializeComponent();
            _userName = userName.Name;
            _questionsRepo = questionsRepo;
            _userResultRepo = userResultRepo;
            _diagnoseCalculator = diagnoseResult;

        }

        private void AnswerUserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartTest_Load(object sender, EventArgs e)
        {
            _currentIndex = 0;

            var arr = _questionsRepo.Questions.ToArray();
            Random.Shared.Shuffle(arr);
            _questions = arr.ToList();

            ShowQuestion();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            string userAnswer = AnswerUserTextBox.Text.Trim();
            if (!int.TryParse(userAnswer, out int userNumber))
            {
                MessageBox.Show("Нужно ввести число.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                AnswerUserTextBox.Focus();
                AnswerUserTextBox.SelectAll();
                return;
            }

            if (userNumber == _questions[_currentIndex].Answer)
            {
                _correctAnswers++;
            }

            _currentIndex++;
            AnswerUserTextBox.Text = "";
            AnswerUserTextBox.Focus();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (_questions.Count == 0)
            {
                QuestionsLabel.Text = "В репозитории нет вопросов";
                return;
            }

            if (_currentIndex >= _questions.Count)
            {
                FinishQuiz();
            }
            else
            {
                QuestionsLabel.Text = $"Вопрос №{_currentIndex + 1}";
                TextQuestionsLable.Text = _questions[_currentIndex].Text;
            }
        }

        private void FinishQuiz()
        {
            string userDiagnose = _diagnoseCalculator.CalculateDiagnosis(_correctAnswers, _questionsRepo.Questions.Count);
            MessageBox.Show($"Кол-во верных ответов: {_correctAnswers}\nВаш диагноз: {userDiagnose}");
            _userResultRepo.SaveResult(_userName, _correctAnswers, userDiagnose);
            this.Close();
        }
    }
}
