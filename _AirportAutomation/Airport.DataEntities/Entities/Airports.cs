using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Airports")]
    public class Airports
    {
        public Airports()
        {
            this.Airplane = new List<Airplane>();
            this.Ticket = new List<Ticket>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("AirportId")]
        public int AirportId { get; set; }
        [Required]
        [Column("AirportName")]
        public string AirportName { get; set; }
        [Required]
        [Column("DistrictId")]
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District District { get; set; }
        public List<Airplane> Airplane { get; set; }
        public List<Ticket> Ticket { get; set; }
    }
}
