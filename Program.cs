using Course.Entity;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			Account acc1 = new Account(0, "Alex", 100.0);
			BuinnesAccount acc2 = new BuinnesAccount(0, "Joao", 100.0, 200.00);

			//Upcasting
			Account acc3 = new BuinnesAccount(0, "jorje", 100.0, 100.0);

			//Downcasting
			if (acc3 is BuinnesAccount) {
				BuinnesAccount acc4 = (BuinnesAccount)acc3;
				Console.WriteLine("Write");
			}
		}
	}
}