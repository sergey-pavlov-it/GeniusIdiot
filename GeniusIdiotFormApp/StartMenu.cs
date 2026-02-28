using GeniusIdiot.Application;
using GeniusIdiot.Domain;
using GeniusIdiot.Infrastructure;

namespace GeniusIdiotFormApp
{
    public partial class StartMenu : Form
    {
        QuizEngine startTest = new QuizEngine(); // для старта теста
        QuestionsRepository questionsRepository = new QuestionsRepository(); // для оперирования репозиторием вопросов
        UserResultRepository resultRepo = new UserResultRepository(); // для оперирования сохранением/чтением результатов
        DiagnosisCalculator resultDiagnose = new DiagnosisCalculator(); // для получения диагноза

        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var userName = PromptName("Начать тест", "Введите имя:");
            if (string.IsNullOrWhiteSpace(userName))
                return;

            User currentUser = new User(userName);

            var startTest = new StartTest(currentUser, questionsRepository, resultRepo, resultDiagnose);
            startTest.FormClosed += (s, args) => this.Show();
            startTest.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRemoveButton_Click(object sender, EventArgs e)
        {
            var addDeleteQuestions = new AddDeleteQuestions(questionsRepository, resultRepo, resultDiagnose);
            addDeleteQuestions.FormClosed += (s, args) => this.Show();
            addDeleteQuestions.Show();
            this.Hide();
        }

        private static string? PromptName(string title, string message)
        {
            using var form = new Form
            {
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                Width = 360,
                Height = 160
            };

            var label = new Label { Left = 12, Top = 12, Width = 320, Text = message };
            var textBox = new TextBox { Left = 12, Top = 40, Width = 320 };
            var ok = new Button { Text = "OK", Left = 176, Width = 75, Top = 75, DialogResult = DialogResult.OK };
            var cancel = new Button { Text = "Отмена", Left = 257, Width = 75, Top = 75, DialogResult = DialogResult.Cancel };

            form.Controls.AddRange(new Control[] { label, textBox, ok, cancel });
            form.AcceptButton = ok;
            form.CancelButton = cancel;

            return form.ShowDialog() == DialogResult.OK
                ? textBox.Text.Trim()
                : null;
        }

        private void ListUsersButton_Click(object sender, EventArgs e)
        {
            var arrayUserResult = resultRepo.GetArrayResult()
                .TakeLast(10)
                .Select(raw =>
                {
                    var parts = raw.Split(';');

                    var name = parts[0].Trim();
                    var score = parts[1].Trim();
                    var diagnos = parts[2].Trim();

                    return $"{name}: {score} - {diagnos}";
                });
            
            MessageBox.Show(this, string.Join(Environment.NewLine, arrayUserResult), "Последние 10 результатов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
