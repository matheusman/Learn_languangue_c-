using Course.Entity;
using Course.Entity.Exception;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				Account account = new BuinnesAccount(1000, "Alex", 1000, 10000);
				account.WithDraw(2000);
			}
			catch (AccountException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}