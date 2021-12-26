using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmConsultaPeca : Form
    {
        private readonly IPecaApplication _pecaApplication;
        public int codigo = 0;

        public FrmConsultaPeca(IPecaApplication pecaApplication)
        {
            _pecaApplication = pecaApplication;
            InitializeComponent();
        }

        private void BtnConsultaPeca_Click(object sender, EventArgs e)
        {
            if (txtConsultaPeca.Text != "" || txtConsultaPeca.Text != null)
            {
                var listaPecas = _pecaApplication.GetPecaByDescricao(txtConsultaPeca.Text);

                CarregaGridView(listaPecas);
            }
        }

        private void FrmConsultaPeca_Load(object sender, EventArgs e)
        {
            IList<Peca> maoDeObra = new List<Peca>();

            if (codigo > 0)
            {
                maoDeObra.Add(_pecaApplication.GetPecaByPecaId(codigo));
            }
            else
            {
                maoDeObra = _pecaApplication.GetPecaByAll();
            }

            CarregaGridView(maoDeObra);
        }

        private void DgvConsultaPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvConsultaPeca.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void CarregaGridView(IList<Peca> peca)
        {
            dgvConsultaPeca.DataSource = peca;
            dgvConsultaPeca.Columns[0].HeaderText = "Código";
            dgvConsultaPeca.Columns[0].Width = 50;
            dgvConsultaPeca.Columns[1].HeaderText = "Peça/Produto";
            dgvConsultaPeca.Columns[1].Width = 250;
            dgvConsultaPeca.Columns[2].HeaderText = "Fornecedor";
            dgvConsultaPeca.Columns[2].Width = 117;
            dgvConsultaPeca.Columns[3].HeaderText = "Valor Peça/Produto";
            dgvConsultaPeca.Columns[3].Width = 90;
            dgvConsultaPeca.Columns[4].HeaderText = "Frete/Adicional";
            dgvConsultaPeca.Columns[4].Width = 90;
            dgvConsultaPeca.Columns[5].HeaderText = "Status";
            dgvConsultaPeca.Columns[5].Width = 50;
            dgvConsultaPeca.Columns[6].HeaderText = "Data Cadastro";
            dgvConsultaPeca.Columns[6].Width = 70;
        }
    }
}
