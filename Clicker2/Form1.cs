using Microsoft.VisualBasic;

namespace Clicker2
{
  public partial class Form1 : Form
  {
    int clicks = 0;
    int[] achivements = { 20, 40, 60, 80, 100 };

    public Form1()
    {
      InitializeComponent();
    }

    void Add(int i)
    {
      clicks = clicks + i;
      lblClicks.Text = "Mikus: " + clicks;

      if (achivements.Contains(clicks) == true)
      {
        MessageBox.Show($"Du hast {clicks} Mikus.", "Miku Clicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        imgMiku.Location = new Point(imgMiku.Location.X, 137);
      }
    }

    void MoveMiku(int i)
    {
      imgMiku.Location = new Point(imgMiku.Location.X, imgMiku.Location.Y + i);
    }

    private void imgMiku_MouseDown(object sender, MouseEventArgs e)
    {
      MoveMiku(10);
      Add(1);

      if (clicks == 50)
      {
        DialogResult dg = MessageBox.Show("Du hast den Autoclicker freigeschlatet!\r\nMöchtest du ihn einschalten?", "Miku Clicker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dg == DialogResult.Yes)
          timer1.Start();
      }
      
    }

    private void imgMiku_MouseUp(object sender, MouseEventArgs e)
    {
      MoveMiku(-10);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Add(1);
      MoveMiku(10);
      Thread.Sleep(50);
      MoveMiku(-10);
    }
  }
}
