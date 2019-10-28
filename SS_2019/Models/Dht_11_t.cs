using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SS_2019.Models
{
    public class Dht_11_t
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
    }
}
