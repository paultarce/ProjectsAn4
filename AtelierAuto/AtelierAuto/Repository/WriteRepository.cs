using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using AtelierAuto.Models;
using AtelierAuto.Evenimente;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using AtelierAuto.Models.Generic;


namespace AtelierAuto.Repository
{
    public class WriteRepository
    {
        public WriteRepository()
        {

        }


        public Comanda GasesteComnada(IDComanada idComanda)
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
           // SalvareEvenimente(comanda.EvenimenteNoi);

        }

        public void SalvareEvenimente(Eveniment evenimentNoi)
        {
          //  List<Eveniment> toateEvenimentele = IncarcaListaDeEvenimente();
          //  toateEvenimentele.AddRange(evenimentNoi);

            string detalii;
            var tipEveniment = evenimentNoi.Tip;
            detalii = "Blabla";
            var IdRadacina = "Passat";

            ///Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paul\Documents\GitHub\ProjectsAn4\AtelierAuto\AtelierAuto\App_Data\MecanicDatabase.mdf;Integrated Security=True
            using (var cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename"+
                @"='C:\Users\Paul\Documents\GitHub\ProjectsAn4\AtelierAuto\AtelierAuto\App_Data\MecanicDatabase.mdf';Integrated Security=True")) //incerc si fara '
            {
                string _sql = @"INSERT INTO [dbo].[Comanda](TipEveniment,DetaliiEveniment,IdRadacina)" +
                      "VALUES (@tipEveniment,@detalii,@IdRadacina)";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@tipEveniment", SqlDbType.VarChar))
                    .Value = tipEveniment;
                cmd.Parameters
                    .Add(new SqlParameter("@detalii", SqlDbType.VarChar))
                    .Value = detalii;
                cmd.Parameters
                    .Add(new SqlParameter("@IdRadacina", SqlDbType.VarChar))
                    .Value = IdRadacina;
                cn.Open();
                var reader = cmd.ExecuteReader();


                //scrie in baza de date evenimentele// sau in fisier : scrie - continut - fisier
            }
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