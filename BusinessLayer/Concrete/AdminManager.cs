using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminServise
    {
        IAdminDal _adminDal;


        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
     

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }

        public void AdminAdd(Admin admin)
        {
          _adminDal.Insert(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x => x.AdminID == id);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
