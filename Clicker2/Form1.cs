using Microsoft.VisualBasic;

namespace Clicker2
{
  public partial class Form1 : Form
  {
    // Initilize variables
    int clicks = 0;
    int[] achivements = { 20, 40, 60, 80, 100 };

    public Form1()
    {
      InitializeComponent();
    }

    
    void MoveMiku(int i)
    {
      // Displace Miku by specified amount
      imgMiku.Location = new Point(imgMiku.Location.X, imgMiku.Location.Y + i);
    }

    void Add(int i)
    {
      // Basic adding logic
      clicks = clicks + i;
      lblClicks.Text = "Mikus: " + clicks;

      // Check for achievements
      // Go through each entry in achievements[]
      foreach (int j in achivements)
      {
        if (clicks == j)
        {
          // If the current clicks match the entry in the current pass, show MessageBox
          MessageBox.Show($"Du hast {j} Mikus.", "Miku Clicker", MessageBoxButtons.OK, MessageBoxIcon.Information);

          // Workaround to messagebox not triggering MouseUp()
          imgMiku.Location = new Point(imgMiku.Location.X, 137);
        }
      }
    }

    private void imgMiku_MouseDown(object sender, MouseEventArgs e)
    {
      // Move Miku down by 10 pixels and add one to clicks
      MoveMiku(10);
      Add(1);

      // Check for auto clicker
      if (clicks == 50)
      {
        // Save the dialog result and start the timer depending on the user's answer
        DialogResult dg = MessageBox.Show("Du hast den Autoclicker freigeschlatet!\r\nMöchtest du ihn einschalten?", "Miku Clicker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dg == DialogResult.Yes)
          timer1.Start();
      }
    }

    private void imgMiku_MouseUp(object sender, MouseEventArgs e)
    {
      // Move Miku up by 10 pixels
      MoveMiku(-10);
    }

    private async void timer1_Tick(object sender, EventArgs e)
    {
      // Add one to clicks on each timer cycle and automatically move miku down and back up shortly after
      Add(1);
      MoveMiku(10);
      await Task.Delay(50);
      MoveMiku(-10);
    }
  }
}
