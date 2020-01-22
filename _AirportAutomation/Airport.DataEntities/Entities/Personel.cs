using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Personel")]
    public class Personel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("PersonelId")]
        public int PersonelId { get; set; }
        [Required]
        [Column("PersonelTc")]
        public string PersonelTc { get; set; }
        [Required]
        [Column("PersonelFirstName")]
        public string PersonelFirstName { get; set; }
        [Required]
        [Column("PersonelLastName")]
        public string PersonelLastName { get; set; }
        [Required]
        [Column("PersonelPhoneNumber")]
        public string PersonelPhoneNumber { get; set; }
        [Required]
        [Column("PersonelAddress")]
        public string PersonelAddress { get; set; }
        [Required]
        [Column("AirplaneId")]
        public int AirplaneId { get; set; }
        [Required]
        [Column("TitleId")]
        public int TitleId { get; set; }
        [Required]
        [Column("DistrictId")]
        public int DistrictId { get; set; }
        [ForeignKey("AirplaneId")]
        public  Airplane Airplane { get; set; }
        [ForeignKey("TitleId")]
        public  Title Title { get; set; }
        [ForeignKey("DistrictId")]
        public District District { get; set; }
    }
}
