using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    [TableName("AracModel")]
    [PrimaryKey("ModelId")]
    public class AracModel
    {
        [Column("ModelId")]
        public int Id { get; set; }
        [Column("ModelAd")]
        public string ModelAd { get; set; }
        [Column("AracCode")]
        public string AracCode { get; set; }
        [Column("IsDeleted")]
        public string IsDeleted { get; set; }

    }
}
