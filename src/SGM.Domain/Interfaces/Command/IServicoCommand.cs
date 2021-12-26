﻿using SGM.Domain.Entities;
using System.Threading.Tasks;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IServicoCommand
    {
        void AtualizarServico(Servico servico);
        void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        Task DeletarServicoPecaAsync(ServicoPeca servicoPeca);
        int SalvarServico(Servico servico);
        int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        int SalvarServicoPeca(ServicoPeca servicoPeca);
    }
}