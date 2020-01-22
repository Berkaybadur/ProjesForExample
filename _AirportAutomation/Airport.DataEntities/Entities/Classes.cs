using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Classes")]
    public class Classes
    {
        public Classes()
        {
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ClassesId")]
        public int ClassesId { get; set; }
        [Required]
        [Column("ClassName")]
        public string ClassName { get; set; }
    }
}
