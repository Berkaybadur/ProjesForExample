using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DataEntities.Entities
{
    [Table("Title")]
    public  class Title
    {
        public Title()
        {
            this.Personel = new List<Personel>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("TitleId")]
        public int TitleId { get; set; }
        [Required]
        [Column("TitleName")]
        public string TitleName { get; set; }
        public List<Personel> Personel { get; set; }
    }
}
