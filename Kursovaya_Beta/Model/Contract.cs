namespace Kursovaya_Beta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [Key]
        [Column("contract")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contract1 { get; set; }

        public DateTime data { get; set; }

        public decimal sum { get; set; }

        public int id_client { get; set; }

        public int id_service { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }

        public virtual Service Service1 { get; set; }
    }
}
