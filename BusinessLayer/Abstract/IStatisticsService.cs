using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStatisticsService
    {
        List<Statistics> GetList();
        void StatisticsAdd(Statistics statistics);
        void StatisticsDelete(Statistics statistics);
        void StatisticsUpdate(Statistics statistics);
        Statistics GetByID(int id);
    }
}
