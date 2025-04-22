namespace MyWinForm; 

using System; 
using System.Windows.Forms; 


public partial class Form1 : Form
{
    private readonly  Button clickButton; 

    public Form1(){
        clickButton = new Button(); 
        clickButton.Text = "Click Me"; 
        clickButton.Click += new EventHandler(ClickButton_Click); 
        Controls.Add(clickButton); 

    }

    public void ClickButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Button clicked !");
    }
}


