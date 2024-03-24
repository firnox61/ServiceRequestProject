using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        IImageService _ımageService;

        public ImagesController(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        [HttpPost("addcustomerimage")]
        public IActionResult AddCustomerImage([FromForm] IFormFile file, [FromForm] int customerId)
        { //file ve carId lazım kullanıcı tarafından.
            Image image = new()
            {
                CustomerId = customerId
                // CarId = carId 
            };
            var result = _ımageService.AddCustomerImage(file, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("addemployeeimage")]
        public IActionResult AddEmployeeImage([FromForm] IFormFile file, [FromForm] int employeeId)
        { //file ve carId lazım kullanıcı tarafından.
            Image image = new()
            {
                EmployeeId = employeeId
                // CarId = carId 
            };
            var result = _ımageService.AddEmployeeImage(file, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
