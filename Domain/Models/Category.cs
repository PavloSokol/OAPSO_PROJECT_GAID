using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public IList<Product> Products { set; get; } = new List<Product>();
    }
}
