using System;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }


        public static List<Product> Products = new List<Product>(0)
        {
            new Product() { Name = "Xbox", Price = 350 },
            new Product() { Name = "Guitar", Price = 500 },
            new Product() { Name = "iPhone", Price = 800 },
            new Product() { Name = "CandyBar", Price = 1 },
        };


        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo Data Access");
            return Products;
        }

        public void Savedata()
        {
            Console.WriteLine($"I am saving data from Mongo Data Access");
        }

    }
}

