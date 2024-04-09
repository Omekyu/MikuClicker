using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace Clicker2
{
  public partial class Form1 : Form
  {
    private readonly int _mikuNormalY;

    private readonly SaveData _saveData = new SaveData();
    private readonly int[] _achivements = { 20, 40, 60, 80, 100 };
    private readonly string _saveDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MikuClicker", "save.json");

    public Form1()
    {
      InitializeComponent();
      _mikuNormalY = imgMiku.Location.Y;

      Directory.CreateDirectory(Path.GetDirectoryName(_saveDataPath)!);

      if (File.Exists(_saveDataPath))
        _saveData = JsonConvert.DeserializeObject<SaveData>(File.ReadAllText(_saveDataPath)) ?? new SaveData();

      File.WriteAllText(_saveDataPath, JsonConvert.SerializeObject(_saveData, Formatting.Indented));

      autoClickerTimer.Interval = _saveData.AutoClickerInterval;
      if (_saveData.Mikus >= 50)
        autoClickerTimer.Start();

      if (_saveData.WaitTime == 0)
      {
        btnBonus.Enabled = true;
        waitTimer.Stop();
      }

      UpdateUI();
    }

    private void DragMikuDown(int amount)
    {
      imgMiku.Location = new Point(imgMiku.Location.X, imgMiku.Location.Y + amount);
    }

    private void UpdateUI()
    {
      lblClicks.Text = "Mikus: " + _saveData.Mikus;
      if (_saveData.WaitTime == 0)
        btnBonus.Text = "Bonus";
      else
        btnBonus.Text = $"Next: {Math.Round(_saveData.WaitTime / 10d, 1).ToString("N1", CultureInfo.InvariantCulture)}s";
    }

    private void Add(int i)
    {
      _saveData.Mikus = _saveData.Mikus + i;
      UpdateUI();

      if (_achivements.Contains(_saveData.Mikus))
        MessageBox.Show($"Du hast {_saveData.Mikus} Mikus.", "Miku Clicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void imgMiku_MouseDown(object sender, MouseEventArgs e)
    {
      DragMikuDown(10);
      Add(1);

      if (_saveData.Mikus == 50)
      {
        DialogResult dg = MessageBox.Show("Du hast den Autoclicker freigeschlatet!\r\nMöchtest du ihn einschalten?", "Miku Clicker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dg == DialogResult.Yes)
          autoClickerTimer.Start();
      }
    }

    private void autoClickerTimer_Tick(object sender, EventArgs e)
    {
      DragMikuDown(5);
      Add(1);
    }

    private void dragUpTimer_Tick(object sender, EventArgs e)
    {
      int difference = imgMiku.Location.Y - _mikuNormalY;
      int tenPercent = (int)Math.Ceiling(difference * 0.1);
      DragMikuDown(-tenPercent);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult dg = MessageBox.Show("Möchtest du deinen\nFortschritt speichern?", "Miku Clicker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (dg == DialogResult.Yes)
        File.WriteAllText(_saveDataPath, JsonConvert.SerializeObject(_saveData, Formatting.Indented));
    }

    private void waitTimer_Tick(object sender, EventArgs e)
    {
      _saveData.WaitTime--;

      if (_saveData.WaitTime == 0)
      {
        btnBonus.Enabled = true;
        waitTimer.Stop();
      }

      UpdateUI();
    }

    private void btnBonus_Click(object sender, EventArgs e)
    {
      _saveData.Mikus += 100;
      _saveData.WaitTime = 600;

      btnBonus.Enabled = false;
      waitTimer.Start();
      UpdateUI();
    }
  }
}
