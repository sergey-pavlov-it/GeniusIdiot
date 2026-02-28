using GeniusIdiot.Infrastructure;
using GeniusIdiot.Application;
using GeniusIdiot.Validation;

namespace GeniusIdiotFormApp
{
    public partial class AddDeleteQuestions : Form
    {
        private readonly QuestionsRepository _questionsRepo;
        private readonly UserResultRepository _userResultRepo;
        private readonly DiagnosisCalculator _diagnoseCalculator;

        public AddDeleteQuestions(QuestionsRepository questionsRepo, UserResultRepository userResultRepo, DiagnosisCalculator diagnoseResult)
        {
            InitializeComponent();
            _questionsRepo = questionsRepo;
            _userResultRepo = userResultRepo;
            _diagnoseCalculator = diagnoseResult;
        }

        private void AddDeleteQuestions_Load(object sender, EventArgs e)
        {
            RefreshQuestionsList();
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshQuestionsList()
        {
            listBoxQuestions.Items.Clear();
            foreach (var q in _questionsRepo.Questions)
                listBoxQuestions.Items.Add(q);
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            int indexDelete = listBoxQuestions.SelectedIndex + 1;
            bool deleteQuuestion = _questionsRepo.DeleteQuestion(indexDelete, out string error);
            RefreshQuestionsList();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            bool addQuestion = QuestionValidation.TryParseNewQuestion(QuestionTextBox.Text, AnswerTextBox.Text, out string validText, out int validAnswer, out string error);
            if (addQuestion)
            {
                _questionsRepo.AddQuestion(validText, validAnswer);
                RefreshQuestionsList();
                QuestionTextBox.Text = "";
                AnswerTextBox.Text = "";
            }
            else
            {
                MessageBox.Show(this, error);
            }
        }
    }
}
