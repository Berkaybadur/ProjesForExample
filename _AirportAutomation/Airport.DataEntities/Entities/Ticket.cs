using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Ticket")]
    public  class Ticket
    {
        public Ticket()
        {
           
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("TicketId")]
        public int TicketId { get; set; }
        [Required]
        [Column("NumberOfSeats")]
        public string NumberOfSeats { get; set; }
        [Required]
        [Column("ExpeditionId")]
        public int ExpeditionId { get; set; }
        [Required]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Required]
        [Column("ClassesId")]
        public int ClassesId { get; set; }
        [ForeignKey("ClassesId")]
        public Classes Classes { get; set; }
        [Required]
        [Column("AirplaneId")]
        public int AirplaneId { get; set; }
        [ForeignKey("AirportsId")]
        public Airports Airports { get; set; }
        [Required]
        [Column("AirportsId")]
        public int AirportsId { get; set; }
        [ForeignKey("AirplaneId")]
        public  Airplane Airplane { get; set; }
        [ForeignKey("CustomerId")]
        public  Customers Customers { get; set; }
        [ForeignKey("ExpeditionId")]
        public Expedition Expedition { get; set; }
    }
}
