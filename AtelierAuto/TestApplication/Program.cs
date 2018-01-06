using System;
using AtelierAuto.Commands;
using AtelierAuto.Controllers;
using AtelierAuto.Models;
using AtelierAuto.Models.Generic;
using AtelierAuto.Repository;
using AtelierAuto.Evenimente;


namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MagistralaCommands.Instance.Value.InregistreazaProcesatoareStandard();
            MagistralaEvenimente.Instanta.Value.InregistreazaProcesatoareStandard();
            MagistralaEvenimente.Instanta.Value.InchideInregistrarea();

            var writeRepo = new WriteRepository();
            var readRepo = new ReadRepository();

            var masina = new Masina(new PlainText("WV Passat"), 2005, new CIV("EI309MNN"), new SerieSasiu("ALABALAPR"));
            var mecanic = new Mecanic(new PlainText("Nelutu"), 1);
            var client = new Client(new PlainText("Orlando"), 1);

            var comanda = new Comanda(mecanic, client,new Guid(), masina, "reparatie turbina");

            var commandPlasareComanda = new CommandPlasareComanda();
            MagistralaCommands.Instance.Value.Trimite(commandPlasareComanda);

            writeRepo.SalvareEvenimente(comanda);
            readRepo.CautMeci(new Guid());
            readRepo.IncarcaDinListaDeEvenimente();

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
