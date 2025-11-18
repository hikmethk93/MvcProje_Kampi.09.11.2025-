//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.EntityFramework
//{
//    public class EfContentDal
//    {
//        public List<Content> List(Func<object, bool> predicate)
//        {
//            List<Content> contents = new List<Content>(); // veri kaynağın
//            return contents.Where(predicate).ToList();
//        }
//    }
//}
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfContentDal :GenericRepository<Content>, IContenctDal
    {
        
    }
}
