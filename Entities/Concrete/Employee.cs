using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Starts { get; set; }
        public int FinishWorks { get; set; }
    }
}
