using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    
        [TableName("Renk")]
        [PrimaryKey("RenkId")]
        public class Renk
        {
            [Column("RenkId")]
            public int RenkId { get; set; }
            [Column("Renkler")]
            public string Renkler { get; set; }
            [Column("RenkKod")]
            public string RenkKod { get; set; }
        }
    }

