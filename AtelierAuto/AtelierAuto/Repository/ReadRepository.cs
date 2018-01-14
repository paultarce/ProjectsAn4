﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models;
using Newtonsoft.Json;
using System.IO;
using AtelierAuto.Evenimente;
using System.Data.SqlClient;
using AtelierAuto.Models.Generic;

namespace AtelierAuto.Repository
{
    public class ReadRepository
    {
        public ReadRepository()
        {

        }

        public IEnumerable<Comanda> ObtineComenzi()
        {
            List<Comanda> toateComenzile = new List<Comanda>();
            //read comenzi din DB
            return toateComenzile.AsEnumerable();
        }

        public Comanda CautaComanda(Guid Id)
        {
            return ObtineComenzi().Where(m => (dynamic)m.iDComanda == Id).FirstOrDefault();
        }

        public static List<Eveniment> IncarcaDinListaDeEvenimente() // sau list <comenzi>
        {
            List<Eveniment> toateEvenimentele = new List<Eveniment>();
            List<Eveniment> evenimenteCitite = new List<Eveniment>();
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paul\Documents\GitHub\ProjectsAn4\AtelierAuto\AtelierAuto\App_Data\MecanicDatabase.mdf;Integrated Security=True
            //  using (var cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename" +
            //    @"='C:\Users\Paul\Documents\GitHub\ProjectsAn4\AtelierAuto\AtelierAuto\App_Data\MecanicDatabase.mdf';Integrated Security=True'"))
            using (var cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename" +
              @"='C:\Users\Paul\Documents\GitHub\ProjectsAn4\AtelierAuto\AtelierAuto\App_Data\MecanicDatabase.mdf';Integrated Security=True"))
            {
                string _sql = @"SELECT * FROM [dbo].[Comanda] ";
                var cmd = new SqlCommand(_sql, cn);
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //afisez ce citesc din baza de date
                        Console.WriteLine(String.Format("{0} {1} {2} {3}", reader["Id"], reader["TipEveniment"], reader["DetaliiEveniment"], reader["IdRadacina"]));
                       

                        // split pe detalii: campurile din detaliii sa  fie string - split cu " split(' " ');
                        // din Detalii imi creez un agg root .
                        


                        Eveniment e = new Eveniment(new IDComanada(Convert.ToInt32(reader["Id"])), TipEveniment.PlasareComnada, reader["DetaliiEveniment"]); //(TipEveniment)Enum.Parse(typeof(TipEveniment), reader["TipEveniment"].ToString())
                        evenimenteCitite.Add(e);
                    }
                }
            }

            return evenimenteCitite;
        }
    }
}

   
