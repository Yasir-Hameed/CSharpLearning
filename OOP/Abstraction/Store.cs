using System;
namespace OOP.Abstraction
{
    class Store : IStore
    {
        public void StoreClosed()
        {
            Console.WriteLine("Sore Closed"); ;
        }

        public void StoreOpen()
        {
            Console.WriteLine("Store Open"); ;
        }
    }

}
