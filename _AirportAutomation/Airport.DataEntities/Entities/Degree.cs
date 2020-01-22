using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Degree")]
    public  class Degree
    {
        public Degree()
        {
            this.Customers = new List<Customers>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("DegreeId")]
        public int DegreeId { get; set; }
        [Required]
        [Column("Name")]
        public string Name { get; set; }
        public  List<Customers> Customers { get; set; }
    }
}
