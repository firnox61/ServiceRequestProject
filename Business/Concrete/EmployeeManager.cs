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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeDal = employeeDal;
            
        }
        public IResult Add(Employee employee)
        {
            _employeDal.Add(employee);
            return new SuccessResult();
        }

        public IResult Delete(Employee employee)
        {
            _employeDal.Delete(employee);
            return new SuccessResult();
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeDal.GetAll());
        }

        public IResult Update(Employee employee)
        {
            _employeDal.Update(employee);
            return new SuccessResult();
        }
    }
}
