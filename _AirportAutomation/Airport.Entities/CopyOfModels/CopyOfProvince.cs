using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities.CopyOfModels
{
    [DataContract]
   public class CopyOfProvince
    {
        [DataMember]
        public int ProvincesId { get; set; }
        [DataMember]
        public string ProvincesName { get; set; }
        [DataMember]
        public Nullable<int> Country_Id { get; set; }
    }
}
