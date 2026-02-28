namespace GeniusIdiotFormApp
{
    partial class StartMenu
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
            textBox1 = new TextBox();
            StartButton = new Button();
            ListUsersButton = new Button();
            AddRemoveButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("ISOCPEUR", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(252, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "GENIUS or IDIOT";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.Menu;
            StartButton.Font = new Font("ISOCPEUR", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StartButton.ForeColor = SystemColors.ControlText;
            StartButton.Location = new Point(337, 90);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(135, 60);
            StartButton.TabIndex = 1;
            StartButton.Text = "Начать тест";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // ListUsersButton
            // 
            ListUsersButton.BackColor = SystemColors.Menu;
            ListUsersButton.Font = new Font("ISOCPEUR", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListUsersButton.Location = new Point(327, 171);
            ListUsersButton.Name = "ListUsersButton";
            ListUsersButton.Size = new Size(154, 60);
            ListUsersButton.TabIndex = 2;
            ListUsersButton.Text = "Результаты участников";
            ListUsersButton.UseVisualStyleBackColor = false;
            ListUsersButton.Click += ListUsersButton_Click;
            // 
            // AddRemoveButton
            // 
            AddRemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddRemoveButton.BackColor = SystemColors.Menu;
            AddRemoveButton.Font = new Font("ISOCPEUR", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddRemoveButton.Location = new Point(319, 252);
            AddRemoveButton.Name = "AddRemoveButton";
            AddRemoveButton.Size = new Size(171, 56);
            AddRemoveButton.TabIndex = 3;
            AddRemoveButton.Text = "Удалить/Добавить вопрос";
            AddRemoveButton.UseVisualStyleBackColor = false;
            AddRemoveButton.Click += AddRemoveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.Menu;
            ExitButton.Font = new Font("ISOCPEUR", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitButton.Location = new Point(356, 330);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(96, 48);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(AddRemoveButton);
            Controls.Add(ListUsersButton);
            Controls.Add(StartButton);
            Controls.Add(textBox1);
            Name = "StartMenu";
            Text = "StartMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button StartButton;
        private Button ListUsersButton;
        private Button AddRemoveButton;
        private Button ExitButton;
    }
}