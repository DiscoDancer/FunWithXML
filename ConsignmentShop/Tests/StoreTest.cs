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
                }.ToList(),
                Items = new Item[]
                {
                    new Clothes
                    {
                        Title = "Baseball Cap",
                        Description = "A very nice one",
                        Price = 11,
                        Sold = true,
                        PaymentDistributed = false,
                        Owner = new Vendor
                        {
                            FirstName = "FirstName",
                            LastName = "LastName",
                            PaymentDue = 11
                        }
                    },
                    new Book
                    {
                        Title = "Pro ASP NET Core",
                        Description = "Very interesting book",
                        Price = 14,
                        Sold = true,
                        PaymentDistributed = false,
                        Owner = new Vendor
                        {
                            FirstName = "FirstName",
                            LastName = "LastName",
                            PaymentDue = 11
                        }
                    }
                }.ToList()
            };

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Store));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("perfect_store.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, store);
            }

            return;

            // action
            var str = NaiveXMLSerializer.Serialize(store);
            File.WriteAllText(fileName, str);

            // assert
        }
    }
}
