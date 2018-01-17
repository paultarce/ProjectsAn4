using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Repository;

namespace AtelierAuto.Commands
{
    public class ProcesatorStergeComanda : ProcesatorCommandGeneric<CommandStergeComanda>
    {
        public override void Proceseaza(CommandStergeComanda command)
        {
            var write = new WriteRepository();
            var gasit = write.StergereComanda(command.id.ToString());
        }
    }
}