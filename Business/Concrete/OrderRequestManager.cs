using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderRequestManager : IOrderRequestService
    {
        IOrderRequestDal _orderRequestDal;
        public OrderRequestManager(IOrderRequestDal orderRequestDal)
        {
            _orderRequestDal = orderRequestDal;
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
