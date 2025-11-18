using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Statistics
    {
        [Key]
        public int StatisticsID { get; set; }
        public string StatisticsName { get; set; }//toplam Kategori 
        public string StatisticsValue { get; set; }//Yazılım Kategorisine ait başlık sayısı
        public string StatisticsValue2 { get; set; }//Yazar adında 'a' harfi geçen yazar sayısı
        //public string StatisticsValue3 { get; set; }//En fazla başlığa sahip kategori adları
        public string StatisticsText { get; set; }//Kategori tablosunda durum kıyaslaması


    }
}
