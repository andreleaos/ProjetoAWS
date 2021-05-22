using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAWS.Services.Contracts
{
    public interface IDatabaseService
    {
        void PesquisaSimples();
        void PesquisaCompleta();
    }
}
