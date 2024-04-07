using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.ModelView
{
    public class JobQuestionAnswer
    {
        //public int JOBID { get; set; }
        //public string NAMEJOBID { get; set; }
        //public int ANSWERID { get; set; }
        //public string ANSWERTEXT { get; set; }
        //public int? POINT { get; set; }
        //public int QUESTIONID { get; set; }
        //public string QUESTIONTEXT { get; set; }
        public int JOBID { get; set; }
        public string NAMEJOBID { get; set; }
        public int QUESTIONID { get; set; }
        public string QUESTIONTEXT { get; set; }
        public List<AnswerQuestion> ANSWERQUESTION { get; set; }
    }
}
