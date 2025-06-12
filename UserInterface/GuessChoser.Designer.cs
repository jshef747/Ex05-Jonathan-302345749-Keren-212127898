namespace BoolPgia
{
    partial class GuessChoser
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
            GuessButton2 = new Button();
            GuessButton4 = new Button();
            GuessButton3 = new Button();
            GuessButton8 = new Button();
            GuessButton7 = new Button();
            GuessButton6 = new Button();
            GuessButton5 = new Button();
            SuspendLayout();
            // 
            // GuessButton
            // 
            GuessButton.BackColor = Color.Chartreuse;
            GuessButton.Location = new Point(22, 12);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(139, 140);
            GuessButton.TabIndex = 0;
            GuessButton.UseVisualStyleBackColor = false;
            GuessButton.Click += GuessButton_Click;
            // 
            // GuessButton2
            // 
            GuessButton2.BackColor = Color.RoyalBlue;
            GuessButton2.Location = new Point(196, 12);
            GuessButton2.Name = "GuessButton2";
            GuessButton2.Size = new Size(139, 140);
            GuessButton2.TabIndex = 1;
            GuessButton2.UseVisualStyleBackColor = false;
            GuessButton2.Click += GuessButton_Click;
            // 
            // GuessButton4
            // 
            GuessButton4.BackColor = Color.DeepPink;
            GuessButton4.Location = new Point(542, 12);
            GuessButton4.Name = "GuessButton4";
            GuessButton4.Size = new Size(139, 140);
            GuessButton4.TabIndex = 3;
            GuessButton4.UseVisualStyleBackColor = false;
            GuessButton4.Click += GuessButton_Click;
            // 
            // GuessButton3
            // 
            GuessButton3.BackColor = Color.Crimson;
            GuessButton3.Location = new Point(368, 12);
            GuessButton3.Name = "GuessButton3";
            GuessButton3.Size = new Size(139, 140);
            GuessButton3.TabIndex = 2;
            GuessButton3.UseVisualStyleBackColor = false;
            GuessButton3.Click += GuessButton_Click;
            // 
            // GuessButton8
            // 
            GuessButton8.BackColor = Color.Purple;
            GuessButton8.Location = new Point(542, 188);
            GuessButton8.Name = "GuessButton8";
            GuessButton8.Size = new Size(139, 140);
            GuessButton8.TabIndex = 7;
            GuessButton8.UseVisualStyleBackColor = false;
            GuessButton8.Click += GuessButton_Click;
            // 
            // GuessButton7
            // 
            GuessButton7.BackColor = Color.LightSeaGreen;
            GuessButton7.Location = new Point(368, 188);
            GuessButton7.Name = "GuessButton7";
            GuessButton7.Size = new Size(139, 140);
            GuessButton7.TabIndex = 6;
            GuessButton7.UseVisualStyleBackColor = false;
            GuessButton7.Click += GuessButton_Click;
            // 
            // GuessButton6
            // 
            GuessButton6.BackColor = Color.LightSkyBlue;
            GuessButton6.Location = new Point(196, 188);
            GuessButton6.Name = "GuessButton6";
            GuessButton6.Size = new Size(139, 140);
            GuessButton6.TabIndex = 5;
            GuessButton6.UseVisualStyleBackColor = false;
            GuessButton6.Click += GuessButton_Click;
            // 
            // GuessButton5
            // 
            GuessButton5.BackColor = Color.Plum;
            GuessButton5.Location = new Point(22, 188);
            GuessButton5.Name = "GuessButton5";
            GuessButton5.Size = new Size(139, 140);
            GuessButton5.TabIndex = 4;
            GuessButton5.UseVisualStyleBackColor = false;
            GuessButton5.Click += GuessButton_Click;
            // 
            // GuessChoser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 350);
            Controls.Add(GuessButton8);
            Controls.Add(GuessButton7);
            Controls.Add(GuessButton6);
            Controls.Add(GuessButton5);
            Controls.Add(GuessButton4);
            Controls.Add(GuessButton3);
            Controls.Add(GuessButton2);
            Controls.Add(GuessButton);
            Name = "GuessChoser";
            Text = "GuessChoser";
            ResumeLayout(false);
        }

        #endregion

        private Button GuessButton;
        private Button GuessButton2;
        private Button GuessButton4;
        private Button GuessButton3;
        private Button GuessButton8;
        private Button GuessButton7;
        private Button GuessButton6;
        private Button GuessButton5;
    }
}