using System;

namespace ConsignmentShopLibrary
{
    [Serializable]
    public class Book: Item
    {
        public override double Commission { get; set; } = 1.3;
        public override string Type { get; set; } = "Книга";
    }
}
