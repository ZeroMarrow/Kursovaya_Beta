namespace Kursovaya_Beta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales_services
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int type_sale { get; set; }

        public DateTime date_sale { get; set; }

        public int id_client { get; set; }

        public decimal sum { get; set; }

        [Required]
        [StringLength(10)]
        public string manager { get; set; }

        public virtual Client Client { get; set; }
    }
}
