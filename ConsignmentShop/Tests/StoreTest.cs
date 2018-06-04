using System.Linq;
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
            // assign
            var store = StoreService.TestStore;

            // action
            StoreService.SaveToFile(store);

            // assert
            var targetStore = StoreService.ReadFromFile();

            Assert.IsNotNull(targetStore);
            Assert.AreEqual(targetStore.Name, store.Name);

            Assert.AreEqual(targetStore.Vendors.Count(), 1);
            Assert.AreEqual(targetStore.Vendors.First().Display, store.Vendors.First().Display);
            Assert.AreEqual(targetStore.Vendors.First().FirstName, store.Vendors.First().FirstName);
            Assert.AreEqual(targetStore.Vendors.First().LastName, store.Vendors.First().LastName);
            Assert.AreEqual(targetStore.Vendors.First().PaymentDue, store.Vendors.First().PaymentDue);

            Assert.AreEqual(targetStore.Items.Count(), 2);

            Assert.AreEqual(targetStore.Items.First().Display, store.Items.First().Display);
            Assert.AreEqual(targetStore.Items.First().Commission, store.Items.First().Commission);
            Assert.AreEqual(targetStore.Items.First().Description, store.Items.First().Description);
            Assert.AreEqual(targetStore.Items.First().ID, store.Items.First().ID);
            Assert.AreEqual(targetStore.Items.First().PaymentDistributed, store.Items.First().PaymentDistributed);
            Assert.AreEqual(targetStore.Items.First().Price, store.Items.First().Price);
            Assert.AreEqual(targetStore.Items.First().Sold, store.Items.First().Sold);
            Assert.AreEqual(targetStore.Items.First().Title, store.Items.First().Title);
            Assert.AreEqual(targetStore.Items.First().Type, store.Items.First().Type);

            Assert.AreEqual(targetStore.Items.First().Owner.Display, store.Items.First().Owner.Display);
            Assert.AreEqual(targetStore.Items.First().Owner.FirstName, store.Items.First().Owner.FirstName);
            Assert.AreEqual(targetStore.Items.First().Owner.LastName, store.Items.First().Owner.LastName);
            Assert.AreEqual(targetStore.Items.First().Owner.PaymentDue, store.Items.First().Owner.PaymentDue);

            Assert.AreEqual(targetStore.Items.Last().Display, store.Items.Last().Display);
            Assert.AreEqual(targetStore.Items.Last().Commission, store.Items.Last().Commission);
            Assert.AreEqual(targetStore.Items.Last().Description, store.Items.Last().Description);
            Assert.AreEqual(targetStore.Items.Last().ID, store.Items.Last().ID);
            Assert.AreEqual(targetStore.Items.Last().PaymentDistributed, store.Items.Last().PaymentDistributed);
            Assert.AreEqual(targetStore.Items.Last().Price, store.Items.Last().Price);
            Assert.AreEqual(targetStore.Items.Last().Sold, store.Items.Last().Sold);
            Assert.AreEqual(targetStore.Items.Last().Title, store.Items.Last().Title);
            Assert.AreEqual(targetStore.Items.Last().Type, store.Items.Last().Type);

            Assert.AreEqual(targetStore.Items.Last().Owner.Display, store.Items.Last().Owner.Display);
            Assert.AreEqual(targetStore.Items.Last().Owner.LastName, store.Items.Last().Owner.LastName);
            Assert.AreEqual(targetStore.Items.Last().Owner.LastName, store.Items.Last().Owner.LastName);
            Assert.AreEqual(targetStore.Items.Last().Owner.PaymentDue, store.Items.Last().Owner.PaymentDue);
        }
    }
}
