using ConsignmentShopLibrary;
using ConsignmentShopLibrary.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVendor();
        }

        private static void TestVendor()
        {
            var vendor = new Vendor
            {
                FirstName = "FirstName",
                LastName = "LastName",
                PaymentDue = 11
            };

            var str = NaiveXMLSerializer.Serialize(vendor);

        }
    }
}
