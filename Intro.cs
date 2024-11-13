using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();  // This calls the method in Form1.Designer.cs
            Enter.Click += Enter_Click;  // Attach the click event to the Enter button
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Optionally hide Form1
            this.Hide();
        }

        private void Enter_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
