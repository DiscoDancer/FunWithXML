using System.IO;
using System.Xml.Serialization;
using ConsignmentShopLibrary;
using ConsignmentShopLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ClothesTest
    {
        [TestMethod]
        public void TestClothesSerialization()
        {
            const string fileName = "clothes.xml";

            // assign
            var clothes = new Clothes
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
            };

            // action
            var str = NaiveXMLSerializer.Serialize(clothes);
            File.WriteAllText(fileName, str);

            // assert
            var serializer = new XmlSerializer(typeof(Clothes));
            var reader = new StreamReader(fileName);
            var targetClothes = (Clothes)serializer.Deserialize(reader);
            reader.Close();

            Assert.IsNotNull(targetClothes);
            Assert.AreEqual(targetClothes.Title, clothes.Title);
            Assert.AreEqual(targetClothes.Description, clothes.Description);
            Assert.AreEqual(targetClothes.Price, clothes.Price);
            Assert.AreEqual(targetClothes.Sold, clothes.Sold);
            Assert.AreEqual(targetClothes.PaymentDistributed, clothes.PaymentDistributed);
            Assert.AreEqual(targetClothes.ID, clothes.ID);
            Assert.AreEqual(targetClothes.Display, clothes.Display);
            Assert.AreEqual(targetClothes.Commission, clothes.Commission);
            Assert.AreEqual(targetClothes.Type, clothes.Type);

            Assert.IsNotNull(targetClothes.Owner);
            Assert.AreEqual(targetClothes.Owner.FirstName, clothes.Owner.FirstName);
            Assert.AreEqual(targetClothes.Owner.LastName, clothes.Owner.LastName);
            Assert.AreEqual(targetClothes.Owner.PaymentDue, clothes.Owner.PaymentDue);

        }
    }
}
