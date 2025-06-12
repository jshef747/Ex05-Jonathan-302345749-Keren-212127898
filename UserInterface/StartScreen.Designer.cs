namespace UserInterface
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
            GuessButtom = new Button();
            StartButtom = new Button();
            SuspendLayout();
            // 
            // GuessButtom
            // 
            GuessButtom.Location = new Point(79, 40);
            GuessButtom.Name = "GuessButtom";
            GuessButtom.Size = new Size(561, 65);
            GuessButtom.TabIndex = 0;
            GuessButtom.Text = "Number of guesses : 4";
            GuessButtom.UseVisualStyleBackColor = true;
            GuessButtom.Click += GuessButtom_Click;
            // 
            // StartButtom
            // 
            StartButtom.BackColor = Color.LightGreen;
            StartButtom.Location = new Point(442, 252);
            StartButtom.Name = "StartButtom";
            StartButtom.Size = new Size(198, 59);
            StartButtom.TabIndex = 1;
            StartButtom.Text = "Start";
            StartButtom.UseVisualStyleBackColor = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 403);
            Controls.Add(StartButtom);
            Controls.Add(GuessButtom);
            Name = "StartScreen";
            Text = "StartScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button GuessButtom;
        private Button StartButtom;
    }
}