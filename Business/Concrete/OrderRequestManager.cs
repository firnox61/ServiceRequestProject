using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Concrete
{
    public class OrderRequestManager : IOrderRequestService
    {
        private readonly string _smtpServer = "smtp.gmail.com"; // SMTP sunucu adresi
        private readonly int _port = 587; // SMTP port numarası
        private readonly string _username = "veneles123@gmail.com"; // E-posta hesabı kullanıcı adı
        private readonly string _password = "z z g f o a b i hyta i za f"; // E-posta hesabı şifresi
        IOrderRequestDal _orderRequestDal;
        public OrderRequestManager(IOrderRequestDal orderRequestDal)
        {
            _orderRequestDal = orderRequestDal;
        }

        public async Task SendEmailAsync(string toEmail, string subject, OrderRequest orderRequest)
        {
            _orderRequestDal.Add(orderRequest);
            using (var message = new MailMessage(_username, toEmail))
            {
                message.Subject = subject;
                //  message.Body = orderRequest.Description +orderRequest.Email+orderRequest.PhoneNumber+orderRequest.Adress;
                message.Body = $"1. Açıklama: {orderRequest.Description}{Environment.NewLine}" +
                 $"2. E-posta: {orderRequest.Email}{Environment.NewLine}" +
                 $"3. Telefon Numarası: {orderRequest.PhoneNumber}{Environment.NewLine}" +
                 $"4. Adres: {orderRequest.Adress}";

                using (var client = new SmtpClient(_smtpServer, _port))
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_username, _password);

                    await client.SendMailAsync(message);
                }
            }
            
        }
        public IResult Add(OrderRequest orderRequest)
        {
            _orderRequestDal.Add(orderRequest);
            return new SuccessResult();
        }

        public IResult Delete(OrderRequest orderRequest)
        {
            _orderRequestDal.Delete(orderRequest);
            return new SuccessResult();
        }

        public IDataResult<List<OrderRequest>> GetAll()
        {
            return new SuccessDataResult<List<OrderRequest>>(_orderRequestDal.GetAll());
        }

        public IDataResult<List<OrderRequest>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<OrderRequest>>(_orderRequestDal.GetAll(o=>o.CustomerId == customerId));
        }

        public IDataResult<List<OrderRequest>> GetAllByEmployeeId(int employeeId)
        {
            return new SuccessDataResult<List<OrderRequest>>(_orderRequestDal.GetAll(o=> o.EmployeeId == employeeId));
        }

        public IDataResult<OrderRequest> getById(int orderRequestId)
        {
            return new SuccessDataResult<OrderRequest>(_orderRequestDal.Get(o=>o.OrderId == orderRequestId));
        }

      

        public IResult Update(OrderRequest orderRequest)
        {
            _orderRequestDal.Update(orderRequest);
            return new SuccessResult();
        }
    }
}
