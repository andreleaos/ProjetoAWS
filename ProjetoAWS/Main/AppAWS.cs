using ProjetoAWS.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAWS.Main
{
    public class AppAWS : IAppAWS
    {
        private readonly IDatabaseService _databaseService;

        public AppAWS(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void Execute()
        {
            Console.WriteLine("teste");

            _databaseService.PesquisaSimples();

            _databaseService.PesquisaCompleta();

        }
    }
}
