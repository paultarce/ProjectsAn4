using System;
using System.Collections.Generic;
using AtelierAuto.Repository;
using System.Linq;
using System.Web;

namespace AtelierAuto.Commands
{
    public class ProcesatorCautaComanda : ProcesatorCommandGeneric<CommandCautaComanda>
    {
        public override void Proceseaza(CommandCautaComanda comanda)
        {

            var read = new ReadRepository();

            var gasit = read.CautaComanda("5");


        }
    }
}