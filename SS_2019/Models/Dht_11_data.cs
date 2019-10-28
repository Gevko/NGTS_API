using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NGTS.Models
{
    public class Dht_11_data
    {
        // Humidity
        public float H_Value { get; set; }

        // Temperature
        public float T_Value { get; set; }

        public DateTime Date { get; set; }
    }
}
