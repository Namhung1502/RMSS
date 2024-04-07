namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INFO_COMPANY
    {
        [Key]
        public int COMPAYID { get; set; }

        [Required]
        public string INTRODUCTION_COMPANY { get; set; }

        [Required]
        [StringLength(10)]
        public string PHONE_COMPANY { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL_COMPANY { get; set; }

        [Required]
        public string ADDRESS_COMPANY { get; set; }

        [StringLength(15)]
        public string LOGO_COMPANY { get; set; }
    }
}
