namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CANDIDATE_APPLY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANDIDATE_APPLY()
        {
            CANDIDATE_TEST = new HashSet<CANDIDATE_TEST>();
        }

        [Key]
        public int CANDIDATE_ID { get; set; }

        public int JOBID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME_CANDIDATE { get; set; }

        [Required]
        [StringLength(6)]
        public string GENDER_CANDIDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime BIRTHDAY_CANDIDATE { get; set; }

        [Required]
        [StringLength(13)]
        public string PHONE_CANDIDATE { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(200)]
        public string ADDRESS_CANDIDATE { get; set; }

        public string CANDIDATE_REQUEST { get; set; }

        public int? CANDIDATE_JOB_POINT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HISTORYAPPLY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANDIDATE_TEST> CANDIDATE_TEST { get; set; }

        public virtual MANAGEJOB MANAGEJOB { get; set; }
    }
}
