using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void btnConsolidadoDiario_Click(object sender, EventArgs e)
        {
            frmRelatoriosConsolidadoRelatorioDiario g = new frmRelatoriosConsolidadoRelatorioDiario();
            g.ShowDialog();
            g.Dispose();
        }
    }
}
