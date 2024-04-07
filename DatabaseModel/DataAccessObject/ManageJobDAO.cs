using DATABASE_RMSS;
using DatabaseModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DataAccessObject
{
    public class ManageJobDAO
    {
        Model1 mydb = new Model1();


        public List<Job> findJob()
        {
            var query = from a in mydb.MANAGEJOB

                        select new Job()
                        {
                            JOBID = a.JOBID,
                            NAMEJOBID = a.NAMEJOBID,
                            DESCRIPTIONJOB = a.DESCRIPTIONJOB,
                            STRENGTH = a.STRENGTH,

                        };
            return query.ToList();
        }

        //lay 1 job khi biet jobid
        public MANAGEJOB GetJobByJobID(int id)
        {
            return mydb.MANAGEJOB.Where(a => a.JOBID == id).FirstOrDefault();
        }
        public List<MANAGEJOB> GetJobOnApply()
        {
            return mydb.MANAGEJOB.Where(a => a.OPENAPPLY == "yes").ToList();
        }
        //lấy toàn bộ job
        public List<MANAGEJOB> getJob()
        {
            return mydb.MANAGEJOB.ToList();
        }
        //lay 1 job and update
        public MANAGEJOB GetJobAndUpdate(int id)
        {
            return mydb.MANAGEJOB.Where(a => a.JOBID == id).FirstOrDefault();
        }

        // them 1 doi tuong mới
        public void AddObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Add(obj);
        }
        //delete 1 object
        public void DeleteObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Remove(obj);
        }
        public void Save()
        {
            mydb.SaveChanges();
        }
    }
}
