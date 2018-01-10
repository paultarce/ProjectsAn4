using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DATC_API.Models;
using Newtonsoft.Json;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DATC_API.Controllers
{
    public class ValuesController : ApiController
    {

        private Events val;
        private List<Events> listaValori = new List<Events>();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/6
        public IEnumerable<string> Get(int id)
        {
            return new string[] { val.ParkingId.ToString(), val.Status.ToString(), val.Timestamp.ToString() };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Events value) // 
        {
            val = new Events();
            int i = 0;
            i++;
            //  var a = value;
            //   val = value;
            //    listaValori.Add(value);

            WriteIntoDB();


            //primesc date de la generator 

            //scriem in  baza de date 



        }



        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        public void WriteIntoDB(Events ev)
        {
            string _connectionString = "Server=tcp:ginbell-server.database.windows.net,1433;Initial Catalog=GinBell_DB;Persist Security Info=False;User ID=ginbell-server;Password=Parola12!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection DBConn = new SqlConnection(_connectionString);
            SqlCommand getCommand = null;
            SqlCommand insertCommand = null;
            SqlDataReader reader;
            //        List<Events> dataFromTableDate = new List<Date>();
            ///List<DateDePrelucrat> Date = new List<DateDePrelucrat>()
            try
            {
                DBConn = new SqlConnection(_connectionString);
                DBConn.Open();


                string insertCmd = string.Format
                (
                  "INSERT INTO DateDePrelucrat VALUES({0},{1},{2})",
                  ev.ParkingId, ev.Status, ev.Timestamp
                //item.Lat, item.Lng, item.Temperature,
                //item.Humidity, item.Data.ToString("yyyy-MM-dd hh:mm:ss"), item.NeedIrigation
                );
                insertCommand = new SqlCommand(insertCmd, DBConn);
                insertCommand.ExecuteNonQuery();

            }
            catch (Exception exp) { }
            finally
            {
                if (DBConn != null)
                    DBConn.Dispose();
            }

        }
    }
}
