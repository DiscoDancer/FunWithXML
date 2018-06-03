using System.IO;
using System.Xml.Serialization;
using ConsignmentShopLibrary;
using ConsignmentShopLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void TestBookSerialization()
        {
            const string fileName = "book.xml";

            // assign
            var book = new Book
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
            };

            // action
            var str = NaiveXMLSerializer.Serialize(book);
            File.WriteAllText(fileName, str);

            // assert
            var serializer = new XmlSerializer(typeof(Book));
            var reader = new StreamReader(fileName);
            var targetBook = (Book)serializer.Deserialize(reader);
            reader.Close();

            Assert.IsNotNull(targetBook);
            Assert.AreEqual(targetBook.Title, book.Title);
            Assert.AreEqual(targetBook.Description, book.Description);
            Assert.AreEqual(targetBook.Price, book.Price);
            Assert.AreEqual(targetBook.Sold, book.Sold);
            Assert.AreEqual(targetBook.PaymentDistributed, book.PaymentDistributed);
            Assert.AreEqual(targetBook.ID, book.ID);
            Assert.AreEqual(targetBook.Display, book.Display);
            Assert.AreEqual(targetBook.Commission, book.Commission);
            Assert.AreEqual(targetBook.Type, book.Type);

            Assert.IsNotNull(targetBook.Owner);
            Assert.AreEqual(targetBook.Owner.FirstName, book.Owner.FirstName);
            Assert.AreEqual(targetBook.Owner.LastName, book.Owner.LastName);
            Assert.AreEqual(targetBook.Owner.PaymentDue, book.Owner.PaymentDue);

        }
    }
}
