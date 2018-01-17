using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Commands;
using AtelierAuto.Evenimente;

namespace AtelierAuto.App_Start
{
    public static class ConfiguratieDDD
    {
        public static void config()
        {
            MagistralaCommands.Instance.Value.InregistreazaProcesatoareStandard();
            MagistralaEvenimente.Instanta.Value.InregistreazaProcesatoareStandard();
            MagistralaEvenimente.Instanta.Value.InchideInregistrarea();
        }
    }
}