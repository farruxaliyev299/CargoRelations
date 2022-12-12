using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRelations.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Phone { get; set; }
        public List<ItemSuppliers> ItemSuppliers { get; set; }
    }
}
