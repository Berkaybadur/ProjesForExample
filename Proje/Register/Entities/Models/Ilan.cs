using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    [TableName("Ilan")]
    [PrimaryKey("Id")]
    public class Ilan
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("AracAd")]
        public string AracAd { get; set; }
        [Column("AracModel")]
        public string AracModel { get; set; }
        [Column("Kullanici")]
        public string Kullanici { get; set; }
        [Column("Acıklama")]
        public string Acıklama { get; set; }
        [Column("BaslangicTarih")]
        public DateTime BaslangicTarih { get; set; }
        [Column("BitisTarih")]
        public DateTime BitisTarih { get; set; }
        [Column("IsDeleted")]
        public int IsDeleted { get; set; }
        [Column("Renk")]
        public string Renk { get; set; }
        [Column("Vites")]
        public string Vites { get; set; }
        [Column("Yil")]
        public string Yil { get; set; }
        [Column("KM")]
        public decimal KM { get; set; }
        [Column("Fiyat")]
        public decimal Fiyat { get; set; }
    }
}
