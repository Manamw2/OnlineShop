using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Cart
{
    internal class CartDto
    {
        public int Id { get; set; }
        public DateTime CartDate { get; set; } = DateTime.Now;
    }
}
