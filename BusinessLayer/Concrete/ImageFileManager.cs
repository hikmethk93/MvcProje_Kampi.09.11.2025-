using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileServise  
    {
        IImageFileDal _imagefileDal;

        public ImageFileManager(IImageFileDal imagefileDal) //ImageFileManager bunun üzerine ctrl+. yapıp generete constructor yapınca bu kısım hazır halde geliyor.
        {
            _imagefileDal = imagefileDal;
        }

        public List<ImageFile> GetList()
        {
           return  _imagefileDal.List();
        }
    }
}
