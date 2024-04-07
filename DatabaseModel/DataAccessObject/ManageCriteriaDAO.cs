using DATABASE_RMSS;
using DatabaseModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DataAccessObject
{
    public class ManageCriteriaDAO
    {
        Model1 mydb = new Model1();

        public List<JobQuestionAnswer> GetJobQuestionAnswer()
        {
            var query = from a in mydb.JOBS_QA
                        join b in mydb.MANAGEJOB on a.JOBID equals b.JOBID
                        join c in mydb.ANSWER on a.ANSWERID equals c.ANSWERID
                        join d in mydb.QUESTION on c.QUESTIONID equals d.QUESTIONID
                        group a by new
                        {
                            a.JOBID,
                            b.NAMEJOBID,
                            d.QUESTIONID,
                            d.QUESTIONTEXT,
                        } into abc
                        select new JobQuestionAnswer()
                        {
                            JOBID = abc.Key.JOBID,
                            NAMEJOBID = abc.Key.NAMEJOBID,
                            QUESTIONID = abc.Key.QUESTIONID,
                            QUESTIONTEXT = abc.Key.QUESTIONTEXT,
                            ANSWERQUESTION = abc.Select(x => new AnswerQuestion
                            {
                                ANSWERID = x.ANSWERID,
                                ANSWERTEXT = x.ANSWER.ANSWERTEXT,
                                POINT = x.ANSWER.POINT
                            }).ToList()
                        };
            return query.ToList();
        }


        public QUESTION GetQuestionByID(int id)
        {
            return mydb.QUESTION.Where(a => a.QUESTIONID == id).FirstOrDefault();
        }
        public void DeleteObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Remove(obj);
        }
        public void Save()
        {
            mydb.SaveChanges();
        }
        public List<JobQuestionAnswer> GetQuestionByJobid(int id)
        {

            var query = from a in mydb.JOBS_QA
                        join b in mydb.MANAGEJOB on a.JOBID equals b.JOBID
                        join c in mydb.ANSWER on a.ANSWERID equals c.ANSWERID
                        join d in mydb.QUESTION on c.QUESTIONID equals d.QUESTIONID

                        where a.JOBID == id

                        group a by new
                        {
                            a.JOBID,
                            b.NAMEJOBID,
                            d.QUESTIONID,
                            d.QUESTIONTEXT,
                        } into abc
                        select new JobQuestionAnswer()
                        {
                            JOBID = abc.Key.JOBID,
                            NAMEJOBID = abc.Key.NAMEJOBID,
                            QUESTIONID = abc.Key.QUESTIONID,
                            QUESTIONTEXT = abc.Key.QUESTIONTEXT,
                            ANSWERQUESTION = abc.Select(x => new AnswerQuestion
                            {
                                ANSWERID = x.ANSWERID,
                                ANSWERTEXT = x.ANSWER.ANSWERTEXT,
                                POINT = x.ANSWER.POINT
                            }).ToList()
                        };

            return query.ToList();
        }
    }
}
