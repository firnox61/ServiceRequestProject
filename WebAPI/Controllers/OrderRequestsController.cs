using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderRequestsController : ControllerBase
    {
        IOrderRequestService _orderRequestService;

        public OrderRequestsController(IOrderRequestService orderRequestService)
        {
            _orderRequestService = orderRequestService;
        }

        [HttpPost("add")]
        public ActionResult Add(OrderRequest orderRequest)
        {
            var result = _orderRequestService.Add(orderRequest);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _orderRequestService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyCustomer")]
        public ActionResult GetByCustomer(int customerId)
        {
            var result = _orderRequestService.GetAllByCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyemployee")]
        public ActionResult GetByEmployee(int employeeId)
        {
            var result = _orderRequestService.GetAllByEmployeeId(employeeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public ActionResult GetById(int orderRequestId) 
        {
            var result=_orderRequestService.getById(orderRequestId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(OrderRequest orderRequest)
        {
            var result = _orderRequestService.Update(orderRequest);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(OrderRequest orderRequest)
        {
            var result = _orderRequestService.Delete(orderRequest);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
