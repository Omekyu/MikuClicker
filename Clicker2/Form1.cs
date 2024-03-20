using Microsoft.VisualBasic;

namespace Clicker2
{
  public partial class Form1 : Form
  {
    private readonly int _mikuNormalY;

    private int _clicks = 0;
    private readonly int[] _achivements = { 20, 40, 60, 80, 100 };

    public Form1()
    {
      InitializeComponent();
      _mikuNormalY = imgMiku.Location.Y;
    }

    private void DragMikuDown(int amount)
    {
      imgMiku.Location = new Point(imgMiku.Location.X, imgMiku.Location.Y + amount);
    }

    private void Add(int i)
    {
      _clicks = _clicks + i;
      lblClicks.Text = "Mikus: " + _clicks;


      if (_achivements.Contains(_clicks))
      {
        MessageBox.Show($"Du hast {_clicks} Mikus.", "Miku Clicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

    }

    private void imgMiku_MouseDown(object sender, MouseEventArgs e)
    {
      Add(1);
      DragMikuDown(10);

      if (_clicks == 50)
      {
        DialogResult dg = MessageBox.Show("Du hast den Autoclicker freigeschlatet!\r\nMöchtest du ihn einschalten?", "Miku Clicker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dg == DialogResult.Yes)
          autoClickerTimer.Start();
      }
    }

    private void autoClickerTimer_Tick(object sender, EventArgs e)
    {
      Add(1);
      DragMikuDown(5);
    }

    private void dragUpTimer_Tick(object sender, EventArgs e)
    {
      int difference = imgMiku.Location.Y - _mikuNormalY;
      int tenPercent = (int)Math.Ceiling(difference * 0.1);
      DragMikuDown(-tenPercent);
    }
  }
}
