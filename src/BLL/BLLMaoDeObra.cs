using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLMaoDeObra
    {
        private DALConexao conexao;

        public BLLMaoDeObra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloMaoDeObra modelo)
        {
            if (modelo.CMaodeObra.Trim().Length == 0)
            {
                throw new Exception("O nome da Mão-de-Obra é obrigatório.");
            }

            if (modelo.CValor == 0)
            {
                throw new Exception("O valor da Mão-de-Obra é obrigatório.");
            }

            modelo.CMaodeObra = modelo.CMaodeObra.ToUpper();
            modelo.CTipo = modelo.CTipo.ToUpper();


            DALMaoDeObra DALobj = new DALMaoDeObra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloMaoDeObra modelo)
        {
            if (modelo.CMaodeObraId <= 0)
            {
                throw new Exception("O código da Mão-de-Obra é obrigatório!");
            }
            if (modelo.CMaodeObra.Trim().Length == 0)
            {
                throw new Exception("O nome da Mão-de-Obra é obrigatório.");
            }

            modelo.CMaodeObra = modelo.CMaodeObra.ToUpper();
            modelo.CTipo = modelo.CTipo.ToUpper();

            DALMaoDeObra DALobj = new DALMaoDeObra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int maodeobraid)
        {
            DALMaoDeObra DALobj = new DALMaoDeObra(conexao);
            DALobj.Excluir(maodeobraid);
        }

        public DataTable Localizar(String valor)
        {
            DALMaoDeObra DALobj = new DALMaoDeObra(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloMaoDeObra CarregaModeloMaoDeObra(int maodeobraid)
        {
            DALMaoDeObra DALobj = new DALMaoDeObra(conexao);
            return DALobj.CarregaModeloMaoDeObra(maodeobraid);
        }
    }
}
