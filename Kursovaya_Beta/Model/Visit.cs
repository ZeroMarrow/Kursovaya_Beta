namespace Kursovaya_Beta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visit")]
    public partial class Visit
    {
        [Key]
        public double number_card { get; set; }

        public DateTime date_com { get; set; }

        public DateTime date_exit { get; set; }

        public int id_client { get; set; }

        public virtual Client Client { get; set; }
    }
}
