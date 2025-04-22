using System;
using System.Windows.Forms;

namespace Lab1
{
    public class Form1 : Form
    {
        private Button button1;

        public Form1()
        {
            // Set form properties
            this.Text = "Minimal Form";
            this.ClientSize = new System.Drawing.Size(300, 250);

            // Create a button
            button1 = new Button();
            button1.Text = "Click Me!";
            button1.Size = new System.Drawing.Size(100, 50);
            button1.Location = new System.Drawing.Point(100, 100);

            // Button click event
            button1.Click += (sender, e) => MessageBox.Show("Hello, Pahadi Research!");

            // Add button to the form
            this.Controls.Add(button1);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
