using ProjetoAWS.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAWS.Repositories.Impl
{
    public class DatabaseRepository : IDatabaseRepository
    {
        public void PesquisaCompleta()
        {
            Console.WriteLine("Pesquisa completa realizada no repositório");
        }

        public void PesquisaSimples()
        {
            Console.WriteLine("Pesquisa simples realizada no repositório");
        }
    }
}
