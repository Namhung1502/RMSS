namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MANAGEJOB")]
    public partial class MANAGEJOB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MANAGEJOB()
        {
            CANDIDATE_APPLY = new HashSet<CANDIDATE_APPLY>();
            JOBS_QAs = new HashSet<JOBS_QAs>();
        }

        [Key]
        public int JOBID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAMEJOBID { get; set; }

        [Required]
        public string DESCRIPTIONJOB { get; set; }

        [Required]
        [StringLength(200)]
        public string STRENGTH { get; set; }

        public string OTHERREQUEST { get; set; }

        [Required]
        [StringLength(10)]
        public string OPENAPPLY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANDIDATE_APPLY> CANDIDATE_APPLY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOBS_QAs> JOBS_QAs { get; set; }
    }
}
