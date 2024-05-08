using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public int ImageId { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public string? ImagePath { get; set; }
    }
}
