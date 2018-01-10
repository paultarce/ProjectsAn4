using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Events> eventList = new List<Events>();
            int numberofdevices = 10;
            Random random = new Random();

            int k = 2;
            int limit_variable = 0;
            while (k == 2)
            {
                // One event per device
                for (int devices = 0; devices < numberofdevices; devices++)
                {
                    Events events = new Events();

                    events.Timestamp = DateTime.UtcNow;
                    //events.ParkingId = random.Next(10);
                    events.ParkingId = limit_variable;
                    events.Status = random.Next(3);

                    eventList.Add(events);

                    limit_variable++;

                    if (limit_variable == 10)   // pentru doar 10 senzori sa generez valori
                    {
                        devices = numberofdevices;
                        k = 3;
                    }
                }
            }
            //////////////////
            HttpClient client = new HttpClient();
            //Events obj = new Events(DateTime.Now, 2, 2);


            List<string> eventListApi = new List<string>();
            // private int _id = 0;
            var jsonString = "";
            foreach (Events ev in eventList)
            {
                jsonString = JsonConvert.SerializeObject(ev);
                eventListApi.Add(jsonString);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                var result = client.PostAsync("http://localhost:54287/api/values", content).Result;
            }
            
            
            //var result = client.PostAsync("https://datcproiectginbell.azurewebsites.net/", content).Result;
           // var result = client.PostAsync("http://localhost:56851/api/values", content).Result;// pe local pot face debug
           // var result = client.PostAsync("http://localhost:54287/api/values", content).Result;// pe local pot face debug
            //var a = 2;

        }
    }
}
