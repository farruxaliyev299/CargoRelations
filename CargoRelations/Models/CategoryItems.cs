using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRelations.Models
{
    public class CategoryItems
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
