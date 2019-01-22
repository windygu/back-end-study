namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMACYB")]
    public partial class ITEMACYB
    {
        [Key]
        public int ITEMACYB_ID { get; set; }

        public int ITEMACYA_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        public decimal QTY { get; set; }
    }
}
