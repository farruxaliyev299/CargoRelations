using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRelations.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public List<ItemSuppliers> ItemSuppliers { get; set; }
        public List<CategoryItems> CategoryItems { get; set; }

    }
}
