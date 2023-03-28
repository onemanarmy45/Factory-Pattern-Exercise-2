using System;

namespace FactoryPatternExercise2
{
	public class ListAccess : IDataAccess
	{
		public ListAccess()
		{
		}

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from list");
            return new List<Product>()
            { new Product() { Name = "skateboard", Price = 37.00 },
              new Product() { Name = "lamp", Price = 54.23 }
            };
        }
        public void SaveData()
        {
            Console.WriteLine("Saving data to list");
        }
    }
}

