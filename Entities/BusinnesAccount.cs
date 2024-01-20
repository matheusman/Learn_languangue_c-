namespace Course.Entity
{
	class BuinnesAccount : Account
	{

		public double LoanLimit { get; set; }

		public BuinnesAccount() { }

		public BuinnesAccount(int number, string holder, double balance, double loanLimit)
		: base(number, holder, balance)
		{
			LoanLimit = loanLimit;
		}

		public void Loan (double amount ) {
			if (amount <= LoanLimit) {
				Balance += LoanLimit;
			}
		}

	}
}