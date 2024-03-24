using Business.Abstract;
using Core.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        IEmailSender _emailSender;

        public EmailsController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        //// Form gösterimi için get işlemi
        //public IActionResult Index()
        //{
        //    return Ok();
        //}

        // Form gönderimi için post işlemi
        [HttpPost]
        public async Task<IActionResult> Index(string toEmail, string subject, string body)
        {
            // E-posta gönderme işlemi
            try
            {
                await _emailSender.SendEmailAsync(toEmail, subject, body);
                return Ok(Messages.SendEmailSucces);
               // ViewBag.Message = "E-posta başarıyla gönderildi.";
               // return View();
            }
            catch (Exception ex)
            {
                return BadRequest(Messages.SendEmailerror);
                //ViewBag.Error = $"E-posta gönderilirken bir hata oluştu: {ex.Message}";
               // return View();
            }
        }
    }
}