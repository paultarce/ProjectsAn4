using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models;
using AtelierAuto.Models.Generic;

namespace AtelierAuto.Commands
{
    public class CommandAcceptareComanda :Command
    {
        public IDComanada IdComanda { get; set; }
        public Comanda Comanda { get; set; }
    }
}