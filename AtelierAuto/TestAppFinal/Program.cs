using System;
using AtelierAuto.Commands;
using AtelierAuto.Controllers;
using AtelierAuto.Models;
using AtelierAuto.Models.Generic;
using AtelierAuto.Repository;
using AtelierAuto.Evenimente;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;



namespace TestAppFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            MagistralaCommands.Instance.Value.InregistreazaProcesatoareStandard();
            MagistralaEvenimente.Instanta.Value.InregistreazaProcesatoareStandard();
            MagistralaEvenimente.Instanta.Value.InchideInregistrarea();
            List<Eveniment> eve = new List<Eveniment>();

            var writeRepo = new WriteRepository();
            var readRepo = new ReadRepository();

            Masina masina = new Masina("WV Passat", 2005, new CIV("EI309MNN"), new SerieSasiu("ALABALAPR"));
            Mecanic mecanic = new Mecanic("Nelutu", 1);
            Client client = new Client("Orlando", 1);

            Masina masina2 = new Masina("Opel Astra", 2010, new CIV("PPPPPPPP"), new SerieSasiu("SASIUAUD"));
            Mecanic mecanic2 = new Mecanic("Mihai", 3);
            Client client2 = new Client("Popa", 15);

            var comanda = new Comanda(mecanic, client, new IDComanada(5), masina, "distributie");

            //readRepo.CautaComanda("5");
            
            var comanda2 = new Comanda(mecanic2, client2, new IDComanada(9), masina2, "Distributie,volanta");

            //ReadRepository.IncarcaDinListaDeEvenimente();

             //ADAUG COMANDA 1
              var commandPlasareComanda = new CommandPlasareComanda();
             commandPlasareComanda.Comanda = comanda;
             MagistralaCommands.Instance.Value.Trimite(commandPlasareComanda);
             


            // ADAUG COMANDA 2
            var commandPlasareComanda2 = new CommandPlasareComanda();
            commandPlasareComanda2.Comanda = comanda2;
            MagistralaCommands.Instance.Value.Trimite(commandPlasareComanda2);
            

            //AtlierAuto.Evenimente.ProcesatorPlasareComanda procesatorPlasareComanda = new ProcesatorPlasareComanda()

            //AtelierAuto.Evenimente.ProcesatorPlasareComanda procesatorPlasareComanda = new AtelierAuto.Evenimente.ProcesatorPlasareComanda();

            // SalvareEvenimente(comanda);
            //readRepo.CautaComanda(new Guid());
            //readRepo.IncarcaDinListaDeEvenimente();

            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
