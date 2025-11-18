using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StatisticsManager : IStatisticsService
    {
        IStatisticsDal _statisticsDal;

        public StatisticsManager(IStatisticsDal statisticsDal)
        {
            _statisticsDal = statisticsDal;
        }

        public Statistics GetByID(int id)
        {
            return _statisticsDal.Get(x=>x.StatisticsID==id);
        }

        public List<Statistics> GetList()
        {
            return _statisticsDal.List();
        }

        public void StatisticsAdd(Statistics statistics)
        {
            _statisticsDal.Insert(statistics);
        }

        public void StatisticsDelete(Statistics statistics)
        {
            _statisticsDal.Delete(statistics);
        }

        public void StatisticsUpdate(Statistics statistics)
        {
            _statisticsDal.Update(statistics);
        }
    }
}
