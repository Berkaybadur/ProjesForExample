using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Airplane")]
    public  class Airplane
    {
        public Airplane()
        {
            this.Expedition = new List<Expedition>();
            this.Personel = new List<Personel>();
            this.Ticket = new List<Ticket>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("AirplaneId")]
        public int AirplaneId { get; set; }
        [Required]
        [Column("AirplaneName")]
        public string AirplaneName { get; set; }
        [Required]
        [Column("SeatingCapacity")]
        public string SeatingCapacity { get; set; }
        [Required]
        [Column("AirportId")]
        public int AirportId { get; set; }
        [ForeignKey("AirportId")]
        public Airports Airports { get; set; }

        public List<Expedition> Expedition { get; set; }
        public List<Personel> Personel { get; set; }
        public  List<Ticket> Ticket { get; set; }
    }
}
