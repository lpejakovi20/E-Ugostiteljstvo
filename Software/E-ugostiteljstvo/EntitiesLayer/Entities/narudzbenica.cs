namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("narudzbenica")]
    public partial class narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public narudzbenica()
        {
            namirnica_u_katalogu = new HashSet<namirnica_u_katalogu>();
        }

        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] datum_kreiranja { get; set; }

        public decimal sveukupan_iznos { get; set; }

        public int broj_stavki { get; set; }

        public int zaposlenik_id { get; set; }

        public virtual zaposlenik zaposlenik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<namirnica_u_katalogu> namirnica_u_katalogu { get; set; }
    }
}
