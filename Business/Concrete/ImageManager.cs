using Business.Abstract;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        private readonly IFileHelper _fileHelper;
        public ImageManager(IImageDal imageDal, IFileHelper fileHelper)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
        }
        public IResult AddCustomerImage(IFormFile file,Image image)
        {
            string guid = _fileHelper.Add(file);
            image.ImagePath = guid;
            _imageDal.Add(image);
            return new SuccessResult();
        }
        public IResult AddEmployeeImage(IFormFile file, Image image)
        {
            string guid = _fileHelper.Add(file);
            image.ImagePath = guid;
            _imageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(Image image)
        {
           _imageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {
           return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public IResult Update(IFormFile file, Image image)
        {
            _fileHelper.Update(file, image.ImagePath!);
            _imageDal.Update(image);
            return new SuccessResult();
        }
    }
}
