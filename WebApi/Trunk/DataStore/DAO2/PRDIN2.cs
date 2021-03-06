namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRDIN2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM { get; set; }

        public decimal LASTUPRICE { get; set; }

        public decimal LASTQTY { get; set; }

        public decimal LASTQTY1 { get; set; }

        public decimal LASTQTY2 { get; set; }

        public decimal LASTQTY3 { get; set; }

        public decimal LASTAMOUNT { get; set; }

        public decimal UPRICE { get; set; }

        public decimal QTY { get; set; }

        public decimal QTY1 { get; set; }

        public decimal QTY2 { get; set; }

        public decimal QTY3 { get; set; }

        public decimal AMOUNT { get; set; }

        public int ISOPEN { get; set; }
    }
}
