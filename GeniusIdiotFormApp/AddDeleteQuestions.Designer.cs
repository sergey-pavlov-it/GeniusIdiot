namespace GeniusIdiotFormApp
{
    partial class AddDeleteQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxQuestions = new ListBox();
            DeleteQuestionButton = new Button();
            QuestionTextBox = new TextBox();
            TextLabel2 = new Label();
            TextLabel1 = new Label();
            AnswerTextBox = new TextBox();
            AddQuestionButton = new Button();
            SuspendLayout();
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.Location = new Point(12, 50);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(776, 154);
            listBoxQuestions.TabIndex = 0;
            listBoxQuestions.SelectedIndexChanged += listBoxQuestions_SelectedIndexChanged;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteQuestionButton.ForeColor = SystemColors.ControlText;
            DeleteQuestionButton.Location = new Point(12, 208);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(776, 34);
            DeleteQuestionButton.TabIndex = 1;
            DeleteQuestionButton.Text = "Удалить вопрос";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuestionTextBox.ForeColor = SystemColors.MenuText;
            QuestionTextBox.Location = new Point(12, 312);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.PlaceholderText = "Введите вопрос";
            QuestionTextBox.Size = new Size(776, 27);
            QuestionTextBox.TabIndex = 2;
            QuestionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TextLabel2
            // 
            TextLabel2.AutoSize = true;
            TextLabel2.Font = new Font("ISOCPEUR", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextLabel2.ForeColor = SystemColors.ControlText;
            TextLabel2.Location = new Point(318, 268);
            TextLabel2.Name = "TextLabel2";
            TextLabel2.Size = new Size(201, 34);
            TextLabel2.TabIndex = 3;
            TextLabel2.Text = "Добавить вопрос";
            // 
            // TextLabel1
            // 
            TextLabel1.AutoSize = true;
            TextLabel1.Font = new Font("ISOCPEUR", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextLabel1.ForeColor = SystemColors.ControlText;
            TextLabel1.Location = new Point(318, 9);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(187, 34);
            TextLabel1.TabIndex = 4;
            TextLabel1.Text = "Удалить вопрос";
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AnswerTextBox.Location = new Point(12, 345);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.PlaceholderText = "Введите ответ (число)";
            AnswerTextBox.Size = new Size(776, 27);
            AnswerTextBox.TabIndex = 5;
            AnswerTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddQuestionButton.ForeColor = SystemColors.ControlText;
            AddQuestionButton.Location = new Point(12, 378);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(776, 32);
            AddQuestionButton.TabIndex = 6;
            AddQuestionButton.Text = "Добавить вопрос";
            AddQuestionButton.UseVisualStyleBackColor = true;
            AddQuestionButton.Click += AddQuestionButton_Click;
            // 
            // AddDeleteQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(AddQuestionButton);
            Controls.Add(AnswerTextBox);
            Controls.Add(TextLabel1);
            Controls.Add(TextLabel2);
            Controls.Add(QuestionTextBox);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(listBoxQuestions);
            ForeColor = SystemColors.GrayText;
            Name = "AddDeleteQuestions";
            Text = "AddDeleteQuestionsForm";
            Load += AddDeleteQuestions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxQuestions;
        private Button DeleteQuestionButton;
        private TextBox QuestionTextBox;
        private Label TextLabel2;
        private Label TextLabel1;
        private TextBox AnswerTextBox;
        private Button AddQuestionButton;
    }
}