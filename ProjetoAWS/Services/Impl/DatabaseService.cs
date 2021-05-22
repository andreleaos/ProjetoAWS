using ProjetoAWS.Repositories.Contracts;
using ProjetoAWS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAWS.Services.Impl
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IDatabaseRepository repository;

        public DatabaseService(IDatabaseRepository repository)
        {
            this.repository = repository;
        }

        public void PesquisaCompleta()
        {
            try
            {
                Console.WriteLine("Pesquisa Completa chamada no servico");
                repository.PesquisaCompleta();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PesquisaSimples()
        {
            try
            {
                Console.WriteLine("Pesquisa Simples  chamada no servico");
                repository.PesquisaSimples();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
