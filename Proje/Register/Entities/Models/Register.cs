using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    [TableName("Register")]
    [PrimaryKey("Id")]
    public class Register
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("UserName")]    
        public string UserName { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("SurName")]
        public string SurName { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("Adress")]
        public string Adress { get; set; }
        [Column("NotRegistered")]
        public int NotRegistered { get; set; }
    }
}
