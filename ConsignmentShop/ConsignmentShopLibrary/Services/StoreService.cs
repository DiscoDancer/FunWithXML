using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ConsignmentShopLibrary.Services
{
    public static class StoreService
    {
        public const string FileName = "saved_store.xml";

        public static void SaveToFile(Store store)
        {
            var xml = NaiveXMLSerializer.Serialize(store);
            File.WriteAllText(FileName, xml);
        }

        public static Store ReadFromFile()
        {
            if (!File.Exists(FileName)) return null;

            var serializer = new XmlSerializer(typeof(Store));
            var reader = new StreamReader(FileName);
            var targetStore = (Store)serializer.Deserialize(reader);
            reader.Close();

            OptimizeVendors(targetStore);

            return targetStore;
        }

        public static Store TestStore
            => new Store
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

        public static void OptimizeVendors(Store store)
        {
            // we need to use the same vendor overall
            // but after serialization we have many copies
            foreach (var item in store.Items)
            {
                item.Owner = store.Vendors.FirstOrDefault(x =>
                    x.FirstName == item.Owner.FirstName &&
                    x.LastName == item.Owner.LastName &&
                    x.PaymentDue == item.Owner.PaymentDue);
            }
        }
    }
}
