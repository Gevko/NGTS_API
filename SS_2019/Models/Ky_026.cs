using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SS_2019.Models
{
    public class Ky_026
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool Value { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
    }
}
