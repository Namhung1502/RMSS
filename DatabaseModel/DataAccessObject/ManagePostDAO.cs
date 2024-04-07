using DATABASE_RMSS;
using DatabaseModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DataAccessObject
{
    public class ManagePostDAO
    {
        Model1 mydb = new Model1();

        //lấy toàn bộ các bài post
        public List<PostRecruiter> getPost()
        {
            var query = from a in mydb.POSTS
                        join b in mydb.ACCOUNT_RECRUITER on a.ACC_ID equals b.ACC_ID
                        select new PostRecruiter()
                        {
                            POST_ID = a.POST_ID,
                            TITTLE = a.TITLE,
                            CONTENT = a.CONTENT,
                            POST_DATE = (DateTime)a.POST_DATE,
                            ACC_ID = a.ACC_ID,
                            RECRUITERS_NAME = b.RECRUITERS_NAME
                            
                        };
            return query.ToList();
        }
        // them 1 doi tuong mới
        public void AddObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Add(obj);
        }
        //lấy 1 bài post theo ID
        public POST GetPostByID(int id)
        {
            return mydb.POSTS.Where(a => a.POST_ID == id).FirstOrDefault();
        }

        //lấy các bài post theo RecruiterID
        public List<PostRecruiter> GetPostByRecruiterID(int id)
        {
            var query = from a in mydb.POSTS
                        join b in mydb.ACCOUNT_RECRUITER on a.ACC_ID equals b.ACC_ID
                        where a.ACC_ID == id
                        select new PostRecruiter()
                        {
                            POST_ID = a.POST_ID,
                            TITTLE = a.TITLE,
                            CONTENT = a.CONTENT,
                            POST_DATE = (DateTime)a.POST_DATE,
                            ACC_ID = a.ACC_ID,
                            RECRUITERS_NAME = b.RECRUITERS_NAME
                        };
            return query.ToList();
        }

        // HÀM DELETE 1 ACCOUNT
        public void DeleteObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Remove(obj);
        }

        // HÀM NÀY ĐỂ LƯU MỌI THAY ĐỔI
        public void Save()
        {
            mydb.SaveChanges();
        }
    }
}
