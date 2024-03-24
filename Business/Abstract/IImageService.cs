using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IResult AddCustomerImage(IFormFile file,Image image);
        IResult AddEmployeeImage(IFormFile file, Image image);

        IResult Delete(Image image);
        IResult Update(IFormFile file,Image image);
    }
}
