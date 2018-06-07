using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentShopLibrary.Services;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var store = StoreService.TestStore;


            //StoreService.SaveToFile(store);


            var store = StoreService.ReadFromFile();

        }
    }
}
