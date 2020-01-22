using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("District")]
    public class District
    {
        public District()
        {
            this.Airports = new List<Airports>();
            this.Customers = new List<Customers>();
            this.Personel = new List<Personel>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("DistrictId")]
        public int DistrictId { get; set; }
        [Required]
        [Column("DistrictName")]
        public string DistrictName { get; set; }
        [Required]
        [Column("ProvincesId")]
        public int ProvincesId { get; set; }
        [ForeignKey("ProvincesId")]
        public Province Province { get; set; }
        public  List<Airports> Airports { get; set; }
        public  List<Customers> Customers { get; set; }
        public  List<Personel> Personel { get; set; }
    }
}

