using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAWS.Repositories.Contracts
{
    public interface IDatabaseRepository
    {
        void PesquisaSimples();
        void PesquisaCompleta();
    }
}
