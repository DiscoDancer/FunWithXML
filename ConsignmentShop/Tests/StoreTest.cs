using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ConsignmentShopLibrary;
using ConsignmentShopLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class StoreTest
    {
        [TestMethod]
        public void TestStoreSerialization()
        {
            const string fileName = "store.xml";

            // assign
            var store = new Store
            {
                Name = "MyAwesomeStore",
                Vendors = new[]
                {
                    new Vendor
                    {
                        FirstName = "FirstName",
                        LastName = "LastName",
                        PaymentDue = 11
                    }
                }.ToList()
            };

            // action
            var str = NaiveXMLSerializer.Serialize(store);
            File.WriteAllText(fileName, str);

            // assert
        }
    }
}
