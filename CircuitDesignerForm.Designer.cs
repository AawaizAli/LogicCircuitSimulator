namespace CircuitSimulatorApp
{
    partial class CircuitDesignerForm
    {
        private Panel canvasPanel;
        private Panel toolPalettePanel;
        private Panel simulationControlsPanel;

        private void InitializeComponent()
        {
            canvasPanel = new Panel();
            toolPalettePanel = new Panel();
            simulationControlsPanel = new Panel();
            Wirecolor = new Button();
            Labeladder = new Button();
            Stop = new Button();
            Start = new Button();
            simulationControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // canvasPanel
            // 
            canvasPanel.Location = new Point(-3, 0);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new Size(632, 600);
            canvasPanel.TabIndex = 0;
            canvasPanel.DragDrop += CanvasPanel_DragDrop;
            canvasPanel.DragEnter += CanvasPanel_DragEnter;
            // 
            // toolPalettePanel
            // 
            toolPalettePanel.Location = new Point(628, 0);
            toolPalettePanel.Name = "toolPalettePanel";
            toolPalettePanel.Size = new Size(172, 473);
            toolPalettePanel.TabIndex = 1;
            // 
            // simulationControlsPanel
            // 
            simulationControlsPanel.Controls.Add(Wirecolor);
            simulationControlsPanel.Controls.Add(Labeladder);
            simulationControlsPanel.Controls.Add(Stop);
            simulationControlsPanel.Controls.Add(Start);
            simulationControlsPanel.Location = new Point(628, 479);
            simulationControlsPanel.Name = "simulationControlsPanel";
            simulationControlsPanel.Size = new Size(172, 121);
            simulationControlsPanel.TabIndex = 2;
            // 
            // Wirecolor
            // 
            Wirecolor.Location = new Point(21, 17);
            Wirecolor.Name = "Wirecolor";
            Wirecolor.Size = new Size(129, 23);
            Wirecolor.TabIndex = 3;
            Wirecolor.Text = "Change Wire Color";
            Wirecolor.UseVisualStyleBackColor = true;
            Wirecolor.Click += Wirecolor_Click;
            // 
            // Labeladder
            // 
            Labeladder.BackColor = SystemColors.AppWorkspace;
            Labeladder.Location = new Point(55, 86);
            Labeladder.Name = "Labeladder";
            Labeladder.Size = new Size(69, 32);
            Labeladder.TabIndex = 2;
            Labeladder.Text = "Add Label";
            Labeladder.UseVisualStyleBackColor = false;
            Labeladder.Click += Labeladder_Click;
            // 
            // Stop
            // 
            Stop.BackColor = Color.FromArgb(255, 128, 128);
            Stop.Location = new Point(109, 46);
            Stop.Name = "Stop";
            Stop.Size = new Size(51, 34);
            Stop.TabIndex = 1;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = false;
            Stop.Click += Stop_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.FromArgb(128, 255, 128);
            Start.Location = new Point(7, 46);
            Start.Name = "Start";
            Start.Size = new Size(51, 34);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // CircuitDesignerForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(toolPalettePanel);
            Controls.Add(canvasPanel);
            Controls.Add(simulationControlsPanel);
            Name = "CircuitDesignerForm";
            Text = "Circuit Designer";
            simulationControlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void CanvasPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CanvasPanel_DragDrop(object sender, DragEventArgs e)
        {
            // Logic to add the dragged component to the canvas at the drop location
            string componentType = e.Data.GetData(typeof(string)) as string;

            // Example: Create a new control based on the component type and place it on the canvas
            if (componentType == "AND")
            {
                Button andGate = new Button { Text = "AND", Location = canvasPanel.PointToClient(new Point(e.X, e.Y)) };
                canvasPanel.Controls.Add(andGate);
            }
        }

        private Button Stop;
        private Button Start;
        private Button Wirecolor;
        private Button Labeladder;
    }
}
