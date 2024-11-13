using CircuitSimulatorApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Design_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            CircuitDesignerForm form3 = new CircuitDesignerForm();

            // Show Form2
            form3.Show();

            // Optionally hide Form1
            this.Hide();
        }
    }
}
