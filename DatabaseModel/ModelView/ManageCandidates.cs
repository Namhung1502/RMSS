using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.ModelView
{
    public class ManageCandidates
    {
        public int CANDIDATE_ID { get; set; }
        public string NAMEJOBID { get; set; }
        public string NAME_CANDIDATE { get; set; }
        public string GENDER { get; set; }
        public DateTime BIRTHDAY_CANDIDATE { get; set; }
        public string PHONE_CANDIDATE { get; set; }
        public string EMAIL { get; set; }
        public string REQUEST { get; set; }
        public string ADDRESS_CANDIDATE { get; set; }
        public DateTime HISTORYAPPLY { get; set; }
        public int? CANDIDATE_JOB_POINT { get; set; }
    }
}
