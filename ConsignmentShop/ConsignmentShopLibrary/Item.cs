using System;

namespace ConsignmentShopLibrary
{
    public abstract class Item
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }

        public string Display
            => $"[{Type}] {Title} - {Price}₽";

        public abstract double Commission { get; set; }
        public abstract string Type { get; set; }

    }
}
