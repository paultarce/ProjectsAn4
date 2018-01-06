using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using AtelierAuto.Models;
using AtelierAuto.Evenimente;
using System.IO;

namespace AtelierAuto.Repository
{
    public class WriteRepository
    {
        public WriteRepository()
        {

        }


        public Comanda GasesteComnada(Guid idComanda)
        {
            //load events
            var evemimenteComanda = IncarcaListaDeEvenimente().Where(e => e.IdRadacina == idComanda);
            return new Comanda(evemimenteComanda);
        }
        public Comanda PlaseazaComanda(Comanda comanda)
        {
            var comandaNoua = new Comanda(comanda);
            SalvareEvenimente(comandaNoua);
            SalvareComandaInListaComenzi(comanda);
            return comandaNoua;
            
        }

        public void SalvareEvenimente(Comanda comanda)
        {
            SalvareEvenimente(comanda.EvenimenteNoi);

        }

        public void SalvareEvenimente(ReadOnlyCollection<Eveniment> evenimentNoi)
        {
            List<Eveniment> toateEvenimentele = IncarcaListaDeEvenimente();
            toateEvenimentele.AddRange(evenimentNoi);

            //scrie in baza de date evenimentele// sau in fisier : scrie - continut - fisier
        }

        private void SalvareComandaInListaComenzi(Comanda comanda)
        {
            List<Comanda> toateComenzile = IncarcaListaDeComenzi();
            toateComenzile.Add(comanda);
        }

        private List<Comanda> IncarcaListaDeComenzi()
        {
            List<Comanda> toateComenzile = new List<Comanda>();
            //citire din baza date a comenzilor // sau din fisier json

            return toateComenzile;
        }

        public List<Eveniment> IncarcaListaDeEvenimente()
        {
            List<Eveniment> toateEvenimentele = new List<Eveniment>();

            //citire din DB evenimente 
            return toateEvenimentele;
        }
       
    }
}