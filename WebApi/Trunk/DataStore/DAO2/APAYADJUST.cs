namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APAYADJUST")]
    public partial class APAYADJUST
    {
        [Key]
        [StringLength(20)]
        public string AANUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(30)]
        public string PAYACC { get; set; }

        public int ACCSIGN { get; set; }

        public decimal AMOUNT { get; set; }

        public int POST { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string PRJCODE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        public int? VNUM { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public DateTime? CHECKEDSTAMP { get; set; }

        [StringLength(20)]
        public string CHECKEDUSER { get; set; }

        public int? ISCHECKED { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}
