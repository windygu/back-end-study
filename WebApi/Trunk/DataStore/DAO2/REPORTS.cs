namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REPORTS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string RPTTYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RPTNAME { get; set; }

        [StringLength(50)]
        public string DESCR { get; set; }
    }
}
