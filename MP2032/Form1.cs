using System;
using System.Windows.Forms;

namespace MP2032
{
    public partial class frmFuncionalidadesImpressora : Form
    {
        public frmFuncionalidadesImpressora()
        {
            InitializeComponent();
        }

        private void btnModeloImpressora_Click(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = MP2032.ConfiguraModeloImpressora(7);

            if (iRetorno == 1)
            {
                MessageBox.Show("Modelo configurado!");
            }
            else
            {
                MessageBox.Show("Problemas ao configurar modelo");
            }
        }

        private void btnPortaImpressora_Click(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = MP2032.IniciaPorta("");

            if (iRetorno == 1)
            {
                MessageBox.Show("Porta confugrada!");
            }
            else
            {
                MessageBox.Show("Problemas ao abrir a porta");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = MP2032.FormataTX("Texto : BSP, software partners", 2, 0, 0, 1, 1);

            if (iRetorno == 1)
            {
                MessageBox.Show("Impresso!!");
            }
            else
            {
                MessageBox.Show("Problemas ao imprimir");
            }
        }

        private void btnGuilhotinaImpressora_Click(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = MP2032.AcionaGuilhotina(1);

            if (iRetorno == 1)
            {
                MessageBox.Show("Corte do papel efetuado");
            }
            else
            {
                MessageBox.Show("Problemas ao acionar a guilhotina");
            }
        }

        private void btnGavetaImpressora_Click(object sender, EventArgs e)
        {
            int iRetorno;

            int charCode1 = 27;
            int charCode2 = 118;
            int charCode3 = 140;

            char specialChar1 = Convert.ToChar(charCode1);
            char specialChar2 = Convert.ToChar(charCode2);
            char specialChar3 = Convert.ToChar(charCode3);

            string s_cmdTX = "" + specialChar1 + specialChar2 + specialChar3;

            iRetorno = MP2032.ComandoTX(s_cmdTX, s_cmdTX.Length);
        }
    }
}
