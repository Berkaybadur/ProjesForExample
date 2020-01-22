using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Province")]
    public   class Province
    {
        public Province()
        {
    
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ProvincesId")]
        public int ProvincesId { get; set; }
        [Required]
        [Column("ProvincesName")]
        public string ProvincesName { get; set; }
        [Required]
        [Column("CountryId")]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Countries Country { get; set; }
 
    }
}
