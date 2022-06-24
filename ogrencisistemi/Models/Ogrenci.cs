namespace ogrencisistemi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ogrenci")]
    public partial class Ogrenci
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Ad { get; set; }

        [StringLength(20)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Tc { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        [StringLength(20)]
        public string BasariDurumu { get; set; }

        [StringLength(20)]
        public string Aldigiegitim { get; set; }
    }
}
