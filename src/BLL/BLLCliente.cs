using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CCliente.Trim().Length == 0 && modelo.CApelido.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente ou Apelido é obrigatório.");
            }

            if (modelo.CTelefoneCelular.Trim().Length == 0 && modelo.CTelefoneFixo.Trim().Length == 0 && modelo.CTelefoneOutros.Trim().Length == 0)
            {
                throw new Exception("Preencher pelo menos 1 dos campos de telefones do cliente.");
            }

            modelo.CSexo = modelo.CSexo.ToUpper();
            modelo.CEmail = modelo.CEmail.ToLower();
            modelo.CCliente = modelo.CCliente.ToUpper();
            modelo.CApelido = modelo.CApelido.ToUpper();
            modelo.CEstadoCivil = modelo.CEstadoCivil.ToUpper();
            modelo.CLogradouroUF = modelo.CLogradouroUF.ToUpper();
            modelo.CLogradouroNome = modelo.CLogradouroNome.ToUpper();
            modelo.CLogradouroNumero = modelo.CLogradouroNumero.ToUpper();
            modelo.CLogradouroMunicipio = modelo.CLogradouroMunicipio.ToUpper();
            modelo.CLogradouroComplemento = modelo.CLogradouroComplemento.ToUpper();

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CClienteId <= 0)
            {
                throw new Exception("O código do Cliente é obrigatório!");
            }
            if (modelo.CCliente.Trim().Length == 0 && modelo.CApelido.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente ou Apelido é obrigatório.");
            }
            if (modelo.CTelefoneCelular.Trim().Length == 0 && modelo.CTelefoneFixo.Trim().Length == 0 && modelo.CTelefoneOutros.Trim().Length == 0)
            {
                throw new Exception("Preencher pelo menos 1 dos campos de telefones do cliente.");
            }

            modelo.CSexo = modelo.CSexo.ToUpper();
            modelo.CEmail = modelo.CEmail.ToLower();
            modelo.CCliente = modelo.CCliente.ToUpper();
            modelo.CApelido = modelo.CApelido.ToUpper();
            modelo.CEstadoCivil = modelo.CEstadoCivil.ToUpper();
            modelo.CLogradouroUF = modelo.CLogradouroUF.ToUpper();
            modelo.CLogradouroNome = modelo.CLogradouroNome.ToUpper();
            modelo.CLogradouroNumero = modelo.CLogradouroNumero.ToUpper();
            modelo.CLogradouroMunicipio = modelo.CLogradouroMunicipio.ToUpper();
            modelo.CLogradouroComplemento = modelo.CLogradouroComplemento.ToUpper();

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int clienteid)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(clienteid);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCliente CarregaModeloCliente(int clienteid)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(clienteid);
        }

        public int VerificaCPFCliente(String cpf)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.VerificaCPFCliente(cpf);
        }

        public DataTable LocalizarClienteByClienteId(int clienteId)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarClienteById(clienteId);
        }
    }
}
