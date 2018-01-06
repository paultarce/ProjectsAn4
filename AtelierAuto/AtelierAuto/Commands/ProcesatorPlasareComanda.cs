using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Repository;

namespace AtelierAuto.Commands
{
    public class ProcesatorPlasareComanda:ProcesatorCommandGeneric<CommandPlasareComanda>
    {
        private string _rootPath; // unde scriu in BD

        public ProcesatorPlasareComanda()
        {

        }
        public override void Proceseaza(CommandPlasareComanda command)//command -> comanda( arhitectura) ... comanda -> agg root
        {
            var repo = new WriteRepository();
            var comanda = repo.GasesteComnada((Guid)command.iDComanada);
            // comanda. // metoda pentru schimbarea  starii in plasata
            repo.SalvareEvenimente(comanda);
        }
    }
}