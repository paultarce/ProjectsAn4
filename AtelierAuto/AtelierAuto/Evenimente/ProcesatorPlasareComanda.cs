﻿using AtelierAuto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models;
using System.Data.SqlClient;



namespace AtelierAuto.Evenimente
{
    public class ProcesatorPlasareComanda : ProcesatorEveniment
    {
        public override void Proceseaza(Eveniment e)
        {
            var repo = new WriteRepository();

            //var ePlasareComanda = e.ToGeneric<Comanda>();

            //var comanda = repo.GasesteComnada(ePlasareComanda.IdRadacina);
            // comanda. // metoda pentru schimbarea  starii in plasata
            //comanda.stareComanda = StareComanda.Creeata;

            //repo.PlaseazaComanda(new Comanda());
            repo.SalvareEvenimente(e);
           
        }
    }
}