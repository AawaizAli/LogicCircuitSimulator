using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitSimulatorApp
{
    public partial class CircuitDesignerForm : Form
    {
        // Define a boolean to track the simulation state
        private bool isSimulationRunning = false;

        // Define a timer to simulate circuit behavior (using System.Windows.Forms.Timer to avoid ambiguity)
        private System.Windows.Forms.Timer simulationTimer;

        public CircuitDesignerForm()
        {
            InitializeComponent();
            InitializeToolPalette();
            InitializeSimulationControls();

            // Connect event handlers for drag-and-drop functionality
            this.canvasPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.canvasPanel_DragEnter);
            this.canvasPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.canvasPanel_DragDrop);
        }


        private void InitializeToolPalette()
        {
            // Add buttons for each circuit component (AND, OR, NOT, etc.)
            Button andGateButton = new Button { Text = "AND Gate", Name = "AND" };
            andGateButton.MouseDown += (s, e) =>
            {
                // Only allow dragging if left mouse button is clicked
                if (e.Button == MouseButtons.Left)
                {
                    // Start the drag-and-drop operation for the AND gate
                    andGateButton.DoDragDrop(andGateButton.Name, DragDropEffects.Copy);
                }
            };

            // You can repeat for other buttons like OR, NOT, etc.
            toolPalettePanel.Controls.Add(andGateButton);
        }

        private void InitializeSimulationControls()
        {
            // Initialize the simulation timer
            simulationTimer = new System.Windows.Forms.Timer();
            simulationTimer.Interval = 1000; // 1 second interval for simulation updates
            simulationTimer.Tick += SimulationTimer_Tick; // Event to handle simulation updates
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!isSimulationRunning)
            {
                // Start the simulation
                isSimulationRunning = true;
                simulationTimer.Start();
                MessageBox.Show("Simulation Started!");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (isSimulationRunning)
            {
                // Stop the simulation
                isSimulationRunning = false;
                simulationTimer.Stop();
                MessageBox.Show("Simulation Stopped!");
            }
        }

        // This method is called periodically by the simulation timer
        private void SimulationTimer_Tick(object sender, EventArgs e)
        {
            // Here, you would update the state of the circuit components
            // For example, you could check if signals are propagating through gates or wires
            UpdateCircuitState();
        }

        // Example method to update the state of the circuit components
        private void UpdateCircuitState()
        {
            // Update the circuit simulation state (e.g., wire states, gate outputs)
            // This is a placeholder for your logic simulation (such as updating wire signals)
            Console.WriteLine("Updating Circuit State...");
        }

        //// Handle DragEnter for Canvas (ensure that drag operation is accepted)
        //private void canvasPanel_DragEnter(object sender, DragEventArgs e)
        //{
        //    // Allow drop only if it's a valid drag operation (i.e., a component name is dragged)
        //    if (e.Data.GetDataPresent(DataFormats.StringFormat))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //}

        //// Handle DragDrop for Canvas (add the dropped component at the drop location)
        //private void canvasPanel_DragDrop(object sender, DragEventArgs e)
        //{
        //    // Get the dragged component name (e.g., "AND")
        //    string componentType = e.Data.GetData(DataFormats.StringFormat) as string;

        //    // Get the location where the user dropped the component
        //    Point dropPoint = canvasPanel.PointToClient(new Point(e.X, e.Y));

        //    // Place the appropriate component on the canvas based on the dragged type
        //    if (componentType == "AND")
        //    {
        //        // Create a new label or button for the AND gate at the drop location
        //        Button andGate = new Button
        //        {
        //            Text = "AND Gate",
        //            Location = dropPoint,
        //            Size = new Size(100, 50) // Size of the AND Gate button
        //        };

        //        // Add the AND Gate to the canvas panel
        //        canvasPanel.Controls.Add(andGate);
        //    }

        //    // You can repeat for other components like OR, NOT, etc.
        //}

        // Event for drag enter
        private void canvasPanel_DragEnter(object sender, DragEventArgs e)
        {
            // Ensure that we accept the drag only if it's a valid component
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Event for handling the drop of a component onto the canvas
        private void canvasPanel_DragDrop(object sender, DragEventArgs e)
        {
            // Get the component type (e.g., AND gate)
            string componentType = e.Data.GetData(DataFormats.StringFormat) as string;

            // Get the drop location on the canvas
            Point dropPoint = canvasPanel.PointToClient(new Point(e.X, e.Y));

            // Add the appropriate component based on the dragged item
            if (componentType == "AND")
            {
                Button andGate = new Button
                {
                    Text = "AND Gate",
                    Location = dropPoint,
                    Size = new Size(100, 50)
                };
                canvasPanel.Controls.Add(andGate);
            }
            // Add other components like OR, NOT, etc. similarly.
        }

        private void Labeladder_Click(object sender, EventArgs e)
        {
            // Implement the functionality to add labels
        }

        private void Wirecolor_Click(object sender, EventArgs e)
        {
            // Implement the functionality to change wire colors
        }

    }
}

