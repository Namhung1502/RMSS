namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACCOUNT_RECRUITER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNT_RECRUITER()
        {
            POSTS = new HashSet<POST>();
        }

        [Key]
        public int ACC_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string PASSWORDS { get; set; }

        [StringLength(30)]
        public string RECRUITERS_NAME { get; set; }

        [StringLength(10)]
        public string ROLE_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTS { get; set; }
    }
}
