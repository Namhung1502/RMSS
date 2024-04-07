using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.ModelView
{
    public class CandidateAnswer
    {
        public int CANDIDATEID { get; set; }
        public string QUESTIONTEXT { get; set; }
        public string ANSWERTEXT { get; set; }
        public int? POINT { get; set; }
    }
}
