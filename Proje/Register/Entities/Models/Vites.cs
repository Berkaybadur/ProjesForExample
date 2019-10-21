using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    [TableName("AracVites")]
    [PrimaryKey("VitesId")]
    public class Vites
    {
        [Column("VitesId")]
        public int VitesId { get; set; }
        [Column("Vitestip")]
        public string Vitestip { get; set; }
        [Column("VitesKod")]
        public string VitesKod { get; set; }
    }
}
