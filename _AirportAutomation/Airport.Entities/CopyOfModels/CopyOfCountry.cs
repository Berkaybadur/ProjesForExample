using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities.CopyOfModels
{
    [DataContract]
   public class CopyOfCountry
    {
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string CountryName { get; set; }

    }
}
