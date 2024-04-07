using DATABASE_RMSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DataAccessObject
{
    public class ManageRecruiterDAO
    {
        Model1 mydb = new Model1();

        //  LẤY MỘT ACCOUNT KHI BIẾT ACCID
        public ACCOUNT_RECRUITER GetAccByAccID(int id)
        {
            return mydb.ACCOUNT_RECRUITER.Where(a => a.ACC_ID == id).FirstOrDefault();
        }

        // LẤY TOÀN BỘ DANH SÁCH TRONG BẢNG
        // HÀM  NÀY HỖ TRỢ CHO VIỆC ĐẨY DỮ LIỆU LÊN BẢNG
        public List<ACCOUNT_RECRUITER> getAcc()
        {
            return mydb.ACCOUNT_RECRUITER.ToList();
        }

        // HÀM NÀY ĐỂ THÊM MỘT ĐỐI TƯỢNG MỚI
        public void AddObject<T>(T obj)
        {
            mydb.Set(obj.GetType()).Add(obj);
        }

        // HÀM UPDATE MỘT ACCOUNT
        public ACCOUNT_RECRUITER GetAccAndUpdate(int id)
        {
            return mydb.ACCOUNT_RECRUITER.Where(a => a.ACC_ID == id).FirstOrDefault();
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
