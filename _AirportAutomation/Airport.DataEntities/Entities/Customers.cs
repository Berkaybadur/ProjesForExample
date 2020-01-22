using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Customers")]
    public  class Customers
    {
        public Customers()
        {
            
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Required]
        [Column("CustomerTc")]
        public string CustomerTc { get; set; }
        [Required]
        [Column("CustomerName")]
        public string CustomerName { get; set; }
        [Required]
        [Column("CustomerSurname")]
        public string CustomerSurname { get; set; }
        [Required]
        [Column("CustomerMail")]
        public string CustomerMail { get; set; }
        [Required]
        [Column("CustomerPhone")]
        public string CustomerPhone { get; set; }
        [Required]
        [Column("CustomerAdress")]
        public string CustomerAdress { get; set; }
        [Required]
        [Column("UserName")]
        public string UserName { get; set; }
        [Required]
        [Column("UserPassword")]
        public string UserPassword { get; set; }
        [Required]
        [Column("DegreeId")]
        public int DegreeId { get; set; }
        [Required]
        [Column("DistrictId")]
        public int DistrictId { get; set; }
        [ForeignKey("DegreeId")]
        public  Degree Degree { get; set; }
        [ForeignKey("DistrictId")]
        public  District District { get; set; }

    }
}

