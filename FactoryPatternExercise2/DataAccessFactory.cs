using System;
namespace FactoryPatternExercise2
{
	public static class DataAccessFactory
	{
		public static IDataAccess GetDataAccessType(string databaseType)
		{
			switch (databaseType.ToLower())
			{
				case "list":
					return new ListAccess();
				case "sql":
					return new SQLAccess();
				case "mongo":
					return new MongoAccess();
				default:
					return new ListAccess();
			}
		}
	}
}

