using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Expedition")]
    public class Expedition
    {
        public Expedition()
        {
            this.Ticket = new List<Ticket>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ExpeditionId")]
        public int ExpeditionId { get; set; }
        [Required]
        [Column("DepartureLocation")]
        public string DepartureLocation { get; set; }
        [Required]
        [Column("RotationLocation")]
        public string RotationLocation { get; set; }
        [Required]
        [Column("DepartureDatetime")]
        public DateTime DepartureDatetime { get; set; }
        [Required]
        [Column("RotationDatetime")]
        public DateTime RotationDatetime { get; set; }
        [Required]
        [Column("AirplaneId")]
        public int AirplaneId { get; set; }
        [Required]
        [Column("Price")]
        public decimal Price { get; set; }
        [ForeignKey("AirplaneId")]
        public  Airplane Airplane { get; set; }
        public List<Ticket> Ticket { get; set; }
    }
}
