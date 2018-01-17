using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models;

namespace AtelierAuto.Commands
{
    public class CommandCautaComanda : Command
    {
        public Comanda Comanda { get; set; }
    }
}