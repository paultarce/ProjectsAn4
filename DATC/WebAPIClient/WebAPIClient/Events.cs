﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient
{
    public class Events
    {
        public Events()
        {
        }

        public Events(DateTime timestamp, int parkingId, int status)
        {
            Timestamp = timestamp;
            ParkingId = parkingId;
            Status = status;
        }

        public DateTime Timestamp { get; set; }
        public int ParkingId { get; set; }
        public int Status { get; set; }
       

    }
}
