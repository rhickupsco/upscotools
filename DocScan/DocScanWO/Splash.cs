using System;

using System.Windows.Forms;

namespace DocScanWO
{

    public partial class Splash : Form
    {
    public Splash()
    {
        InitializeComponent();
    }

    private void Splash_Load(object sender, EventArgs e)
    {
        StartBackgroundWork();
    }

    private void StartBackgroundWork()
    {
        if (Application.RenderWithVisualStyles)
            progressBar1.Style = ProgressBarStyle.Marquee;
        else
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Enabled = true;
            timer1.Start();
        }
        backgroundWorker1.RunWorkerAsync();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        if (progressBar1.Value < progressBar1.Maximum)
            progressBar1.Increment(100);

        else
            progressBar1.Value = progressBar1.Minimum;
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}

