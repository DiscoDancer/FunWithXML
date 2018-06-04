using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    [Serializable]
    public class Clothes: Item
    {
        public override double Commission { get; set; } = 1.5;
        public override string Type { get; set; } = "Одежда";
    }
}
