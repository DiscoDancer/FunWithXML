using System.IO;
using System.Xml.Serialization;
using ConsignmentShopLibrary;
using ConsignmentShopLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class VendorTest
    {
        [TestMethod]
        public void TestVendorSerialization()
        {
            const string fileName = "vendor.xml";

            // assign
            var vendor = new Vendor
            {
                FirstName = "FirstName",
                LastName = "LastName",
                PaymentDue = 11
            };

            // action
            var str = NaiveXMLSerializer.Serialize(vendor);
            File.WriteAllText(fileName, str);

            // assert
            var serializer = new XmlSerializer(typeof(Vendor));
            var reader = new StreamReader(fileName);
            var targetVendor = (Vendor)serializer.Deserialize(reader);
            reader.Close();

            Assert.IsNotNull(targetVendor);
            Assert.AreEqual(targetVendor.FirstName, vendor.FirstName);
            Assert.AreEqual(targetVendor.LastName, vendor.LastName);
            Assert.AreEqual(targetVendor.PaymentDue, vendor.PaymentDue);
            Assert.AreEqual(targetVendor.Display, vendor.Display);
        }
    }
}
