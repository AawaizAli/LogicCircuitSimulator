namespace WinFormsApp2
{
    partial class Form2
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
            Design = new Button();
            Tutorial = new Button();
            TestMode = new Button();
            GateExplainer = new Button();
            CircuitsSaved = new Button();
            button6 = new Button();
            Progress = new Button();
            SuspendLayout();
            // 
            // Design
            // 
            Design.Location = new Point(25, 93);
            Design.Name = "Design";
            Design.Size = new Size(170, 251);
            Design.TabIndex = 0;
            Design.Text = "Start Designing";
            Design.UseVisualStyleBackColor = true;
            Design.Click += Design_Click;
            // 
            // Tutorial
            // 
            Tutorial.Location = new Point(634, 12);
            Tutorial.Name = "Tutorial";
            Tutorial.Size = new Size(130, 23);
            Tutorial.TabIndex = 1;
            Tutorial.Text = "Tutorial / How to Use:";
            Tutorial.UseVisualStyleBackColor = true;
            // 
            // TestMode
            // 
            TestMode.Location = new Point(213, 93);
            TestMode.Name = "TestMode";
            TestMode.Size = new Size(170, 251);
            TestMode.TabIndex = 2;
            TestMode.Text = "Mock Test Mode";
            TestMode.UseVisualStyleBackColor = true;
            // 
            // GateExplainer
            // 
            GateExplainer.Location = new Point(401, 93);
            GateExplainer.Name = "GateExplainer";
            GateExplainer.Size = new Size(170, 251);
            GateExplainer.TabIndex = 3;
            GateExplainer.Text = "Gate Explainer";
            GateExplainer.UseVisualStyleBackColor = true;
            // 
            // CircuitsSaved
            // 
            CircuitsSaved.Location = new Point(594, 93);
            CircuitsSaved.Name = "CircuitsSaved";
            CircuitsSaved.Size = new Size(170, 251);
            CircuitsSaved.TabIndex = 4;
            CircuitsSaved.Text = "Saved Circuits";
            CircuitsSaved.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(25, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "Settings";
            button6.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            Progress.Location = new Point(315, 12);
            Progress.Name = "Progress";
            Progress.Size = new Size(137, 23);
            Progress.TabIndex = 6;
            Progress.Text = "Progress Tracking";
            Progress.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(790, 406);
            Controls.Add(Progress);
            Controls.Add(button6);
            Controls.Add(CircuitsSaved);
            Controls.Add(GateExplainer);
            Controls.Add(TestMode);
            Controls.Add(Tutorial);
            Controls.Add(Design);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button Design;
        private Button Tutorial;
        private Button TestMode;
        private Button GateExplainer;
        private Button CircuitsSaved;
        private Button button6;
        private Button Progress;
    }
}