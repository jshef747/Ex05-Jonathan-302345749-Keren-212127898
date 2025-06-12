namespace BoolPgia
{
    partial class StartScreen
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
            GuessButton = new Button();
            StartButton = new Button();
            SuspendLayout();
            // 
            // GuessButton
            // 
            GuessButton.Location = new Point(79, 40);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(561, 65);
            GuessButton.TabIndex = 0;
            GuessButton.Text = "Number of guesses : 4";
            GuessButton.UseVisualStyleBackColor = true;
            GuessButton.Click += GuessButton_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.LightGreen;
            StartButton.Location = new Point(442, 252);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(198, 59);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 403);
            Controls.Add(StartButton);
            Controls.Add(GuessButton);
            Name = "StartScreen";
            Text = "StartScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button GuessButton;
        private Button StartButton;
    }
}