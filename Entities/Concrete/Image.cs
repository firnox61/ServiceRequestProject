using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public int ImageId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string? ImagePath { get; set; }
    }
}
