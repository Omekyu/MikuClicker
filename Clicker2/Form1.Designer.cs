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
      imgMiku = new PictureBox();
      lblClicks = new Label();
      timer1 = new System.Windows.Forms.Timer(components);
      ((System.ComponentModel.ISupportInitialize)imgMiku).BeginInit();
      SuspendLayout();
      // 
      // imgMiku
      // 
      imgMiku.Image = Properties.Resources.toppng_com_12954533_vocaloid_chibi_miku_592x511;
      imgMiku.Location = new Point(175, 137);
      imgMiku.Name = "imgMiku";
      imgMiku.Size = new Size(308, 289);
      imgMiku.SizeMode = PictureBoxSizeMode.Zoom;
      imgMiku.TabIndex = 0;
      imgMiku.TabStop = false;
      imgMiku.MouseDown += imgMiku_MouseDown;
      imgMiku.MouseUp += imgMiku_MouseUp;
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
      // timer1
      // 
      timer1.Interval = 1000;
      timer1.Tick += timer1_Tick;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(646, 438);
      Controls.Add(lblClicks);
      Controls.Add(imgMiku);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Name = "Form1";
      Text = "Miku Clicker";
      ((System.ComponentModel.ISupportInitialize)imgMiku).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private PictureBox imgMiku;
    private Label lblClicks;
    private System.Windows.Forms.Timer timer1;
  }
}
