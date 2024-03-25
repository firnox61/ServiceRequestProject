using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderRequestService
    {
        IDataResult<List<OrderRequest>> GetAll();
        IResult Add(OrderRequest orderRequest);
        IResult Delete(OrderRequest orderRequest);
        IResult Update(OrderRequest orderRequest);
        IDataResult<OrderRequest> getById(int orderRequestId);
        IDataResult<List<OrderRequest>> GetAllByCustomerId(int customerId);
        IDataResult<List<OrderRequest>> GetAllByEmployeeId(int employeeId);
        Task SendEmailAsync(string toEmail, string subject,OrderRequest orderRequest );
    }
}
