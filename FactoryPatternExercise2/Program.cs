namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database are you using? List, SQL, or Mongo...");
            var response = Console.ReadLine();

            IDataAccess da = DataAccessFactory.GetDataAccessType(response);

            var products = da.LoadData();

            Console.WriteLine("Here are the products:");

            foreach (var item in products)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Price: ${item.Price}");
            }

            da.SaveData();
        }
    }
}
