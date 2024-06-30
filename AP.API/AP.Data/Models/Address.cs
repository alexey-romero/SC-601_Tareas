using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Data.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string? AddressLine { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public int? ZipCode { get; set; }
        public virtual User? User { get; set; }
    }
}
