using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AtelierAuto.Models;
using Newtonsoft.Json;
using System.IO;
using AtelierAuto.Evenimente;
using System.Data.SqlClient;

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
        public Comanda CautMeci(Guid Id)
        {
            return ObtineComenzi().Where(m => (dynamic)m.iDComanda == Id).FirstOrDefault();
        }

        public List<Eveniment> IncarcaDinListaDeEvenimente()
        {
            List<Eveniment> toateEvenimentele = new List<Eveniment>();

            using (var cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Paul\Documents\GitHub\ProjectsAn4\AtelierAuto\AtelierAuto\App_Data\MecanicDatabase.mdf;Integrated Security=True'"))
            {
                string _sql = @"SELECT * FROM [dbo].[Comanda] ";
                var cmd = new SqlCommand(_sql, cn);
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} {1} {2} {3}", reader["id"], reader["TipEveniment"], reader["DetaliiEveniment"], reader["IdRadacina"]));
                    }
                }
            }

            return toateEvenimentele;

        }
    }
}

   
