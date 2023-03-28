using System;

namespace FactoryPatternExercise2
{
    public class MongoAccess : IDataAccess
    {
        public MongoAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from MongoDB");
            return new List<Product>
            { new Product() { Name = "boomerang", Price = 13.13 },
              new Product() { Name = "microscope", Price = 54.54 }
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to MongoDB");
        }
        
    }
}