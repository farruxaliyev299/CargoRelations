using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRelations.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
