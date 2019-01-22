namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PREGSA")]
    public partial class PREGSA
    {
        [Key]
        [StringLength(20)]
        public string PREGSNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PREGSDATE { get; set; }

        [StringLength(20)]
        public string SNNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SHIPDATE { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARKS { get; set; }

        public int ISCONFIRMED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}
