using System;

namespace FactoryPatternExercise2
{
	public class SQLAccess : IDataAccess
	{
		public SQLAccess()
		{
		}

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading from SQL Database...");
            return new List<Product>
            { new Product() { Name = "xbox", Price = 354.13},
              new Product() { Name = "life", Price = 70000.00 }
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the SQL Database...");
        }
    }
}

