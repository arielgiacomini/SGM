using System;
using System.Windows.Forms;

namespace SGM.WindowsForms.Fomularios.Modelo
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void FrmLoading_Load(object sender, System.EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            timer.Interval = 100;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (progressBar.Value != 100)
            {
                progressBar.Value++;
            }
            else
            {
                timer.Stop();
                Close();
            }
        }
    }
}