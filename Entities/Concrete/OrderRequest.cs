using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderRequest : IEntity
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
