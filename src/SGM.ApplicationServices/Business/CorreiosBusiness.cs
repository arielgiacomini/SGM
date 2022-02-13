using SGM.Domain.Entities.External;
using SGM.Domain.Intern.Entities;
using SGM.Domain.Intern.Enum;
using SGM.Domain.Intern.Interfaces.Application.External;
using SGM.Domain.Intern.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SGM.ApplicationServices.Messages;

namespace SGM.ApplicationServices.Business
{
    public class CorreiosBusiness : ICorreiosBusiness
    {
        private readonly ICorreriosApplication _correriosApplication;

        public CorreiosBusiness(ICorreriosApplication correriosApplication)
        {
            _correriosApplication = correriosApplication;
        }

        public ResponseCorreios SearchByCEP(string cep)
        {
            ResponseCorreios response = new ResponseCorreios
            {
                Mensagem = new Dictionary<TipoMensagemEnum, string>()
            };

            if (string.IsNullOrEmpty(cep))
            {
                response.TipoResponse = TipoResponseEnum.Information;
                response.Mensagem.Add(TipoMensagemEnum.Information, $"{Messages.Mensagem(MensagemEnum.CEPInexistente)}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Information;

                return response;
            }

            try
            {

                var correiosApplication = _correriosApplication.GetEnderecoByCEP(cep);

                var responseToMap = MapCorreiosEnderecoToResponseCorreios(correiosApplication, response);

                responseToMap.TipoResponse = TipoResponseEnum.SucessWithoutMessageOrQuestion;
                responseToMap.Mensagem.Add(TipoMensagemEnum.Information, $"{Messages.Mensagem(MensagemEnum.CEPEncontrado)}: {cep}");

                responseToMap.ReturnCompleted = true;
                responseToMap.FocusNumber = true;

                return response;
            }
            catch (Exception ex)
            {
                response.TipoResponse = TipoResponseEnum.Error;
                response.Mensagem.Add(TipoMensagemEnum.ErrorInSearch, $"{Messages.Mensagem(MensagemEnum.CEPInexistente)}: {cep}, Mensagem de erro: {ex.Message}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Error;

                return response;
            }
        }

        private ResponseCorreios MapCorreiosEnderecoToResponseCorreios(CorreiosEndereco correiosEndereco, ResponseCorreios response)
        {
            response.CEP = correiosEndereco?.CEP;
            response.Logradouro = correiosEndereco?.Logradouro;
            response.Complemento = correiosEndereco?.Complemento;
            response.Bairro = correiosEndereco?.Bairro;
            response.Localidade = correiosEndereco?.Localidade;
            response.UF = correiosEndereco?.UF;
            response.IBGE = correiosEndereco?.IBGE;
            response.GIA = correiosEndereco?.GIA;
            response.DDD = correiosEndereco?.DDD;
            response.SIAFI = correiosEndereco?.SIAFI;

            return response;
        }
    }
}