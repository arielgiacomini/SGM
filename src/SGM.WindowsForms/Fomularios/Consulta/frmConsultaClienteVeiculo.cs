using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.DataSources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmConsultaClienteVeiculo : Form
    {
        public int clienteVeiculoId = 0;
        public int clienteId = 0;
        public string nomeCliente = "";
        public string placaVeiculo = "";
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly IVeiculoApplication _veiculoApplication;

        public FrmConsultaClienteVeiculo(IClienteApplication clienteApplication, IClienteVeiculoApplication clienteVeiculoApplication, IVeiculoApplication veiculoApplication)
        {
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _veiculoApplication = veiculoApplication;
            InitializeComponent();
        }

        private void FrmConsultaClienteVeiculo_Load(object sender, EventArgs e)
        {
            IList<PesquisaClienteVeiculoDataSource> listaCliente = new List<PesquisaClienteVeiculoDataSource>();

            if (clienteId > 0)
            {
                var cliente = _clienteApplication.GetClienteById(clienteId);
                var clienteVeiculo = _clienteVeiculoApplication.GetVeiculosClienteByClienteId(clienteId);

                foreach (var item in clienteVeiculo)
                {
                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(item.VeiculoId);
                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    cliente.ClienteVeiculo.Add(item);

                    listaCliente.Add(new PesquisaClienteVeiculoDataSource
                    {
                        ClienteVeiculoId = item.ClienteVeiculoId,
                        ClienteId = cliente.ClienteId,
                        NomeCliente = cliente.NomeCliente,
                        Modelo = marca.Marca + " / " + veiculo.Modelo,
                        PlacaVeiculo = item.PlacaVeiculo,
                        CorVeiculo = item.CorVeiculo,
                        KmRodados = item.KmRodados,
                        DataCadastro = item.DataCadastro,
                        Ativo = item.Ativo,
                        DataAlteracao = item.DataAlteracao
                    });
                }

                CarregaGridView(listaCliente);
            }
            else
            {
                CarregaGridView(listaCliente);
            }
        }

        private void BtnPlacaClienteVeiculoConsulta_Click(object sender, EventArgs e)
        {
            IList<PesquisaClienteVeiculoDataSource> listaCliente = new List<PesquisaClienteVeiculoDataSource>();

            if (txtPlacaClienteVeiculoConsulta.Text != "" || txtPlacaClienteVeiculoConsulta.Text != null)
            {
                var cliente = _clienteApplication.GetClienteByLikePlacaOrNomeOrApelido(txtPlacaClienteVeiculoConsulta.Text);

                if (cliente.ClienteVeiculo.Count > 0)
                {
                    foreach (var item in cliente.ClienteVeiculo)
                    {
                        var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(item.VeiculoId);
                        var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                        listaCliente.Add(new PesquisaClienteVeiculoDataSource
                        {
                            ClienteVeiculoId = item.ClienteVeiculoId,
                            ClienteId = cliente.ClienteId,
                            NomeCliente = cliente.NomeCliente,
                            Modelo = marca.Marca + " / " + veiculo.Modelo,
                            PlacaVeiculo = item.PlacaVeiculo,
                            CorVeiculo = item.CorVeiculo,
                            KmRodados = item.KmRodados,
                            DataCadastro = item.DataCadastro,
                            Ativo = item.Ativo,
                            DataAlteracao = item.DataAlteracao
                        });
                    }
                }
                else
                {
                    listaCliente.Add(new PesquisaClienteVeiculoDataSource
                    {
                        ClienteVeiculoId = 0,
                        ClienteId = cliente.ClienteId,
                        NomeCliente = cliente.NomeCliente,
                        Modelo = "",
                        PlacaVeiculo = "",
                        CorVeiculo = "",
                        KmRodados = 0,
                        DataCadastro = DateTime.Now,
                        Ativo = false,
                        DataAlteracao = DateTime.Now
                    });
                }

                CarregaGridView(listaCliente);
            }
            else
            {
                CarregaGridView(listaCliente);
            }
        }

        private void DgvClienteVeiculoConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.clienteVeiculoId = Convert.ToInt32(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[0].Value ?? 0);
                this.clienteId = Convert.ToInt32(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[1].Value ?? 0);
                this.Close();
            }
        }

        private void CarregaGridView(IList<PesquisaClienteVeiculoDataSource> clienteVeiculos)
        {
            dgvClienteVeiculoConsulta.DataSource = clienteVeiculos;
            dgvClienteVeiculoConsulta.Columns[0].HeaderText = "Código";
            dgvClienteVeiculoConsulta.Columns[0].Width = 50;
            dgvClienteVeiculoConsulta.Columns[1].HeaderText = "Cliente ID";
            dgvClienteVeiculoConsulta.Columns[1].Width = 80;
            dgvClienteVeiculoConsulta.Columns[2].HeaderText = "Cliente";
            dgvClienteVeiculoConsulta.Columns[2].Width = 250;
            dgvClienteVeiculoConsulta.Columns[3].HeaderText = "Veículo";
            dgvClienteVeiculoConsulta.Columns[3].Width = 265;
            dgvClienteVeiculoConsulta.Columns[4].HeaderText = "Placa";
            dgvClienteVeiculoConsulta.Columns[4].Width = 80;
            dgvClienteVeiculoConsulta.Columns[5].HeaderText = "Cor";
            dgvClienteVeiculoConsulta.Columns[5].Width = 80;
            dgvClienteVeiculoConsulta.Columns[6].HeaderText = "Km Rodados";
            dgvClienteVeiculoConsulta.Columns[6].Width = 80;
            dgvClienteVeiculoConsulta.Columns[7].HeaderText = "Veiculo do Cliente está Ativo?";
            dgvClienteVeiculoConsulta.Columns[7].Width = 100;
            dgvClienteVeiculoConsulta.Columns[8].HeaderText = "Data de Cadastro";
            dgvClienteVeiculoConsulta.Columns[8].Width = 120;
            dgvClienteVeiculoConsulta.Columns[9].HeaderText = "Data de Alteração";
            dgvClienteVeiculoConsulta.Columns[9].Width = 120;
        }
    }
}
