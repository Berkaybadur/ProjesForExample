using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    [TableName("Araba")]
    [PrimaryKey("ArabaId")]
    public class Arac
    {
        [Column("ArabaId")]
        public int ArabaId { get; set; }
        [Column("AracAd")]
        public string AracAd { get; set; }
        [Column("AracKod")]
        public string AracKod { get; set; }
        [Column("IsDeleted")]
        public int IsDeleted { get; set; }


    }   
}
