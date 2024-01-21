using Course.Entity.Exception;

namespace Course.Entity
{
	class BuinnesAccount : Account
	{

		public double LoanLimit { get; set; }

		public BuinnesAccount(int number, string holder, double balance, double loanLimit)
		: base(number, holder, balance)
		{
			LoanLimit = loanLimit;
		}

		public void Loan(double amount)
		{
			if (amount <= LoanLimit)
			{
				Balance += LoanLimit;
			}
		}

		public override double WithDraw(double amount)
		{
			if (amount > Balance)
			{
				throw new AccountException("this value is not allowed because you balance");
			}
			if (LoanLimit < amount) {
				throw new AccountException("you limit with saque is not allowed");
			}
			return Balance -= amount;
		}
		public override double Deposite(double amount)
		{
			return Balance += amount;
		}

	}
}