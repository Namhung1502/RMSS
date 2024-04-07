namespace DATABASE_RMSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANSWER")]
    public partial class ANSWER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANSWER()
        {
            JOBS_QAs = new HashSet<JOBS_QAs>();
        }

        public int ANSWERID { get; set; }

        [StringLength(100)]
        public string ANSWERTEXT { get; set; }

        public int? POINT { get; set; }

        public int QUESTIONID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOBS_QAs> JOBS_QAs { get; set; }

        public virtual QUESTION QUESTION { get; set; }
    }
}
