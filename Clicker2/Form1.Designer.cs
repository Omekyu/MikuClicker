namespace Clicker2
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      imgMiku = new PictureBox();
      lblClicks = new Label();
      autoClickerTimer = new System.Windows.Forms.Timer(components);
      dragUpTimer = new System.Windows.Forms.Timer(components);
      btnBonus = new Button();
      waitTimer = new System.Windows.Forms.Timer(components);
      ((System.ComponentModel.ISupportInitialize)imgMiku).BeginInit();
      SuspendLayout();
      // 
      // imgMiku
      // 
      imgMiku.Image = Properties.Resources.toppng_com_12954533_vocaloid_chibi_miku_592x511;
      imgMiku.Location = new Point(178, 137);
      imgMiku.Name = "imgMiku";
      imgMiku.Size = new Size(308, 289);
      imgMiku.SizeMode = PictureBoxSizeMode.Zoom;
      imgMiku.TabIndex = 0;
      imgMiku.TabStop = false;
      imgMiku.MouseDown += imgMiku_MouseDown;
      // 
      // lblClicks
      // 
      lblClicks.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblClicks.Location = new Point(12, 9);
      lblClicks.Name = "lblClicks";
      lblClicks.Size = new Size(622, 66);
      lblClicks.TabIndex = 1;
      lblClicks.Text = "Mikus: 0";
      lblClicks.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // autoClickerTimer
      // 
      autoClickerTimer.Interval = 1000;
      autoClickerTimer.Tick += autoClickerTimer_Tick;
      // 
      // dragUpTimer
      // 
      dragUpTimer.Enabled = true;
      dragUpTimer.Interval = 10;
      dragUpTimer.Tick += dragUpTimer_Tick;
      // 
      // btnBonus
      // 
      btnBonus.Enabled = false;
      btnBonus.FlatStyle = FlatStyle.Flat;
      btnBonus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      btnBonus.Location = new Point(529, 392);
      btnBonus.Name = "btnBonus";
      btnBonus.Size = new Size(105, 34);
      btnBonus.TabIndex = 2;
      btnBonus.Text = "Bonus";
      btnBonus.UseVisualStyleBackColor = true;
      btnBonus.Click += btnBonus_Click;
      // 
      // waitTimer
      // 
      waitTimer.Enabled = true;
      waitTimer.Tick += waitTimer_Tick;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(646, 438);
      Controls.Add(btnBonus);
      Controls.Add(lblClicks);
      Controls.Add(imgMiku);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Icon = (Icon)resources.GetObject("$this.Icon");
      MaximizeBox = false;
      Name = "Form1";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Miku Clicker";
      FormClosing += Form1_FormClosing;
      ((System.ComponentModel.ISupportInitialize)imgMiku).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private PictureBox imgMiku;
    private Label lblClicks;
    private System.Windows.Forms.Timer autoClickerTimer;
    private System.Windows.Forms.Timer dragUpTimer;
    private Button btnBonus;
    private System.Windows.Forms.Timer waitTimer;
  }
}
