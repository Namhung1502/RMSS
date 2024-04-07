using DATABASE_RMSS;
using DatabaseModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DataAccessObject
{
    public class ManageCandidateDAO
    {
        Model1 mydb = new Model1();
        public List<ManageCandidates> GetCandidate()
        {
            var query = from a in mydb.CANDIDATE_APPLY
                        join b in mydb.MANAGEJOB on a.JOBID equals b.JOBID
                        select new ManageCandidates()
                        {
                            CANDIDATE_ID = a.CANDIDATE_ID,
                            NAMEJOBID = b.NAMEJOBID,
                            NAME_CANDIDATE = a.NAME_CANDIDATE,
                            BIRTHDAY_CANDIDATE = a.BIRTHDAY_CANDIDATE,
                            PHONE_CANDIDATE = a.PHONE_CANDIDATE,
                            EMAIL = a.EMAIL,
                            ADDRESS_CANDIDATE = a.ADDRESS_CANDIDATE,
                            CANDIDATE_JOB_POINT = a.CANDIDATE_JOB_POINT,
                            HISTORYAPPLY = (DateTime)a.HISTORYAPPLY
                        };
            return query.ToList();
        }
        public CANDIDATE_APPLY GetCandidateByID(int id)
        {
            return mydb.CANDIDATE_APPLY.Where(a => a.CANDIDATE_ID == id).FirstOrDefault();
        }
        public void DeleteObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Remove(obj);
        }
        public void Save()
        {
            mydb.SaveChanges();
        }
        public void AddObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Add(obj);
        }

        public ManageCandidates GetCandidateApplyByID(int id)
        {
            var query = from a in mydb.CANDIDATE_APPLY
                        join b in mydb.MANAGEJOB on a.JOBID equals b.JOBID
                        where a.CANDIDATE_ID == id
                        select new ManageCandidates()
                        {
                            CANDIDATE_ID = a.CANDIDATE_ID,
                            NAMEJOBID = b.NAMEJOBID,
                            NAME_CANDIDATE = a.NAME_CANDIDATE,
                            GENDER = a.GENDER_CANDIDATE,
                            BIRTHDAY_CANDIDATE = a.BIRTHDAY_CANDIDATE,
                            PHONE_CANDIDATE = a.PHONE_CANDIDATE,
                            EMAIL = a.EMAIL,
                            REQUEST = a.CANDIDATE_REQUEST,
                            ADDRESS_CANDIDATE = a.ADDRESS_CANDIDATE,
                            CANDIDATE_JOB_POINT = a.CANDIDATE_JOB_POINT
                        };
            return query.FirstOrDefault();
        }

        //lay candidate co question va answer da tra loi
        public List<CandidateAnswer> GetCandidateAnswersByID(int id)
        {
            var query = from a in mydb.CANDIDATE_TEST
                        join b in mydb.QUESTION on a.QUESTIONID equals b.QUESTIONID
                        join c in mydb.ANSWER on a.CANDIDATE_ANSWERID equals c.ANSWERID
                        where a.CANDIDATE_ID == id
                        select new CandidateAnswer()
                        {
                            CANDIDATEID = a.CANDIDATE_ID,
                            QUESTIONTEXT = b.QUESTIONTEXT,
                            ANSWERTEXT = c.ANSWERTEXT,
                            POINT = c.POINT
                        };
            return query.ToList();
        }
    }
}
