using ProjetoAWS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAWS.Services.Impl
{
    public class DatabaseService : IDatabaseService
    {
        public void PesquisaCompleta()
        {
            Console.WriteLine("Pesquisa Completa");
        }

        public void PesquisaSimples()
        {
            Console.WriteLine("Pesquisa Simples");
        }
    }
}
