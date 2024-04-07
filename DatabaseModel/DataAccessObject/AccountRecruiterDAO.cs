
using DATABASE_RMSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DataAccessObject
{
    public class AccountRecruiterDAO
    {
        Model1 mydb = new Model1();

        //bước 1: truy vấn về SQL server để lấy database.
        // function Login
        public ACCOUNT_RECRUITER GetObjectUserByUserName(string username)
        {
            return mydb.ACCOUNT_RECRUITER.Where(a => a.USERNAME == username).FirstOrDefault();
            //FirstOrDefault : trả về một giá trị mặc định khác null
        }
        //lấy toàn bộ danh sách user
        public List<ACCOUNT_RECRUITER> GetListUser()
        {
            return mydb.ACCOUNT_RECRUITER.ToList();
            //sắp xếp theo tên và lấy 2 user
            //return mydb.ACCOUNT_RECRUITER.OrderBy(a=> a.USERNAME).Take(2).ToList();
        }
        //thêm 1 object (1 hàng của table) vao DB
        // support button add for add job
        public void AddObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Add(obj);
        }
        //delete 1 object
        // support delete job
        public void DeleteObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Remove(obj);
        }
        //Save all
        public void Save()
        {
            mydb.SaveChanges();
        }
    }
}
