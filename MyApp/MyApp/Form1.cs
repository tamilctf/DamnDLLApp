using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AddDLL;

namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Search Order Hijacking
        [DllImport("pikachu.dll", CharSet = CharSet.Auto)]
        public static extern void VulnerableDllImport();

        // Side Loading
        [DllImport("pikachu.dll", CharSet = CharSet.Auto)]
        public static extern void LegitimateDllImport();

        // Form Load event (can be used for initialization)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form components or settings if needed
            label6.Text = "Result : ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve text from the textbox
            string message = textBox1.Text;

            // Display the message in a MessageBox after loading DLL
            VulnerableDllImport();
            MessageBox.Show(message, "Message From @tamilctf", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optional: Clear the textbox after displaying the message
            // textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check X and Y as INT
            if (int.TryParse(textBox2.Text, out int x) && int.TryParse(textBox3.Text, out int y))
            {
                // Add and show result
                Calculator calc = new Calculator();
                int result = calc.AddNumbers(x, y);
                label6.Text = $"Result: {result}";
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for X and Y.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional: TextBox TextChanged event handler
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes in the textbox if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes in the textbox if needed
        }

        // Optional: Label Click event handlers
        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }
    }
}