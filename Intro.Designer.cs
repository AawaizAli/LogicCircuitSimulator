namespace WinFormsApp2
{
    partial class Intro
    {
        private System.ComponentModel.IContainer components = null;
        private Button Enter;

        private void InitializeComponent()
        {
            Enter = new Button();
            INTRO = new Label();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.BackColor = SystemColors.Highlight;
            Enter.BackgroundImageLayout = ImageLayout.Zoom;
            Enter.Location = new Point(117, 148);
            Enter.Name = "Enter";
            Enter.Size = new Size(107, 46);
            Enter.TabIndex = 0;
            Enter.Text = "Start";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click_1;
            // 
            // INTRO
            // 
            INTRO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            INTRO.AutoSize = true;
            INTRO.Location = new Point(12, 70);
            INTRO.MaximumSize = new Size(0, 100);
            INTRO.Name = "INTRO";
            INTRO.Size = new Size(307, 60);
            INTRO.TabIndex = 1;
            INTRO.Text = "Welcome to LogicSim! \r\n\r\n\r\nYour tool for learning and practicing digital logic circuits.";
            INTRO.TextAlign = ContentAlignment.MiddleCenter;
            INTRO.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 250);
            Controls.Add(INTRO);
            Controls.Add(Enter);
            Name = "Form1";
            Text = "Page1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label INTRO;
    }
}
