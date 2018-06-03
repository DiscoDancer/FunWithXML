namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal PaymentDue { get; set; }

        public string Display => $"{FirstName} {LastName}- {PaymentDue}₽";
    }
}
