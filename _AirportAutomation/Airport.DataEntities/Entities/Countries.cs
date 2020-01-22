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
    [Table("Countries")]
    public  class Countries
    {
        public Countries()
        {
            this.Province = new List<Province>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("CountryId")]
        public int CountryId { get; set; }
        [Required]
        [Column("CountryName")]
        public string CountryName { get; set; }
        public List<Province> Province { get; set; }

    }
}
