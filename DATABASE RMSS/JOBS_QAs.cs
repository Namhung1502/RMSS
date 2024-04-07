namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_QAs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JOB_QA_ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JOBID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ANSWERID { get; set; }

        public virtual ANSWER ANSWER { get; set; }

        public virtual MANAGEJOB MANAGEJOB { get; set; }
    }
}
