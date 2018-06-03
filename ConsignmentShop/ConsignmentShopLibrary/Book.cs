using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Book: Item
    {
        public override double Commission { get; set; } = 1.3;
        public override string Type { get; set; } = "Книга";
    }
}
