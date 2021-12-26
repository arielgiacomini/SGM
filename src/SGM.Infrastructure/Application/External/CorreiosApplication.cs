﻿using SGM.Infrastructure.Queries.Interface.External;
using SGM.Domain.Entities.External;
using SGM.Infrastructure.Application.Interface.External;

namespace SGM.Infrastructure.Application.External
{
    public class CorreiosApplication : ICorreriosApplication
    {
        private readonly ICorreiosQuery _correiosQuery;

        public CorreiosApplication(ICorreiosQuery correiosQuery)
        {
            _correiosQuery = correiosQuery;
        }

        public CorreiosEndereco GetEnderecoByCEP(string cEP)
        {
            return _correiosQuery.GetEnderecoByCEP(cEP);
        }
    }
}