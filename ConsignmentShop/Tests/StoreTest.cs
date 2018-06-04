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

            //// передаем в конструктор тип класса
            //var formatter = new XmlSerializer(typeof(Store));

            //// получаем поток, куда будем записывать сериализованный объект
            //using (var fs = new FileStream("perfect_store.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, store);
            //}

            //return;

            // action
            var str = NaiveXMLSerializer.Serialize(store);
            File.WriteAllText(fileName, str);

            // assert
            var serializer = new XmlSerializer(typeof(Store));
            var reader = new StreamReader(fileName);
            var targetStore = (Store)serializer.Deserialize(reader);
            reader.Close();

            Assert.IsNotNull(targetStore);
            Assert.AreEqual(targetStore.Name, store.Name);

            Assert.AreEqual(targetStore.Vendors.Count(), 1);
            Assert.AreEqual(targetStore.Vendors.First().Display, store.Vendors.First().Display);
            Assert.AreEqual(targetStore.Vendors.First().FirstName, store.Vendors.First().FirstName);
            Assert.AreEqual(targetStore.Vendors.First().LastName, store.Vendors.First().LastName);
            Assert.AreEqual(targetStore.Vendors.First().PaymentDue, store.Vendors.First().PaymentDue);

            Assert.AreEqual(targetStore.Items.Count(), 2);
        }
    }
}
