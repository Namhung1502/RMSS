using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.ModelView
{
    public class PostRecruiter
    {
        public int POST_ID { get; set; }
        public string TITTLE { get; set; }
        public string CONTENT { get; set; }
        [Column("Datetime", TypeName = "smalldatetime")]
        public DateTime POST_DATE { get; set; }
        public int ACC_ID { get; set; }
        public string RECRUITERS_NAME { get; set; }
    }
}
