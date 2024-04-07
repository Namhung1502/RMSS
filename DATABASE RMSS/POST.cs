namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POSTS")]
    public partial class POST
    {
        [Key]
        public int POST_ID { get; set; }

        [StringLength(300)]
        public string TITLE { get; set; }

        public string CONTENT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? POST_DATE { get; set; }

        public int ACC_ID { get; set; }

        public virtual ACCOUNT_RECRUITER ACCOUNT_RECRUITER { get; set; }
    }
}
