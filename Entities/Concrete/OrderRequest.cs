using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderRequest : IEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
